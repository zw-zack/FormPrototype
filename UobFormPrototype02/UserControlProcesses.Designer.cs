namespace UobFormPrototype02
{
    partial class UserControlProcesses
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
            this.ProcessesLabel = new System.Windows.Forms.Label();
            this.ProcessesRefresh = new System.Windows.Forms.Button();
            this.ProcessesStop = new System.Windows.Forms.Button();
            this.ProcessesTextBox = new System.Windows.Forms.TextBox();
            this.ProcessesDisplay = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ProcessesLabel
            // 
            this.ProcessesLabel.AutoSize = true;
            this.ProcessesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessesLabel.Location = new System.Drawing.Point(268, 26);
            this.ProcessesLabel.Name = "ProcessesLabel";
            this.ProcessesLabel.Size = new System.Drawing.Size(83, 20);
            this.ProcessesLabel.TabIndex = 1;
            this.ProcessesLabel.Text = "Processes";
            // 
            // ProcessesRefresh
            // 
            this.ProcessesRefresh.Location = new System.Drawing.Point(19, 146);
            this.ProcessesRefresh.Name = "ProcessesRefresh";
            this.ProcessesRefresh.Size = new System.Drawing.Size(106, 23);
            this.ProcessesRefresh.TabIndex = 11;
            this.ProcessesRefresh.Text = "Refresh";
            this.ProcessesRefresh.UseVisualStyleBackColor = true;
            this.ProcessesRefresh.Click += new System.EventHandler(this.ProcessesRefresh_Click);
            // 
            // ProcessesStop
            // 
            this.ProcessesStop.Location = new System.Drawing.Point(19, 117);
            this.ProcessesStop.Name = "ProcessesStop";
            this.ProcessesStop.Size = new System.Drawing.Size(106, 23);
            this.ProcessesStop.TabIndex = 10;
            this.ProcessesStop.Text = "Stop";
            this.ProcessesStop.UseVisualStyleBackColor = true;
            this.ProcessesStop.Click += new System.EventHandler(this.ProcessesStop_Click);
            // 
            // ProcessesTextBox
            // 
            this.ProcessesTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProcessesTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ProcessesTextBox.Location = new System.Drawing.Point(19, 65);
            this.ProcessesTextBox.Name = "ProcessesTextBox";
            this.ProcessesTextBox.Size = new System.Drawing.Size(133, 20);
            this.ProcessesTextBox.TabIndex = 8;
            // 
            // ProcessesDisplay
            // 
            this.ProcessesDisplay.FullRowSelect = true;
            this.ProcessesDisplay.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ProcessesDisplay.Location = new System.Drawing.Point(173, 49);
            this.ProcessesDisplay.MultiSelect = false;
            this.ProcessesDisplay.Name = "ProcessesDisplay";
            this.ProcessesDisplay.Size = new System.Drawing.Size(457, 303);
            this.ProcessesDisplay.TabIndex = 7;
            this.ProcessesDisplay.UseCompatibleStateImageBehavior = false;
            this.ProcessesDisplay.View = System.Windows.Forms.View.Details;
            this.ProcessesDisplay.SelectedIndexChanged += new System.EventHandler(this.ProcessesDisplay_SelectedIndexChanged);
            // 
            // UserControlProcesses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProcessesRefresh);
            this.Controls.Add(this.ProcessesStop);
            this.Controls.Add(this.ProcessesTextBox);
            this.Controls.Add(this.ProcessesDisplay);
            this.Controls.Add(this.ProcessesLabel);
            this.Name = "UserControlProcesses";
            this.Size = new System.Drawing.Size(745, 395);
            this.Load += new System.EventHandler(this.UserControlProcesses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProcessesLabel;
        private System.Windows.Forms.Button ProcessesRefresh;
        private System.Windows.Forms.Button ProcessesStop;
        private System.Windows.Forms.TextBox ProcessesTextBox;
        private System.Windows.Forms.ListView ProcessesDisplay;
    }
}
