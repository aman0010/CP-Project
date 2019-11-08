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

        static string username;
        public static string Username { get => username; set => username = value; }
        public Dictionary<string, int> months = new Dictionary<string, int>()
        {
            {"All", 0 },
            {"Jan.", 1 },
            {"Feb.", 2 },
            {"Mar.", 3 },
            {"Apr.", 4 },
            {"May", 5 },
            {"June", 6 },
            {"July", 7 },
            {"Aug.", 8 },
            {"Sept.", 9 },
            {"Oct.", 10 },
            {"Nov.", 11 },
            {"Dec.", 12 }
        };
        public int Month { get => months[combo_month.SelectedItem.ToString()]; }

        public abstract_view()
        {
            InitializeComponent();
        }

        private void Abstract_view_Load(object sender, EventArgs e)
        {
            foreach (string mon in months.Keys)
            {
                combo_month.Items.Add(mon);
            }
            combo_month.SelectedIndex = 0;
        }
        private void load_form(abstract_view view)
        {
            this.Hide();
            frm = view;
            frm.ShowDialog();
            this.Close();
        }

        public void title(string heading)
        {
            label_title.Text = heading;
        }

        public void month_display(bool a)
        {
            combo_month.Visible = a;
        }

        private void Btn_transaction_Click(object sender, EventArgs e)
        {            
            load_form(new transaction(transaction.Username));
        }
        private void Btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login frm = new login();
            frm.ShowDialog();
            this.Close();
        }

        private void Btn_hide_Click(object sender, EventArgs e)
        {
            btn_transaction.Visible = false;
            btn_category.Visible = false;
            btn_graph.Visible = false;
            btn_report.Visible = false;
            btn_hide.Visible = false;

            btn_show.Visible = true;            
        }

        private void Btn_show_Click(object sender, EventArgs e)
        {
            btn_transaction.Visible = true;
            btn_category.Visible = true;
            btn_graph.Visible = true;
            btn_report.Visible = true;
            btn_hide.Visible = true;

            btn_show.Visible = false;
        }

        public void Btn_refresh_Click(object sender, EventArgs e)
        {
            data_load();
        }

        virtual public void data_load()
        {

        }

        private void Combo_month_SelectionChangeCommitted(object sender, EventArgs e)
        {
            data_load();
        }

        private void Btn_category_Click(object sender, EventArgs e)
        {
            load_form(new category());
        }

        private void Btn_graph_Click(object sender, EventArgs e)
        {
            load_form(new graph());
        }

        private void Btn_report_Click(object sender, EventArgs e)
        {
            load_form(new report());
        }
    }
}
