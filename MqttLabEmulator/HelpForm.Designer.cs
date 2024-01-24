namespace MqttLabEmulator
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HelpersDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)HelpersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // HelpersDataGridView
            // 
            HelpersDataGridView.AllowUserToAddRows = false;
            HelpersDataGridView.AllowUserToDeleteRows = false;
            HelpersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            HelpersDataGridView.ColumnHeadersHeight = 29;
            HelpersDataGridView.Dock = DockStyle.Fill;
            HelpersDataGridView.Location = new Point(0, 0);
            HelpersDataGridView.Name = "HelpersDataGridView";
            HelpersDataGridView.ReadOnly = true;
            HelpersDataGridView.RowHeadersVisible = false;
            HelpersDataGridView.RowHeadersWidth = 51;
            HelpersDataGridView.RowTemplate.Height = 29;
            HelpersDataGridView.Size = new Size(800, 450);
            HelpersDataGridView.TabIndex = 0;
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HelpersDataGridView);
            Name = "HelpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpForm";
            ((System.ComponentModel.ISupportInitialize)HelpersDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView HelpersDataGridView;
    }
}