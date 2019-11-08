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
    public partial class category : Expense_Tracker.View.abstract_view
    {
        category_presenter presenter = new category_presenter();
        public category()
        {
            InitializeComponent();
        }
        private void Category_Load(object sender, EventArgs e)
        {
            title("Category");
            month_display(false);
            data_load();
        }

        public override void data_load()
        {
            dataGridView_expense.DataSource = presenter.reqest("expense");
            dataGridView_income.DataSource = presenter.reqest("income");
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            abstract_category frm = new add_category();
            frm.ShowDialog();
        }

        private void Btn_editExpense_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>
            {
                {"category_name", dataGridView_expense.CurrentRow.Cells[0].Value.ToString()},
                {"category_name_updated", dataGridView_expense.CurrentRow.Cells[0].Value.ToString()},
                {"category_type", "Expense"},
                {"description", dataGridView_expense.CurrentRow.Cells[1].Value.ToString()},
            };

            abstract_category frm = new edit_category(data);
            frm.ShowDialog();
        }

        private void Btn_editIncome_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>
            {
                {"category_name", dataGridView_expense.CurrentRow.Cells[0].Value.ToString()},
                {"category_name_updated", dataGridView_expense.CurrentRow.Cells[0].Value.ToString()},
                {"category_type", "Income"},
                {"description", dataGridView_expense.CurrentRow.Cells[1].Value.ToString()},
            };

            abstract_category frm = new edit_category(data);
            frm.ShowDialog();
        }

        
    }
}
