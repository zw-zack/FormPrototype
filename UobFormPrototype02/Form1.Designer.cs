namespace UobFormPrototype02
{
    partial class UobForm
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MenuDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.Logs = new System.Windows.Forms.Button();
            this.Servers = new System.Windows.Forms.Button();
            this.Services = new System.Windows.Forms.Button();
            this.Processes = new System.Windows.Forms.Button();
            this.SystemInformation = new System.Windows.Forms.Button();
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.userControlLogs = new UobFormPrototype02.UserControlLogs();
            this.userControlServers = new UobFormPrototype02.UserControlServers();
            this.userControlServices = new UobFormPrototype02.UserControlServices();
            this.userControlProcesses = new UobFormPrototype02.UserControlProcesses();
            this.userControlSystemInformation = new UobFormPrototype02.UserControlSystemInformation();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.MenuDescriptionTextBox);
            this.MenuPanel.Controls.Add(this.Logs);
            this.MenuPanel.Controls.Add(this.Servers);
            this.MenuPanel.Controls.Add(this.Services);
            this.MenuPanel.Controls.Add(this.Processes);
            this.MenuPanel.Controls.Add(this.SystemInformation);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(143, 450);
            this.MenuPanel.TabIndex = 0;
            this.MenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            // 
            // MenuDescriptionTextBox
            // 
            this.MenuDescriptionTextBox.Location = new System.Drawing.Point(12, 90);
            this.MenuDescriptionTextBox.Name = "MenuDescriptionTextBox";
            this.MenuDescriptionTextBox.ReadOnly = true;
            this.MenuDescriptionTextBox.Size = new System.Drawing.Size(120, 58);
            this.MenuDescriptionTextBox.TabIndex = 5;
            this.MenuDescriptionTextBox.Text = "";
            this.MenuDescriptionTextBox.TextChanged += new System.EventHandler(this.MenuDescriptionTextBox_TextChanged);
            // 
            // Logs
            // 
            this.Logs.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Logs.Location = new System.Drawing.Point(12, 270);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(120, 23);
            this.Logs.TabIndex = 4;
            this.Logs.Text = "Logs";
            this.Logs.UseVisualStyleBackColor = true;
            this.Logs.Click += new System.EventHandler(this.Logs_Click);
            // 
            // Servers
            // 
            this.Servers.Location = new System.Drawing.Point(12, 241);
            this.Servers.Name = "Servers";
            this.Servers.Size = new System.Drawing.Size(120, 23);
            this.Servers.TabIndex = 3;
            this.Servers.Text = "Server";
            this.Servers.UseVisualStyleBackColor = true;
            this.Servers.Click += new System.EventHandler(this.Server_Click);
            // 
            // Services
            // 
            this.Services.Location = new System.Drawing.Point(12, 212);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(120, 23);
            this.Services.TabIndex = 2;
            this.Services.Text = "Services";
            this.Services.UseVisualStyleBackColor = true;
            this.Services.Click += new System.EventHandler(this.Services_Click);
            // 
            // Processes
            // 
            this.Processes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Processes.Location = new System.Drawing.Point(12, 183);
            this.Processes.Name = "Processes";
            this.Processes.Size = new System.Drawing.Size(120, 23);
            this.Processes.TabIndex = 1;
            this.Processes.Text = "Processes";
            this.Processes.UseVisualStyleBackColor = true;
            this.Processes.Click += new System.EventHandler(this.Processes_Click);
            // 
            // SystemInformation
            // 
            this.SystemInformation.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SystemInformation.Location = new System.Drawing.Point(12, 154);
            this.SystemInformation.Name = "SystemInformation";
            this.SystemInformation.Size = new System.Drawing.Size(120, 23);
            this.SystemInformation.TabIndex = 0;
            this.SystemInformation.Text = "System Information";
            this.SystemInformation.UseVisualStyleBackColor = true;
            this.SystemInformation.Click += new System.EventHandler(this.SystemInformation_Click);
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.Location = new System.Drawing.Point(568, 189);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(200, 100);
            this.DisplayPanel.TabIndex = 1;
            this.DisplayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DisplayPanel_Paint);
            // 
            // userControlLogs
            // 
            this.userControlLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControlLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userControlLogs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userControlLogs.Location = new System.Drawing.Point(149, 12);
            this.userControlLogs.Name = "userControlLogs";
            this.userControlLogs.Size = new System.Drawing.Size(636, 414);
            this.userControlLogs.TabIndex = 6;
            this.userControlLogs.Load += new System.EventHandler(this.UserControlLogs_Load);
            // 
            // userControlServers
            // 
            this.userControlServers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControlServers.Location = new System.Drawing.Point(149, 12);
            this.userControlServers.Name = "userControlServers";
            this.userControlServers.Size = new System.Drawing.Size(636, 414);
            this.userControlServers.TabIndex = 5;
            this.userControlServers.Load += new System.EventHandler(this.UserControlServers_Load);
            // 
            // userControlServices
            // 
            this.userControlServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControlServices.Location = new System.Drawing.Point(149, 12);
            this.userControlServices.Name = "userControlServices";
            this.userControlServices.Size = new System.Drawing.Size(636, 414);
            this.userControlServices.TabIndex = 4;
            this.userControlServices.Load += new System.EventHandler(this.UserControlServices_Load);
            // 
            // userControlProcesses
            // 
            this.userControlProcesses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControlProcesses.Location = new System.Drawing.Point(149, 12);
            this.userControlProcesses.Name = "userControlProcesses";
            this.userControlProcesses.Size = new System.Drawing.Size(636, 414);
            this.userControlProcesses.TabIndex = 3;
            this.userControlProcesses.Load += new System.EventHandler(this.UserControlProcesses_Load);
            // 
            // userControlSystemInformation
            // 
            this.userControlSystemInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControlSystemInformation.Location = new System.Drawing.Point(149, 12);
            this.userControlSystemInformation.Name = "userControlSystemInformation";
            this.userControlSystemInformation.Size = new System.Drawing.Size(636, 414);
            this.userControlSystemInformation.TabIndex = 2;
            this.userControlSystemInformation.Load += new System.EventHandler(this.UserControlSystemInformation_Load);
            // 
            // UobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlLogs);
            this.Controls.Add(this.userControlServers);
            this.Controls.Add(this.userControlServices);
            this.Controls.Add(this.userControlProcesses);
            this.Controls.Add(this.userControlSystemInformation);
            this.Controls.Add(this.DisplayPanel);
            this.Controls.Add(this.MenuPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UobForm";
            this.Load += new System.EventHandler(this.UobForm_Load);
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button Logs;
        private System.Windows.Forms.Button Servers;
        private System.Windows.Forms.Button Services;
        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.Button Processes;
        private System.Windows.Forms.Button SystemInformation;
        private UserControlSystemInformation userControlSystemInformation;
        private UserControlProcesses userControlProcesses;
        private UserControlServers userControlServers;
        private System.Windows.Forms.RichTextBox MenuDescriptionTextBox;
        public UserControlServices userControlServices;
        public UserControlLogs userControlLogs;
    }
}

