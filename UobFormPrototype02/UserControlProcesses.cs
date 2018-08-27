using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.ListViewItem;
using System.Threading;

namespace UobFormPrototype02
{
    public partial class UserControlProcesses : UserControl
    {
        public UserControlProcesses()
        {
            InitializeComponent();
        }

        private void UserControlProcesses_Load(object sender, EventArgs e)
        {
            LoadProcessesList();
            LoadAutoComplete();
            AddLogs("Accessed Processes");
        }


        private void ProcessesStop_Click(object sender, EventArgs e)
        {
            StopProcessesAction();
        }

        private void ProcessesRefresh_Click(object sender, EventArgs e)
        {
            LoadProcessesList();
            LoadAutoComplete();
            AddLogs("Refreshed Processes");
        }

        private void ProcessesDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ProcessesTextBox.Text = ProcessesDisplay.SelectedItems[0].SubItems[1].Text;
            }
            catch { }
        }


        /*********************************************************************************************************
         *********************************************************************************************************
         *********************************************************************************************************
         *********************************************************************************************************
         * LIST OF FUNCTIONS BELOW:
         *       1. 
         *********************************************************************************************************
         *********************************************************************************************************
         *********************************************************************************************************
         */
        private void LoadProcessesList()
        {
            ProcessesDisplay.Clear();
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader1.Text = "Index";
            columnHeader2.Text = "Process Name";
            columnHeader3.Text = "Responding";
            ProcessesDisplay.Columns.Add(columnHeader1);
            ProcessesDisplay.Columns.Add(columnHeader2);
            ProcessesDisplay.Columns.Add(columnHeader3);

            columnHeader1.Width = 50;
            columnHeader2.Width = 250;
            columnHeader3.Width = 150;
            columnHeader1.TextAlign = HorizontalAlignment.Right;
            Process[] processList = Process.GetProcesses();

            var i = 1;
            foreach (Process process in processList)
            {
                ListViewItem items = new ListViewItem(i.ToString());
                ProcessesDisplay.Items.Add(items);
                if (i % 2 == 0)
                {
                    items.BackColor = Color.LightGoldenrodYellow;
                }
                else
                {
                    items.BackColor = Color.LightGray;
                }
                i++;

                ListViewSubItem subitems1 = new ListViewSubItem
                {
                    Text = process.ProcessName
                };
                items.SubItems.Add(subitems1);

                ListViewSubItem subitems2 = new ListViewSubItem
                {
                    Text = process.Responding.ToString()
                };
                items.SubItems.Add(subitems2);
            }
        }

        private void StopProcessesAction()
        {
            try
            {
                string text = ProcessesTextBox.Text;
                Process[] processList = Process.GetProcesses();
                foreach (Process process in processList)
                {
                    if (process.ProcessName == text)
                    {
                        DialogResult confirm = MessageBox.Show(
                        "This will stop " + text + ", proceed?",
                        "Stop Process",
                        MessageBoxButtons.YesNo);
                        if (confirm == DialogResult.Yes)
                        {
                            process.Kill();
                            Thread.Sleep(1000);

                            Process[] myProcess = Process.GetProcessesByName(process.ToString());
                            if (myProcess.Count() > 0)
                            {
                                AddLogs("Stopped the Process, ", ProcessesTextBox.Text, false);
                                MessageBox.Show(text + " was stopped unsuccessfully.");
                            }
                            else
                            {
                                AddLogs("Stopped the Process, ", ProcessesTextBox.Text);
                                MessageBox.Show(text + " was stopped successfully.");
                            }
                            LoadProcessesList();
                        }
                        else if (confirm == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
            }
            catch { MessageBox.Show("Access Denied."); }


        }

        private void LoadAutoComplete()
        {
            var sourceList = new AutoCompleteStringCollection();
            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                sourceList.Add(process.ProcessName);
            }
            ProcessesTextBox.AutoCompleteCustomSource = sourceList;
        }

        private void AddLogs(string command, string processName = null, bool success = true)
        {
            UobForm UobForm = (UobForm)this.Parent;
            var ListNumber = UobForm.userControlLogs.LogsDisplay.Items.Count + 1;
            DateTime now = DateTime.Now;

            ListViewItem items = new ListViewItem(ListNumber.ToString());
            if (ListNumber % 2 == 0)
            {
                items.BackColor = Color.LightGoldenrodYellow;
            }
            else
            {
                items.BackColor = Color.LightGray;
            }
            UobForm.userControlLogs.LogsDisplay.Items.Add(items);
            if (success == true)
            {
                ListViewSubItem listViewSubItem = new ListViewSubItem
                {
                    Text = command + processName + ", succesfully."
                };
                ListViewSubItem subitems1 = listViewSubItem;
                items.SubItems.Add(subitems1);
                ListViewSubItem subitems2 = new ListViewSubItem
                {
                    Text = now.ToString()
                };
                items.SubItems.Add(subitems2);
            }
            else
            {
                ListViewSubItem listViewSubItem = new ListViewSubItem
                {
                    Text = command + processName + ", unsuccesfully."
                };
                ListViewSubItem subitems1 = listViewSubItem;
                items.SubItems.Add(subitems1);
                ListViewSubItem subitems2 = new ListViewSubItem
                {
                    Text = now.ToString()
                };
                items.SubItems.Add(subitems2);
            }
        }
    }
}
