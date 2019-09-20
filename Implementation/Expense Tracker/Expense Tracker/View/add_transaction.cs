using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Expense_Tracker.Presenter;

namespace Expense_Tracker.View
{
    public partial class add_transaction : Form
    {
        main_presenter presenter;
        string username = dashboard.username;
        public add_transaction()
        {
            InitializeComponent();
        }

        public int amount
        {
            get
            {
                return Convert.ToInt32(Math.Round(num_amount.Value));
            }
            set
            {
                num_amount.Value = value;
            }
        }

        public DateTime date
        {
            get
            {
                return dateTimePicker.Value;
            }
            set
            {
                dateTimePicker.Value = value;
            }
        }

        public string category
        {
            get
            {
                return combo_category.Text;
            }
            set
            {
                combo_category.Text = value;
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            presenter = new main_presenter();
            MessageBox.Show(presenter.insert_expense(amount, date, category, username));
        }
    }
}
