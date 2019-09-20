using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracker.View
{
    public partial class abstract_view : Form
    {
        abstract_view frm;       
        public abstract_view()
        {
            InitializeComponent();
        }

        private void Abstract_view_Load(object sender, EventArgs e)
        {
            
        }

        public void head(string h)
        {
            label_heading.Text = h;
        }

        private void load_form(string a)
        {
            //frm = new a;
        }

        private void Btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm = new dashboard(dashboard.username);
            frm.ShowDialog();
            this.Close();
        }

        private void Btn_expense_Click(object sender, EventArgs e)
        {
            this.Hide();
            expense frm = new expense();
            frm.ShowDialog();
            this.Close();
        }

        private void Btn_income_Click(object sender, EventArgs e)
        {
            this.Hide();
            income frm = new income();
            frm.ShowDialog();
            this.Close();
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login frm = new login();
            frm.ShowDialog();
            this.Close();
        }
    }
}
