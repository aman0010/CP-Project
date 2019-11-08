using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Expense_Tracker.Presenter;

namespace Expense_Tracker.View
{
    public partial class report : Expense_Tracker.View.abstract_view
    {
        transaction_presenter presenter = new transaction_presenter();
        public report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            title("Report");
            data_load();
        }

        public override void data_load()
        {
            dataGridView_expense.DataSource = presenter.get_transaction_byGroup("expense", Username, Month);
            dataGridView_income.DataSource = presenter.get_transaction_byGroup("income", Username, Month);
        }
    }
}
