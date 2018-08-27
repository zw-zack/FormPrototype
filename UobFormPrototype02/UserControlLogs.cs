using System;
using System.Windows.Forms;

namespace UobFormPrototype02
{
    public partial class UserControlLogs : UserControl
    {
        public UserControlLogs()
        {
            InitializeComponent();
        }

        private void UserControlLogs_Load(object sender, EventArgs e)
        {
        }

        public void LoadLogsList()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader1.Text = "Index";
            columnHeader2.Text = "Logs";
            columnHeader3.Text = "Date/Time";
            LogsDisplay.Columns.Add(columnHeader1);
            LogsDisplay.Columns.Add(columnHeader2);
            LogsDisplay.Columns.Add(columnHeader3);

            columnHeader1.Width = 50;
            columnHeader2.Width = 280;
            columnHeader3.Width = 150;
            columnHeader1.TextAlign = HorizontalAlignment.Right;
        }

        private void LogsDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
