namespace UobFormPrototype02
{
    partial class UserControlSystemInformation
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
            this.SystemInformationLabel = new System.Windows.Forms.Label();
            this.SystemInformationDisplay = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // SystemInformationLabel
            // 
            this.SystemInformationLabel.AutoSize = true;
            this.SystemInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemInformationLabel.Location = new System.Drawing.Point(173, 22);
            this.SystemInformationLabel.Name = "SystemInformationLabel";
            this.SystemInformationLabel.Size = new System.Drawing.Size(147, 20);
            this.SystemInformationLabel.TabIndex = 0;
            this.SystemInformationLabel.Text = "System Information";
            this.SystemInformationLabel.Click += new System.EventHandler(this.SystemInformationLabel_Click);
            // 
            // SystemInformationDisplay
            // 
            this.SystemInformationDisplay.GridLines = true;
            this.SystemInformationDisplay.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SystemInformationDisplay.Location = new System.Drawing.Point(26, 58);
            this.SystemInformationDisplay.MultiSelect = false;
            this.SystemInformationDisplay.Name = "SystemInformationDisplay";
            this.SystemInformationDisplay.Size = new System.Drawing.Size(595, 328);
            this.SystemInformationDisplay.TabIndex = 1;
            this.SystemInformationDisplay.UseCompatibleStateImageBehavior = false;
            this.SystemInformationDisplay.View = System.Windows.Forms.View.Details;
            this.SystemInformationDisplay.SelectedIndexChanged += new System.EventHandler(this.SystemInformationDisplay_SelectedIndexChanged);
            // 
            // UserControlSystemInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SystemInformationDisplay);
            this.Controls.Add(this.SystemInformationLabel);
            this.Name = "UserControlSystemInformation";
            this.Size = new System.Drawing.Size(655, 417);
            this.Load += new System.EventHandler(this.UserControlSystemInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SystemInformationLabel;
        private System.Windows.Forms.ListView SystemInformationDisplay;
    }
}
