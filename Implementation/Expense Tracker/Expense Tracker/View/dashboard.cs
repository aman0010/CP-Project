using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Expense_Tracker.View
{
    public partial class dashboard : Expense_Tracker.View.abstract_view
    {
        public static string username;
        public dashboard(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            head("Dashboard");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            add_transaction frm = new add_transaction();
            frm.ShowDialog();
        }
    }
}
