using System;
using System.Drawing;
using System.Windows.Forms;
using System.ServiceProcess;
using static System.Windows.Forms.ListViewItem;

namespace UobFormPrototype02
{
    public partial class UserControlServices : UserControl
    {
        public UserControlServices()
        {
            InitializeComponent();
        }

        private void UserControlServices_Load(object sender, EventArgs e)
        {
            LoadServicesList();
            LoadAutoComplete();
            UobForm UobForm = (UobForm)Parent;
            if (UobForm.userControlServices.Visible == true)
            {
                AddLogs("Accessed Services");
            }

        }

        private void ServiceStart_Click(object sender, EventArgs e)
        {
            StartServicesAction();
        }

        private void ServiceStop_Click(object sender, EventArgs e)
        {
            StopServicesAction();
        }

        private void ServicesRefresh_Click(object sender, EventArgs e)
        {
            LoadServicesList();
            LoadAutoComplete();
            AddLogs("Refreshed Services");
        }

        private void ServicesDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ServicesTextBox.Text = ServicesDisplay.SelectedItems[0].SubItems[1].Text;
            }
            catch { }
        }

        private void ServicesTextBox_TextChanged(object sender, EventArgs e)
        { }

        /*********************************************************************************************************
         *********************************************************************************************************
         *********************************************************************************************************
         *********************************************************************************************************
         * LIST OF FUNCTIONS BELOW:
         *       1. LoadServicesList -------> Load all services in list view
         *       2. StopServicesAction -----> Stop selected service
         *       3. StartServicesAction ----> Start selected service
         *       4. LoadAutoComplete -------> Loads dropdown services in textbox
         *       5. AddLogs ----------------> Logs operator activity
         *********************************************************************************************************
         *********************************************************************************************************
         *********************************************************************************************************
         */
        private void LoadServicesList()
        {
            ServicesDisplay.Clear();
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader1.Text = "Index";
            columnHeader2.Text = "Service Name";
            columnHeader3.Text = "Status";
            ServicesDisplay.Columns.Add(columnHeader1);
            ServicesDisplay.Columns.Add(columnHeader2);
            ServicesDisplay.Columns.Add(columnHeader3);

            columnHeader1.Width = 50;
            columnHeader2.Width = 180;
            columnHeader3.Width = 100;
            columnHeader1.TextAlign = HorizontalAlignment.Right;

            var scServices = ServiceController.GetServices();
            var i = 1;
            foreach (var scTemp in scServices)
            {
                ListViewItem items = new ListViewItem(i.ToString());
                ServicesDisplay.Items.Add(items);
                if (i % 2 == 0)
                {
                    items.BackColor = Color.LightGoldenrodYellow;
                }
                else
                {
                    items.BackColor = Color.LightGray;
                }
                i++;
                var sc = new ServiceController(scTemp.ServiceName);
                ListViewSubItem listViewSubItem = new ListViewSubItem
                {
                    Text = scTemp.ServiceName
                };
                ListViewSubItem subitems1 = listViewSubItem;
                items.SubItems.Add(subitems1);

                ListViewSubItem subitems2 = new ListViewSubItem
                {
                    Text = scTemp.Status.ToString()
                };
                items.SubItems.Add(subitems2);
            }
        }

        private void StopServicesAction()
        {
            try
            {
                string text = ServicesTextBox.Text;
                DialogResult confirm = MessageBox.Show(
                    "This will stop " + text + ", proceed?",
                    "Stop Service",
                    MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    var service = new ServiceController(text);
                    if (service.Status.ToString() == "Stopped")
                    {
                        DialogResult change = MessageBox.Show(
                            text + " is already stopped. Start " + text + " instead?",
                            "Service is stopped",
                            MessageBoxButtons.YesNo);
                        if (change == DialogResult.Yes)
                        {
                            StartServicesAction();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        service.Stop();
                        service.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10.0));
                        if (service.Status.ToString() == "Stopped")
                        {
                            AddLogs("Stopped the Service, ", ServicesTextBox.Text);
                            MessageBox.Show(text + " was stopped successfully.");
                        }
                        else
                        {
                            AddLogs("Stopped Service, ", ServicesTextBox.Text, false);
                            MessageBox.Show(text + " was stopped unsuccessfully.");
                        }
                        LoadServicesList();
                        LoadAutoComplete();
                    }
                }
                else if (confirm == DialogResult.No)
                {
                    return;
                }
            }
            catch { MessageBox.Show("Access Denied."); }
        }

        private void StartServicesAction()
        {
            try
            {
                string text = ServicesTextBox.Text;
                DialogResult confirm = MessageBox.Show(
                    "This will start " + text + ", proceed?",
                    "Start Service",
                    MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    var service = new ServiceController(text);
                    if (service.Status.ToString() == "Running")
                    {
                        DialogResult change = MessageBox.Show(
                            text + " is already running. Stop " + text + " instead?",
                            "Service is running",
                             MessageBoxButtons.YesNo);
                        if (change == DialogResult.Yes)
                        {
                            StopServicesAction();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        service.Start();
                        service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10.0));
                        if (service.Status.ToString() == "Running")
                        {
                            AddLogs("Started Service ", ServicesTextBox.Text);
                            MessageBox.Show(text + " was started successfully.");
                        }
                        else
                        {
                            AddLogs("Started Service ", ServicesTextBox.Text, false);
                            MessageBox.Show(text + " was started unsuccessfully.");
                        }
                        LoadServicesList();
                        LoadAutoComplete();
                    }
                }
                else if (confirm == DialogResult.No)
                {
                    return;
                }
            }
            catch { MessageBox.Show("Access Denied."); }
        }

        private void LoadAutoComplete()
        {
            var sourceList = new AutoCompleteStringCollection();
            var scServices = ServiceController.GetServices();
            foreach (var scTemp in scServices)
            {
                sourceList.Add(scTemp.ServiceName);
            }
            ServicesTextBox.AutoCompleteCustomSource = sourceList;
        }

        private void AddLogs(string command, string serviceName = null, bool success = true)
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
                    Text = command + serviceName + ", succesfully."
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
                    Text = command + serviceName + ", unsuccesfully."
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
