using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using static System.Windows.Forms.ListViewItem;

namespace UobFormPrototype02
{
    public partial class UserControlServers : UserControl
    {
        public UserControlServers()
        {
            InitializeComponent();
        }

        [DllImport("user32")]
        public static extern void LockWorkStation();

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            ShutDownAction();
        }

        private void RebootButton_Click(object sender, EventArgs e)
        {
            RebootAction();
        }

        private void SleepButton_Click(object sender, EventArgs e)
        {
            SleepAction();
        }

        private void UserControlServers_Load(object sender, EventArgs e)
        {
            AddLogs("Accessed Servers");
        }

        /*********************************************************************************************************
         *********************************************************************************************************
         *********************************************************************************************************
         *********************************************************************************************************
         * LIST OF FUNCTIONS BELOW:
         *       1. ShutDownAction
         *       2. RebootAction
         *       3. SleepAction
         *       4. AddLogs
         *********************************************************************************************************
         *********************************************************************************************************
         *********************************************************************************************************
         */

        private void ShutDownAction()
        {
            DialogResult confirm = MessageBox.Show(
                   "This will shutdown the server, proceed?",
                   "WARNING",
                   MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                AddLogs("ShutDown Initiated");
                Process.Start("shutdown", "/s /t 0");
            }
            else
            {
                AddLogs("ShutDown Initiated", false);
                return;
            }
        }

        private void RebootAction()
        {
            DialogResult confirm = MessageBox.Show(
                    "This will restart the server, proceed?",
                    "WARNING",
                    MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                AddLogs("Reboot Initiated");
                Process.Start("shutdown", "/r /t 0");
            }
            else
            {
                AddLogs("Reboot Initiated", false);
                return;
            }
        }

        private void SleepAction()
        {
            DialogResult confirm = MessageBox.Show(
                    "This will log off the server, proceed?",
                    "WARNING",
                    MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                AddLogs("Sleep Initiated");
                LockWorkStation();
            }
            else
            {
                AddLogs("Sleep Initiated", false);

                return;
            }
        }

        private void AddLogs(string command, bool success = true)
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
                    Text = command + ", successfully."
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
                    Text = command + ", unsuccesfully."
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

