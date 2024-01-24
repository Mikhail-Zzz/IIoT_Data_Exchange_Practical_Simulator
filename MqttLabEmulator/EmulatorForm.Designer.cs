namespace MqttLabEmulator
{
    partial class EmulatorForm
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
            toolStrip1 = new ToolStrip();
            FileToolStripButton = new ToolStripDropDownButton();
            OpenToolStripMenuItem = new ToolStripMenuItem();
            HelpToolStriputton = new ToolStripDropDownButton();
            ControlItemsHelpMenuItem = new ToolStripMenuItem();
            SensorItemsHelpMenuItem = new ToolStripMenuItem();
            ModelToolStripButton = new ToolStripDropDownButton();
            RunModelMenuItem = new ToolStripMenuItem();
            EmulatorPanel = new TableLayoutPanel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { FileToolStripButton, HelpToolStriputton, ModelToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1070, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // FileToolStripButton
            // 
            FileToolStripButton.DropDownItems.AddRange(new ToolStripItem[] { OpenToolStripMenuItem });
            FileToolStripButton.Name = "FileToolStripButton";
            FileToolStripButton.Size = new Size(46, 24);
            FileToolStripButton.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Size = new Size(128, 26);
            OpenToolStripMenuItem.Text = "Open";
            OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // HelpToolStriputton
            // 
            HelpToolStriputton.DropDownItems.AddRange(new ToolStripItem[] { ControlItemsHelpMenuItem, SensorItemsHelpMenuItem });
            HelpToolStriputton.Name = "HelpToolStriputton";
            HelpToolStriputton.Size = new Size(55, 24);
            HelpToolStriputton.Text = "Help";
            // 
            // ControlItemsHelpMenuItem
            // 
            ControlItemsHelpMenuItem.Name = "ControlItemsHelpMenuItem";
            ControlItemsHelpMenuItem.Size = new Size(224, 26);
            ControlItemsHelpMenuItem.Text = "Control Items";
            ControlItemsHelpMenuItem.Click += ControlItemsHelpMenuItem_Click;
            // 
            // SensorItemsHelpMenuItem
            // 
            SensorItemsHelpMenuItem.Name = "SensorItemsHelpMenuItem";
            SensorItemsHelpMenuItem.Size = new Size(224, 26);
            SensorItemsHelpMenuItem.Text = "Sensor Items";
            SensorItemsHelpMenuItem.Click += SensorItemsHelpMenuItem_Click;
            // 
            // ModelToolStripButton
            // 
            ModelToolStripButton.DropDownItems.AddRange(new ToolStripItem[] { RunModelMenuItem });
            ModelToolStripButton.Name = "ModelToolStripButton";
            ModelToolStripButton.Size = new Size(66, 24);
            ModelToolStripButton.Text = "Model";
            // 
            // RunModelMenuItem
            // 
            RunModelMenuItem.Name = "RunModelMenuItem";
            RunModelMenuItem.Size = new Size(224, 26);
            RunModelMenuItem.Text = "Run";
            RunModelMenuItem.Click += RunModelMenuItem_Click;
            // 
            // EmulatorPanel
            // 
            EmulatorPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            EmulatorPanel.ColumnCount = 2;
            EmulatorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            EmulatorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            EmulatorPanel.Dock = DockStyle.Fill;
            EmulatorPanel.Location = new Point(0, 27);
            EmulatorPanel.Name = "EmulatorPanel";
            EmulatorPanel.RowCount = 2;
            EmulatorPanel.RowStyles.Add(new RowStyle());
            EmulatorPanel.RowStyles.Add(new RowStyle());
            EmulatorPanel.Size = new Size(1070, 586);
            EmulatorPanel.TabIndex = 1;
            // 
            // EmulatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 613);
            Controls.Add(EmulatorPanel);
            Controls.Add(toolStrip1);
            Name = "EmulatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emulator";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton FileToolStripButton;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private ToolStripDropDownButton HelpToolStriputton;
        private ToolStripMenuItem ControlItemsHelpMenuItem;
        private ToolStripMenuItem SensorItemsHelpMenuItem;
        private TableLayoutPanel EmulatorPanel;
        private ToolStripDropDownButton ModelToolStripButton;
        private ToolStripMenuItem RunModelMenuItem;
    }
}