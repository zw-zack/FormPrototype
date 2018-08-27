namespace UobFormPrototype02
{
    partial class UserControlLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlLogs));
            this.LogsLabel = new System.Windows.Forms.Label();
            this.LogsDisplay = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // LogsLabel
            // 
            resources.ApplyResources(this.LogsLabel, "LogsLabel");
            this.LogsLabel.Name = "LogsLabel";
            // 
            // LogsDisplay
            // 
            this.LogsDisplay.FullRowSelect = true;
            this.LogsDisplay.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            resources.ApplyResources(this.LogsDisplay, "LogsDisplay");
            this.LogsDisplay.MultiSelect = false;
            this.LogsDisplay.Name = "LogsDisplay";
            this.LogsDisplay.UseCompatibleStateImageBehavior = false;
            this.LogsDisplay.View = System.Windows.Forms.View.Details;
            this.LogsDisplay.SelectedIndexChanged += new System.EventHandler(this.LogsDisplay_SelectedIndexChanged);
            // 
            // UserControlLogs
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LogsDisplay);
            this.Controls.Add(this.LogsLabel);
            this.Name = "UserControlLogs";
            this.Load += new System.EventHandler(this.UserControlLogs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogsLabel;
        public System.Windows.Forms.ListView LogsDisplay;
    }
}
