namespace UobFormPrototype02
{
    partial class UserControlServices
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
            this.ServicesLabel = new System.Windows.Forms.Label();
            this.ServicesDisplay = new System.Windows.Forms.ListView();
            this.ServicesTextBox = new System.Windows.Forms.TextBox();
            this.ServiceStart = new System.Windows.Forms.Button();
            this.ServiceStop = new System.Windows.Forms.Button();
            this.ServicesRefresh = new System.Windows.Forms.Button();
            this.ServicesTextBoxDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ServicesLabel
            // 
            this.ServicesLabel.AutoSize = true;
            this.ServicesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicesLabel.Location = new System.Drawing.Point(266, 9);
            this.ServicesLabel.Name = "ServicesLabel";
            this.ServicesLabel.Size = new System.Drawing.Size(77, 20);
            this.ServicesLabel.TabIndex = 1;
            this.ServicesLabel.Text = "Services";
            // 
            // ServicesDisplay
            // 
            this.ServicesDisplay.FullRowSelect = true;
            this.ServicesDisplay.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ServicesDisplay.Location = new System.Drawing.Point(180, 49);
            this.ServicesDisplay.MultiSelect = false;
            this.ServicesDisplay.Name = "ServicesDisplay";
            this.ServicesDisplay.Size = new System.Drawing.Size(353, 303);
            this.ServicesDisplay.TabIndex = 2;
            this.ServicesDisplay.UseCompatibleStateImageBehavior = false;
            this.ServicesDisplay.View = System.Windows.Forms.View.Details;
            this.ServicesDisplay.SelectedIndexChanged += new System.EventHandler(this.ServicesDisplay_SelectedIndexChanged);
            // 
            // ServicesTextBox
            // 
            this.ServicesTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ServicesTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ServicesTextBox.Location = new System.Drawing.Point(26, 65);
            this.ServicesTextBox.Name = "ServicesTextBox";
            this.ServicesTextBox.Size = new System.Drawing.Size(133, 20);
            this.ServicesTextBox.TabIndex = 3;
            this.ServicesTextBox.TextChanged += new System.EventHandler(this.ServicesTextBox_TextChanged);
            // 
            // ServiceStart
            // 
            this.ServiceStart.Location = new System.Drawing.Point(26, 111);
            this.ServiceStart.Name = "ServiceStart";
            this.ServiceStart.Size = new System.Drawing.Size(106, 23);
            this.ServiceStart.TabIndex = 4;
            this.ServiceStart.Text = "Start";
            this.ServiceStart.UseVisualStyleBackColor = true;
            this.ServiceStart.Click += new System.EventHandler(this.ServiceStart_Click);
            // 
            // ServiceStop
            // 
            this.ServiceStop.Location = new System.Drawing.Point(26, 140);
            this.ServiceStop.Name = "ServiceStop";
            this.ServiceStop.Size = new System.Drawing.Size(106, 23);
            this.ServiceStop.TabIndex = 5;
            this.ServiceStop.Text = "Stop";
            this.ServiceStop.UseVisualStyleBackColor = true;
            this.ServiceStop.Click += new System.EventHandler(this.ServiceStop_Click);
            // 
            // ServicesRefresh
            // 
            this.ServicesRefresh.Location = new System.Drawing.Point(26, 169);
            this.ServicesRefresh.Name = "ServicesRefresh";
            this.ServicesRefresh.Size = new System.Drawing.Size(106, 23);
            this.ServicesRefresh.TabIndex = 6;
            this.ServicesRefresh.Text = "Refresh";
            this.ServicesRefresh.UseVisualStyleBackColor = true;
            this.ServicesRefresh.Click += new System.EventHandler(this.ServicesRefresh_Click);
            // 
            // ServicesTextBoxDescription
            // 
            this.ServicesTextBoxDescription.AutoSize = true;
            this.ServicesTextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicesTextBoxDescription.Location = new System.Drawing.Point(23, 49);
            this.ServicesTextBoxDescription.Name = "ServicesTextBoxDescription";
            this.ServicesTextBoxDescription.Size = new System.Drawing.Size(77, 13);
            this.ServicesTextBoxDescription.TabIndex = 7;
            this.ServicesTextBoxDescription.Text = "Service Name:";
            // 
            // UserControlServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ServicesTextBoxDescription);
            this.Controls.Add(this.ServicesRefresh);
            this.Controls.Add(this.ServiceStop);
            this.Controls.Add(this.ServiceStart);
            this.Controls.Add(this.ServicesTextBox);
            this.Controls.Add(this.ServicesDisplay);
            this.Controls.Add(this.ServicesLabel);
            this.Name = "UserControlServices";
            this.Size = new System.Drawing.Size(632, 379);
            this.Load += new System.EventHandler(this.UserControlServices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServicesLabel;
        private System.Windows.Forms.ListView ServicesDisplay;
        private System.Windows.Forms.TextBox ServicesTextBox;
        private System.Windows.Forms.Button ServiceStart;
        private System.Windows.Forms.Button ServiceStop;
        private System.Windows.Forms.Button ServicesRefresh;
        private System.Windows.Forms.Label ServicesTextBoxDescription;
    }
}
