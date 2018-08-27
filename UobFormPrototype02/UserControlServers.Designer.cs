namespace UobFormPrototype02
{
    partial class UserControlServers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ServersLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ShutDownButton = new System.Windows.Forms.Button();
            this.RebootButton = new System.Windows.Forms.Button();
            this.SleepButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServersLabel
            // 
            this.ServersLabel.AutoSize = true;
            this.ServersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServersLabel.Location = new System.Drawing.Point(229, 36);
            this.ServersLabel.Name = "ServersLabel";
            this.ServersLabel.Size = new System.Drawing.Size(63, 20);
            this.ServersLabel.TabIndex = 1;
            this.ServersLabel.Text = "Servers";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(98, 105);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(388, 126);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ShutDownButton
            // 
            this.ShutDownButton.Location = new System.Drawing.Point(134, 146);
            this.ShutDownButton.Name = "ShutDownButton";
            this.ShutDownButton.Size = new System.Drawing.Size(84, 41);
            this.ShutDownButton.TabIndex = 3;
            this.ShutDownButton.Text = "Shut Down";
            this.ShutDownButton.UseVisualStyleBackColor = true;
            this.ShutDownButton.Click += new System.EventHandler(this.ShutDownButton_Click);
            // 
            // RebootButton
            // 
            this.RebootButton.Location = new System.Drawing.Point(251, 146);
            this.RebootButton.Name = "RebootButton";
            this.RebootButton.Size = new System.Drawing.Size(84, 41);
            this.RebootButton.TabIndex = 4;
            this.RebootButton.Text = "Reboot";
            this.RebootButton.UseVisualStyleBackColor = true;
            this.RebootButton.Click += new System.EventHandler(this.RebootButton_Click);
            // 
            // SleepButton
            // 
            this.SleepButton.Location = new System.Drawing.Point(369, 146);
            this.SleepButton.Name = "SleepButton";
            this.SleepButton.Size = new System.Drawing.Size(84, 41);
            this.SleepButton.TabIndex = 5;
            this.SleepButton.Text = "Sleep";
            this.SleepButton.UseVisualStyleBackColor = true;
            this.SleepButton.Click += new System.EventHandler(this.SleepButton_Click);
            // 
            // UserControlServers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SleepButton);
            this.Controls.Add(this.RebootButton);
            this.Controls.Add(this.ShutDownButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ServersLabel);
            this.Name = "UserControlServers";
            this.Size = new System.Drawing.Size(551, 415);
            this.Load += new System.EventHandler(this.UserControlServers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServersLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button ShutDownButton;
        private System.Windows.Forms.Button RebootButton;
        private System.Windows.Forms.Button SleepButton;
    }
}
