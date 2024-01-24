using CommonTypes;
using CommonTypes.Interfaces;
using CommonTypes.ProjectModels;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.Reflection;

namespace MqttLabGenerator.Services
{
    public class ModelCompiler
    {
        public bool Compile(string inputPath, LabProject project, out string[] errors)
        {
            project.ProjectName = Path.GetFileNameWithoutExtension(inputPath);
            project.ProjectPath = Path.Combine(Environment.CurrentDirectory, "Models", project.ProjectName, Guid.NewGuid().ToString());
            project.SourceFilePath = Path.Combine(project.ProjectPath, Constants.SOURCE_FILE_NAME);
            project.ModelFilePath = Path.Combine(project.ProjectPath, Constants.MODEL_FILE_NAME);

            if (!Directory.Exists(project.ProjectPath))
            {
                Directory.CreateDirectory(project.ProjectPath);
            }
            File.Copy(inputPath, project.SourceFilePath, true);

            var source = File.ReadAllText(project.SourceFilePath);
            var syntaxTree = CSharpSyntaxTree.ParseText(source);

            var commonTypesAssembly = typeof(IModel).Assembly;
            var commonTypesReferencedAssembliesFullNames = commonTypesAssembly.GetReferencedAssemblies().Select(assembly => assembly.FullName).ToArray();
            var commonTypesReferencedAssemblies = GetAssembliesByNames(commonTypesReferencedAssembliesFullNames);
            var references = commonTypesReferencedAssemblies.Select(assembly => MetadataReference.CreateFromFile(assembly.Location))
                .Append(MetadataReference.CreateFromFile(typeof(object).Assembly.Location))
                .Append(MetadataReference.CreateFromFile(typeof(IModel).Assembly.Location))
                .ToArray();

            var options = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);
            var compilation = CSharpCompilation.Create(Constants.MODEL_FILE_NAME, new[] { syntaxTree }, references, options);
            var emitResult = compilation.Emit(project.ModelFilePath);

            errors = emitResult.Diagnostics.Select(error => error.ToString()).ToArray();
            return emitResult.Success;
        }

        private Assembly[] GetAssembliesByNames(params string[] names)
        {
            var assembliesDictionary = AppDomain.CurrentDomain.GetAssemblies()
                .ToDictionary(assembly => assembly.FullName, assembly => assembly);

            return names.Where(name => assembliesDictionary.ContainsKey(name))
                .Select(name => assembliesDictionary[name])
                .ToArray();
        }
    }
}
