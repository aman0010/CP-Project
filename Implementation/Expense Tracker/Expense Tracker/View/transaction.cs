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
    public partial class transaction : Expense_Tracker.View.abstract_view
    {
        transaction_presenter presenter = new transaction_presenter();

        //public string Month { get => combo_month.SelectedItem.ToString(); }

        public transaction(string user)
        {
            InitializeComponent();
            Username = user;
        }       

        private void Dashboard_Load(object sender, EventArgs e)
        {
            title("Transaction");            
            data_load();
            
        }

        override public void data_load()
        {
            DataTable expense_table = presenter.get_transaction_byMonth("expense", Username, Month);
            DataTable income_table = presenter.get_transaction_byMonth("income", Username, Month);
            dataGridView_expense.DataSource = expense_table;
            dataGridView_income.DataSource = income_table;

            int expense=data_calc(expense_table);
            int income=data_calc(income_table);

            int data_calc(DataTable table)
            {
                int a=0;
                foreach (DataRow dr in table.Rows)
                {
                    a += int.Parse(dr["amount"].ToString());
                }
                return a;
            }

            textBox_expense.Text = expense.ToString();
            textBox_income.Text = income.ToString();
            textBox_balance.Text = (income - expense).ToString();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            abstract_transaction frm = new add_transaction();
            frm.ShowDialog();
        }

        private void Btn_editExpense_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>
            {
                {"id", dataGridView_expense.CurrentRow.Cells[0].Value.ToString()},
                {"amount", dataGridView_expense.CurrentRow.Cells[1].Value.ToString()},
                {"date", dataGridView_expense.CurrentRow.Cells[2].Value.ToString()},
                {"description", dataGridView_expense.CurrentRow.Cells[3].Value.ToString()},
                {"category_name", dataGridView_expense.CurrentRow.Cells[4].Value.ToString()},
                {"category_type", "Expense"}
            };

            abstract_transaction frm = new edit_transaction(data);
            frm.ShowDialog();
        }

        private void Btn_editIncome_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>
            {
                {"id", dataGridView_income.CurrentRow.Cells[0].Value.ToString()},
                {"amount", dataGridView_income.CurrentRow.Cells[1].Value.ToString()},
                {"date", dataGridView_income.CurrentRow.Cells[2].Value.ToString()},
                {"description", dataGridView_income.CurrentRow.Cells[3].Value.ToString()},
                {"category_name", dataGridView_income.CurrentRow.Cells[4].Value.ToString()},
                {"category_type", "Income"}
            };

            abstract_transaction frm = new edit_transaction(data);
            frm.ShowDialog();
        }
    }
}
