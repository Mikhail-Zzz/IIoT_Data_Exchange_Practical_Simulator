namespace MqttLabStudent
{
    partial class LabForm
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
            label1 = new Label();
            BrokerAddressTextBox = new TextBox();
            ConnectToBrokerButton = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            SendButton = new Button();
            label3 = new Label();
            SendMessageTextBox = new RichTextBox();
            SendTopicTextBox = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            SubscribeButton = new Button();
            SubscribeTopicTextBox = new TextBox();
            label4 = new Label();
            tabPage3 = new TabPage();
            MonitorPlotsTablePanel = new TableLayoutPanel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Broker address:";
            // 
            // BrokerAddressTextBox
            // 
            BrokerAddressTextBox.Location = new Point(128, 12);
            BrokerAddressTextBox.Name = "BrokerAddressTextBox";
            BrokerAddressTextBox.Size = new Size(424, 27);
            BrokerAddressTextBox.TabIndex = 1;
            BrokerAddressTextBox.Text = "broker.hivemq.com:8000/mqtt";
            // 
            // ConnectToBrokerButton
            // 
            ConnectToBrokerButton.Location = new Point(558, 12);
            ConnectToBrokerButton.Name = "ConnectToBrokerButton";
            ConnectToBrokerButton.Size = new Size(175, 29);
            ConnectToBrokerButton.TabIndex = 2;
            ConnectToBrokerButton.Text = "Connect";
            ConnectToBrokerButton.UseVisualStyleBackColor = true;
            ConnectToBrokerButton.Click += ConnectToBrokerButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 45);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(745, 405);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(SendButton);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(SendMessageTextBox);
            tabPage1.Controls.Add(SendTopicTextBox);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(737, 372);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Send";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // SendButton
            // 
            SendButton.Location = new Point(8, 335);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(721, 29);
            SendButton.TabIndex = 12;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 42);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 11;
            label3.Text = "Message:";
            // 
            // SendMessageTextBox
            // 
            SendMessageTextBox.Location = new Point(124, 39);
            SendMessageTextBox.Name = "SendMessageTextBox";
            SendMessageTextBox.Size = new Size(605, 290);
            SendMessageTextBox.TabIndex = 10;
            SendMessageTextBox.Text = "";
            // 
            // SendTopicTextBox
            // 
            SendTopicTextBox.Location = new Point(124, 6);
            SendTopicTextBox.Name = "SendTopicTextBox";
            SendTopicTextBox.Size = new Size(605, 27);
            SendTopicTextBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 9);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 8;
            label2.Text = "Topic:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(SubscribeButton);
            tabPage2.Controls.Add(SubscribeTopicTextBox);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(737, 372);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Subscribe";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // SubscribeButton
            // 
            SubscribeButton.Location = new Point(8, 40);
            SubscribeButton.Name = "SubscribeButton";
            SubscribeButton.Size = new Size(721, 29);
            SubscribeButton.TabIndex = 15;
            SubscribeButton.Text = "Subscribe";
            SubscribeButton.UseVisualStyleBackColor = true;
            SubscribeButton.Click += SubscribeButton_Click;
            // 
            // SubscribeTopicTextBox
            // 
            SubscribeTopicTextBox.Location = new Point(124, 7);
            SubscribeTopicTextBox.Name = "SubscribeTopicTextBox";
            SubscribeTopicTextBox.Size = new Size(605, 27);
            SubscribeTopicTextBox.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 10);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 13;
            label4.Text = "Topic:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(MonitorPlotsTablePanel);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(737, 372);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Monitor";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // MonitorPlotsTablePanel
            // 
            MonitorPlotsTablePanel.ColumnCount = 2;
            MonitorPlotsTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            MonitorPlotsTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            MonitorPlotsTablePanel.Dock = DockStyle.Fill;
            MonitorPlotsTablePanel.Location = new Point(0, 0);
            MonitorPlotsTablePanel.Name = "MonitorPlotsTablePanel";
            MonitorPlotsTablePanel.RowCount = 1;
            MonitorPlotsTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            MonitorPlotsTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            MonitorPlotsTablePanel.Size = new Size(737, 372);
            MonitorPlotsTablePanel.TabIndex = 0;
            // 
            // LabForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 450);
            Controls.Add(tabControl1);
            Controls.Add(ConnectToBrokerButton);
            Controls.Add(BrokerAddressTextBox);
            Controls.Add(label1);
            Name = "LabForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox BrokerAddressTextBox;
        private Button ConnectToBrokerButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button SendButton;
        private Label label3;
        private RichTextBox SendMessageTextBox;
        private TextBox SendTopicTextBox;
        private Label label2;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button SubscribeButton;
        private TextBox SubscribeTopicTextBox;
        private Label label4;
        private TableLayoutPanel MonitorPlotsTablePanel;
    }
}