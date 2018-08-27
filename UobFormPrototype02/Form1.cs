using System;
using System.Windows.Forms;

namespace UobFormPrototype02
{
    public partial class UobForm : Form
    {
        public UobForm()
        {
            InitializeComponent();
            HideAllControls();
        }

        public void UobForm_Load(object sender, EventArgs e)
        {
            HideAllControls();
            userControlLogs.LoadLogsList();
        }

        private void SystemInformation_Click(object sender, EventArgs e)
        {
            HideAllControls();
            userControlSystemInformation.Show();
            SystemInformationDescriptionDisplay();
        }

        private void Processes_Click(object sender, EventArgs e)
        {
            HideAllControls();
            userControlProcesses.Show();
            ProcessesDescriptionDisplay();
        }

        private void Services_Click(object sender, EventArgs e)
        {
            HideAllControls();
            userControlServices.Show();
            ServicesDescriptionDisplay();
        }

        private void Server_Click(object sender, EventArgs e)
        {
            HideAllControls();
            userControlServers.Show();
            ServerDescriptionDisplay();
        }

        private void Logs_Click(object sender, EventArgs e)
        {
            HideAllControls();
            userControlLogs.Show();
            LogsDescriptionDisplay();
        }

        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        { }
        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        { }
        private void MenuDescriptionTextBox_TextChanged(object sender, EventArgs e)
        { }
        private void UserControlSystemInformation_Load(object sender, EventArgs e)
        { }
        private void UserControlProcesses_Load(object sender, EventArgs e)
        { }
        private void UserControlServices_Load(object sender, EventArgs e)
        { }
        private void UserControlServers_Load(object sender, EventArgs e)
        { }
        private void UserControlLogs_Load(object sender, EventArgs e)
        { }
        /*********************************************************************************************************
         *********************************************************************************************************
         *********************************************************************************************************
         *********************************************************************************************************
         * LIST OF FUNCTIONS BELOW:
         *       1. HideAllControls-----> Hides all panels of user controls
         *       2. SystemInformationDescriptionDisplay
         *       3. ProcessesDescriptionDisplay
         *       4. ServicesDescriptionDisplay
         *       5. ServerDescriptionDisplay
         *       6. LogsDescriptionDisplay
         *********************************************************************************************************
         *********************************************************************************************************
         *********************************************************************************************************
         */
        private void HideAllControls()
        {
            userControlSystemInformation.Hide();
            userControlProcesses.Hide();
            userControlServices.Hide();
            userControlServers.Hide();
            userControlLogs.Hide();
        }

        private void SystemInformationDescriptionDisplay()
        {
            MenuDescriptionTextBox.Text = "Information of current system";
        }

        private void ProcessesDescriptionDisplay()
        {
            MenuDescriptionTextBox.Text =
                "List of all running processes with stop controls";
        }

        private void ServicesDescriptionDisplay()
        {
            MenuDescriptionTextBox.Text =
                "List of all services with start/stop controls";
        }

        private void ServerDescriptionDisplay()
        {
            MenuDescriptionTextBox.Text = "Server shutdown, reboot or sleep.";
        }

        private void LogsDescriptionDisplay()
        {
            MenuDescriptionTextBox.Text = "Chronologically displays usage history";
        }
    }
}
