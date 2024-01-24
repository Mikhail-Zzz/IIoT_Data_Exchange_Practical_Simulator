namespace MqttLabGenerator
{
    partial class LabGeneratorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            LoadModelFileButton = new Button();
            LoadedModelFileNameLabel = new Label();
            CompilationErrorsTextBox = new RichTextBox();
            AddProjectItemsTabControl = new TabControl();
            tabPage1 = new TabPage();
            ControlItemsDataGridView = new DataGridView();
            ControlItemsDataGridViewContextMenuStrip = new ContextMenuStrip(components);
            ControlItemsDataGridViewContextMenuStripDeleteItemMenuItem = new ToolStripMenuItem();
            AddControlItemButton = new Button();
            ControlDescriptionTextBox = new RichTextBox();
            label3 = new Label();
            ControlTopicTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ControlMethodsComboBox = new ComboBox();
            tabPage2 = new TabPage();
            SensorDataChartTypeComboBox = new ComboBox();
            label7 = new Label();
            SensorDataProvidersDataGridView = new DataGridView();
            SensorDataProvidersDataGridViewContextMenuStrip = new ContextMenuStrip(components);
            SensorDataProvidersDataGridViewContextMenuStripDeleteItemMenuItem = new ToolStripMenuItem();
            AddSensorDataProviderButton = new Button();
            SensorDataDescriptionTextBox = new RichTextBox();
            label6 = new Label();
            SensorDataTopicTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SensorDataProvidersComboBox = new ComboBox();
            tabPage3 = new TabPage();
            VisualizationItemTypeComboBox = new ComboBox();
            label8 = new Label();
            VisualizationItemsDataGridView = new DataGridView();
            VisualizationItemsDataGridViewContextMenuStrip = new ContextMenuStrip(components);
            VisualizationItemsDataGridViewDeleteMenuItem = new ToolStripMenuItem();
            AddVisualizationItemButton = new Button();
            VisualizationItemDescriptionTextBox = new RichTextBox();
            label9 = new Label();
            label10 = new Label();
            VisualizationItemDataProviderComboBox = new ComboBox();
            SaveProjectButton = new Button();
            AddProjectItemsTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ControlItemsDataGridView).BeginInit();
            ControlItemsDataGridViewContextMenuStrip.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SensorDataProvidersDataGridView).BeginInit();
            SensorDataProvidersDataGridViewContextMenuStrip.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VisualizationItemsDataGridView).BeginInit();
            VisualizationItemsDataGridViewContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // LoadModelFileButton
            // 
            LoadModelFileButton.Location = new Point(12, 12);
            LoadModelFileButton.Name = "LoadModelFileButton";
            LoadModelFileButton.Size = new Size(247, 29);
            LoadModelFileButton.TabIndex = 0;
            LoadModelFileButton.Text = "Load model file";
            LoadModelFileButton.UseVisualStyleBackColor = true;
            LoadModelFileButton.Click += LoadModelFileButton_Click;
            // 
            // LoadedModelFileNameLabel
            // 
            LoadedModelFileNameLabel.AutoSize = true;
            LoadedModelFileNameLabel.Location = new Point(265, 16);
            LoadedModelFileNameLabel.Name = "LoadedModelFileNameLabel";
            LoadedModelFileNameLabel.Size = new Size(0, 20);
            LoadedModelFileNameLabel.TabIndex = 1;
            // 
            // CompilationErrorsTextBox
            // 
            CompilationErrorsTextBox.Location = new Point(12, 47);
            CompilationErrorsTextBox.Name = "CompilationErrorsTextBox";
            CompilationErrorsTextBox.ReadOnly = true;
            CompilationErrorsTextBox.Size = new Size(872, 120);
            CompilationErrorsTextBox.TabIndex = 2;
            CompilationErrorsTextBox.Text = "";
            // 
            // AddProjectItemsTabControl
            // 
            AddProjectItemsTabControl.Controls.Add(tabPage1);
            AddProjectItemsTabControl.Controls.Add(tabPage2);
            AddProjectItemsTabControl.Controls.Add(tabPage3);
            AddProjectItemsTabControl.Enabled = false;
            AddProjectItemsTabControl.Location = new Point(12, 173);
            AddProjectItemsTabControl.Name = "AddProjectItemsTabControl";
            AddProjectItemsTabControl.SelectedIndex = 0;
            AddProjectItemsTabControl.Size = new Size(872, 356);
            AddProjectItemsTabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ControlItemsDataGridView);
            tabPage1.Controls.Add(AddControlItemButton);
            tabPage1.Controls.Add(ControlDescriptionTextBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(ControlTopicTextBox);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(ControlMethodsComboBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(864, 323);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Emulator Control Items";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ControlItemsDataGridView
            // 
            ControlItemsDataGridView.AllowUserToAddRows = false;
            ControlItemsDataGridView.AllowUserToResizeRows = false;
            ControlItemsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ControlItemsDataGridView.ContextMenuStrip = ControlItemsDataGridViewContextMenuStrip;
            ControlItemsDataGridView.Location = new Point(439, 6);
            ControlItemsDataGridView.Name = "ControlItemsDataGridView";
            ControlItemsDataGridView.RowHeadersVisible = false;
            ControlItemsDataGridView.RowHeadersWidth = 51;
            ControlItemsDataGridView.RowTemplate.Height = 29;
            ControlItemsDataGridView.Size = new Size(419, 311);
            ControlItemsDataGridView.TabIndex = 11;
            // 
            // ControlItemsDataGridViewContextMenuStrip
            // 
            ControlItemsDataGridViewContextMenuStrip.ImageScalingSize = new Size(20, 20);
            ControlItemsDataGridViewContextMenuStrip.Items.AddRange(new ToolStripItem[] { ControlItemsDataGridViewContextMenuStripDeleteItemMenuItem });
            ControlItemsDataGridViewContextMenuStrip.Name = "contextMenuStrip1";
            ControlItemsDataGridViewContextMenuStrip.Size = new Size(157, 28);
            // 
            // ControlItemsDataGridViewContextMenuStripDeleteItemMenuItem
            // 
            ControlItemsDataGridViewContextMenuStripDeleteItemMenuItem.Name = "ControlItemsDataGridViewContextMenuStripDeleteItemMenuItem";
            ControlItemsDataGridViewContextMenuStripDeleteItemMenuItem.Size = new Size(156, 24);
            ControlItemsDataGridViewContextMenuStripDeleteItemMenuItem.Text = "Delete Item";
            ControlItemsDataGridViewContextMenuStripDeleteItemMenuItem.Click += ControlItemsDataGridViewContextMenuStripDeleteItemMenuItem_Click;
            // 
            // AddControlItemButton
            // 
            AddControlItemButton.Location = new Point(100, 288);
            AddControlItemButton.Name = "AddControlItemButton";
            AddControlItemButton.Size = new Size(333, 29);
            AddControlItemButton.TabIndex = 10;
            AddControlItemButton.Text = "Add Control Item";
            AddControlItemButton.UseVisualStyleBackColor = true;
            AddControlItemButton.Click += AddControlItemButton_Click;
            // 
            // ControlDescriptionTextBox
            // 
            ControlDescriptionTextBox.Location = new Point(100, 73);
            ControlDescriptionTextBox.Name = "ControlDescriptionTextBox";
            ControlDescriptionTextBox.Size = new Size(333, 209);
            ControlDescriptionTextBox.TabIndex = 9;
            ControlDescriptionTextBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 76);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 8;
            label3.Text = "Description:";
            // 
            // ControlTopicTextBox
            // 
            ControlTopicTextBox.Location = new Point(100, 40);
            ControlTopicTextBox.Name = "ControlTopicTextBox";
            ControlTopicTextBox.Size = new Size(333, 27);
            ControlTopicTextBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 43);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 6;
            label2.Text = "Topic:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 5;
            label1.Text = "Handler:";
            // 
            // ControlMethodsComboBox
            // 
            ControlMethodsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ControlMethodsComboBox.FormattingEnabled = true;
            ControlMethodsComboBox.Location = new Point(100, 6);
            ControlMethodsComboBox.Name = "ControlMethodsComboBox";
            ControlMethodsComboBox.Size = new Size(333, 28);
            ControlMethodsComboBox.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(SensorDataChartTypeComboBox);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(SensorDataProvidersDataGridView);
            tabPage2.Controls.Add(AddSensorDataProviderButton);
            tabPage2.Controls.Add(SensorDataDescriptionTextBox);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(SensorDataTopicTextBox);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(SensorDataProvidersComboBox);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(864, 323);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sensor Data Providers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // SensorDataChartTypeComboBox
            // 
            SensorDataChartTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SensorDataChartTypeComboBox.FormattingEnabled = true;
            SensorDataChartTypeComboBox.Location = new Point(97, 72);
            SensorDataChartTypeComboBox.Name = "SensorDataChartTypeComboBox";
            SensorDataChartTypeComboBox.Size = new Size(333, 28);
            SensorDataChartTypeComboBox.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 75);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 16;
            label7.Text = "Chart Type:";
            // 
            // SensorDataProvidersDataGridView
            // 
            SensorDataProvidersDataGridView.AllowUserToAddRows = false;
            SensorDataProvidersDataGridView.AllowUserToResizeRows = false;
            SensorDataProvidersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SensorDataProvidersDataGridView.ContextMenuStrip = SensorDataProvidersDataGridViewContextMenuStrip;
            SensorDataProvidersDataGridView.Location = new Point(439, 6);
            SensorDataProvidersDataGridView.Name = "SensorDataProvidersDataGridView";
            SensorDataProvidersDataGridView.RowHeadersVisible = false;
            SensorDataProvidersDataGridView.RowHeadersWidth = 51;
            SensorDataProvidersDataGridView.RowTemplate.Height = 29;
            SensorDataProvidersDataGridView.Size = new Size(419, 311);
            SensorDataProvidersDataGridView.TabIndex = 15;
            // 
            // SensorDataProvidersDataGridViewContextMenuStrip
            // 
            SensorDataProvidersDataGridViewContextMenuStrip.ImageScalingSize = new Size(20, 20);
            SensorDataProvidersDataGridViewContextMenuStrip.Items.AddRange(new ToolStripItem[] { SensorDataProvidersDataGridViewContextMenuStripDeleteItemMenuItem });
            SensorDataProvidersDataGridViewContextMenuStrip.Name = "SensorDataProvidersDataGridViewContextMenuStrip";
            SensorDataProvidersDataGridViewContextMenuStrip.Size = new Size(157, 28);
            // 
            // SensorDataProvidersDataGridViewContextMenuStripDeleteItemMenuItem
            // 
            SensorDataProvidersDataGridViewContextMenuStripDeleteItemMenuItem.Name = "SensorDataProvidersDataGridViewContextMenuStripDeleteItemMenuItem";
            SensorDataProvidersDataGridViewContextMenuStripDeleteItemMenuItem.Size = new Size(156, 24);
            SensorDataProvidersDataGridViewContextMenuStripDeleteItemMenuItem.Text = "Delete Item";
            SensorDataProvidersDataGridViewContextMenuStripDeleteItemMenuItem.Click += SensorDataProvidersDataGridViewContextMenuStripDeleteItemMenuItem_Click;
            // 
            // AddSensorDataProviderButton
            // 
            AddSensorDataProviderButton.Location = new Point(97, 288);
            AddSensorDataProviderButton.Name = "AddSensorDataProviderButton";
            AddSensorDataProviderButton.Size = new Size(333, 29);
            AddSensorDataProviderButton.TabIndex = 14;
            AddSensorDataProviderButton.Text = "Add Sensor Data Provider";
            AddSensorDataProviderButton.UseVisualStyleBackColor = true;
            AddSensorDataProviderButton.Click += AddSensorDataProviderButton_Click;
            // 
            // SensorDataDescriptionTextBox
            // 
            SensorDataDescriptionTextBox.Location = new Point(97, 106);
            SensorDataDescriptionTextBox.Name = "SensorDataDescriptionTextBox";
            SensorDataDescriptionTextBox.Size = new Size(333, 176);
            SensorDataDescriptionTextBox.TabIndex = 13;
            SensorDataDescriptionTextBox.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 109);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 12;
            label6.Text = "Description:";
            // 
            // SensorDataTopicTextBox
            // 
            SensorDataTopicTextBox.Location = new Point(97, 39);
            SensorDataTopicTextBox.Name = "SensorDataTopicTextBox";
            SensorDataTopicTextBox.Size = new Size(333, 27);
            SensorDataTopicTextBox.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 42);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 8;
            label4.Text = "Topic:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 9);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 7;
            label5.Text = "Provider:";
            // 
            // SensorDataProvidersComboBox
            // 
            SensorDataProvidersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SensorDataProvidersComboBox.FormattingEnabled = true;
            SensorDataProvidersComboBox.Location = new Point(97, 6);
            SensorDataProvidersComboBox.Name = "SensorDataProvidersComboBox";
            SensorDataProvidersComboBox.Size = new Size(333, 28);
            SensorDataProvidersComboBox.TabIndex = 5;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(VisualizationItemTypeComboBox);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(VisualizationItemsDataGridView);
            tabPage3.Controls.Add(AddVisualizationItemButton);
            tabPage3.Controls.Add(VisualizationItemDescriptionTextBox);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(VisualizationItemDataProviderComboBox);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(864, 323);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Emulator Visualization Items";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // VisualizationItemTypeComboBox
            // 
            VisualizationItemTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            VisualizationItemTypeComboBox.FormattingEnabled = true;
            VisualizationItemTypeComboBox.Location = new Point(99, 40);
            VisualizationItemTypeComboBox.Name = "VisualizationItemTypeComboBox";
            VisualizationItemTypeComboBox.Size = new Size(333, 28);
            VisualizationItemTypeComboBox.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 43);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 24;
            label8.Text = "Visualizer:";
            // 
            // VisualizationItemsDataGridView
            // 
            VisualizationItemsDataGridView.AllowUserToAddRows = false;
            VisualizationItemsDataGridView.AllowUserToResizeRows = false;
            VisualizationItemsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VisualizationItemsDataGridView.ContextMenuStrip = VisualizationItemsDataGridViewContextMenuStrip;
            VisualizationItemsDataGridView.Location = new Point(441, 6);
            VisualizationItemsDataGridView.Name = "VisualizationItemsDataGridView";
            VisualizationItemsDataGridView.RowHeadersVisible = false;
            VisualizationItemsDataGridView.RowHeadersWidth = 51;
            VisualizationItemsDataGridView.RowTemplate.Height = 29;
            VisualizationItemsDataGridView.Size = new Size(419, 311);
            VisualizationItemsDataGridView.TabIndex = 23;
            // 
            // VisualizationItemsDataGridViewContextMenuStrip
            // 
            VisualizationItemsDataGridViewContextMenuStrip.ImageScalingSize = new Size(20, 20);
            VisualizationItemsDataGridViewContextMenuStrip.Items.AddRange(new ToolStripItem[] { VisualizationItemsDataGridViewDeleteMenuItem });
            VisualizationItemsDataGridViewContextMenuStrip.Name = "VisualizationItemsDataGridViewContextMenuStrip";
            VisualizationItemsDataGridViewContextMenuStrip.Size = new Size(157, 28);
            // 
            // VisualizationItemsDataGridViewDeleteMenuItem
            // 
            VisualizationItemsDataGridViewDeleteMenuItem.Name = "VisualizationItemsDataGridViewDeleteMenuItem";
            VisualizationItemsDataGridViewDeleteMenuItem.Size = new Size(156, 24);
            VisualizationItemsDataGridViewDeleteMenuItem.Text = "Delete Item";
            VisualizationItemsDataGridViewDeleteMenuItem.Click += VisualizationItemsDataGridViewDeleteMenuItem_Click;
            // 
            // AddVisualizationItemButton
            // 
            AddVisualizationItemButton.Location = new Point(99, 288);
            AddVisualizationItemButton.Name = "AddVisualizationItemButton";
            AddVisualizationItemButton.Size = new Size(333, 29);
            AddVisualizationItemButton.TabIndex = 22;
            AddVisualizationItemButton.Text = "Add Visualization Item";
            AddVisualizationItemButton.UseVisualStyleBackColor = true;
            AddVisualizationItemButton.Click += AddVisualizationItemButton_Click;
            // 
            // VisualizationItemDescriptionTextBox
            // 
            VisualizationItemDescriptionTextBox.Location = new Point(99, 74);
            VisualizationItemDescriptionTextBox.Name = "VisualizationItemDescriptionTextBox";
            VisualizationItemDescriptionTextBox.Size = new Size(333, 208);
            VisualizationItemDescriptionTextBox.TabIndex = 21;
            VisualizationItemDescriptionTextBox.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 77);
            label9.Name = "label9";
            label9.Size = new Size(88, 20);
            label9.TabIndex = 20;
            label9.Text = "Description:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 9);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 19;
            label10.Text = "Provider:";
            // 
            // VisualizationItemDataProviderComboBox
            // 
            VisualizationItemDataProviderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            VisualizationItemDataProviderComboBox.FormattingEnabled = true;
            VisualizationItemDataProviderComboBox.Location = new Point(99, 6);
            VisualizationItemDataProviderComboBox.Name = "VisualizationItemDataProviderComboBox";
            VisualizationItemDataProviderComboBox.Size = new Size(333, 28);
            VisualizationItemDataProviderComboBox.TabIndex = 18;
            // 
            // SaveProjectButton
            // 
            SaveProjectButton.Enabled = false;
            SaveProjectButton.Location = new Point(366, 535);
            SaveProjectButton.Name = "SaveProjectButton";
            SaveProjectButton.Size = new Size(156, 29);
            SaveProjectButton.TabIndex = 6;
            SaveProjectButton.Text = "Save";
            SaveProjectButton.UseVisualStyleBackColor = true;
            SaveProjectButton.Click += SaveProjectButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 573);
            Controls.Add(SaveProjectButton);
            Controls.Add(AddProjectItemsTabControl);
            Controls.Add(CompilationErrorsTextBox);
            Controls.Add(LoadedModelFileNameLabel);
            Controls.Add(LoadModelFileButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mqtt Lab Generator";
            AddProjectItemsTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ControlItemsDataGridView).EndInit();
            ControlItemsDataGridViewContextMenuStrip.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SensorDataProvidersDataGridView).EndInit();
            SensorDataProvidersDataGridViewContextMenuStrip.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VisualizationItemsDataGridView).EndInit();
            VisualizationItemsDataGridViewContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoadModelFileButton;
        private Label LoadedModelFileNameLabel;
        private RichTextBox CompilationErrorsTextBox;
        private TabControl AddProjectItemsTabControl;
        private TabPage tabPage1;
        private DataGridView ControlItemsDataGridView;
        private Button AddControlItemButton;
        private RichTextBox ControlDescriptionTextBox;
        private Label label3;
        private TextBox ControlTopicTextBox;
        private Label label2;
        private Label label1;
        private ComboBox ControlMethodsComboBox;
        private TabPage tabPage2;
        private Button AddSensorDataProviderButton;
        private RichTextBox SensorDataDescriptionTextBox;
        private Label label6;
        private TextBox SensorDataTopicTextBox;
        private Label label4;
        private Label label5;
        private ComboBox SensorDataProvidersComboBox;
        private TabPage tabPage3;
        private DataGridView SensorDataProvidersDataGridView;
        private ContextMenuStrip ControlItemsDataGridViewContextMenuStrip;
        private ToolStripMenuItem ControlItemsDataGridViewContextMenuStripDeleteItemMenuItem;
        private ContextMenuStrip SensorDataProvidersDataGridViewContextMenuStrip;
        private ToolStripMenuItem SensorDataProvidersDataGridViewContextMenuStripDeleteItemMenuItem;
        private Button SaveProjectButton;
        private ComboBox SensorDataChartTypeComboBox;
        private Label label7;
        private ComboBox VisualizationItemTypeComboBox;
        private Label label8;
        private DataGridView VisualizationItemsDataGridView;
        private Button AddVisualizationItemButton;
        private RichTextBox VisualizationItemDescriptionTextBox;
        private Label label9;
        private Label label10;
        private ComboBox VisualizationItemDataProviderComboBox;
        private ContextMenuStrip VisualizationItemsDataGridViewContextMenuStrip;
        private ToolStripMenuItem VisualizationItemsDataGridViewDeleteMenuItem;
    }
}