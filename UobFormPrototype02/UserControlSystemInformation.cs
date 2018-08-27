using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using static System.Windows.Forms.ListViewItem;

namespace UobFormPrototype02
{
    public partial class UserControlSystemInformation : UserControl
    {
        public UserControlSystemInformation()
        {
            InitializeComponent();
        }

        private void SystemInformationLabel_Click(object sender, EventArgs e)
        {
        }

        private void UserControlSystemInformation_Load(object sender, EventArgs e)
        {
            LoadSystemInformation();
            AddLogs("Accessed System Information");
        }
        private void SystemInformationDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        /*********************************************************************************************************
         *********************************************************************************************************
         *********************************************************************************************************
         *********************************************************************************************************
         * LIST OF FUNCTIONS BELOW:
         *       1. GetComponent ----------> Functions that draws info from system
         *       2. LoadSystemInformation--> List population with specific commands
         *       3. Addlogs      ----------> Include logs
         *********************************************************************************************************
         *********************************************************************************************************
         *********************************************************************************************************
         */

        private void GetComponent(string hwclass, string syntax, int index)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher(
                "root\\CIMV2",
                "SELECT * FROM " +
                hwclass);

            foreach (ManagementObject mj in mos.Get())
            {
                ListViewItem items = new ListViewItem(index.ToString());
                SystemInformationDisplay.Items.Add(items);
                ListViewSubItem subitems1 = new ListViewSubItem
                {
                    Text = hwclass + " " + syntax
                };
                items.SubItems.Add(subitems1);

                ListViewSubItem subitems2 = new ListViewSubItem
                {
                    Text = Convert.ToString(mj[syntax])
                };
                items.SubItems.Add(subitems2);
            }
        }

        private void LoadSystemInformation()
        {
            SystemInformationDisplay.Clear();
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader1.Text = "Index";
            columnHeader2.Text = "Title";
            columnHeader3.Text = "Information";
            SystemInformationDisplay.Columns.Add(columnHeader1);
            SystemInformationDisplay.Columns.Add(columnHeader2);
            SystemInformationDisplay.Columns.Add(columnHeader3);

            columnHeader1.Width = 40;
            columnHeader2.Width = 250;
            columnHeader3.Width = 380;
            columnHeader1.TextAlign = HorizontalAlignment.Right;

            GetComponent("Win32_ComputerSystem", "Name", 1);
            GetComponent("Win32_ComputerSystem", "Model", 2);

            GetComponent("Win32_ComputerSystem", "UserName", 3);
            GetComponent("Win32_ComputerSystem", "SystemType", 4);
            GetComponent("Win32_ComputerSystem", "Domain", 5);

            GetComponent("Win32_Processor", "Name", 6);
            GetComponent("Win32_Processor", "ProcessorID", 7);
            GetComponent("Win32_VideoController", "Name", 8);
            //GetComponent("Win32_BaseBoard", "Product", 3);
            GetComponent("Win32_OperatingSystem", "Name", 9);
            GetComponent("Win32_OperatingSystem", "SerialNumber", 10);
            GetComponent("Win32_OperatingSystem", "Version", 11);
            GetComponent("Win32_OperatingSystem", "FreePhysicalMemory", 12);
            GetComponent("Win32_OperatingSystem", "FreeSpaceInPagingFiles", 13);
            GetComponent("Win32_OperatingSystem", "TotalVirtualMemorySize", 14);
            GetComponent("Win32_OperatingSystem", "TotalVisibleMemorySize", 15);
            //GetComponent("Win32_CacheMemory", "SystemName", 3);
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
                    Text = command + ", succesfully."
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
