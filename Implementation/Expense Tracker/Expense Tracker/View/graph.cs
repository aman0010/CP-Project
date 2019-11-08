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
    public partial class graph : Expense_Tracker.View.abstract_view
    {
        transaction_presenter presenter = new transaction_presenter();

        public graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            title("Graph");
            data_load();
        }

        private void plot_table(DataTable dt, string tableName)
        {

            string category;
            int amount;
            foreach (DataRow dr in dt.Rows)
            {
                category = dr["category_name"].ToString();
                amount = int.Parse(dr["amount"].ToString());

                chart.Series[tableName].Points.AddXY(category, amount);
            }
        }

        public override void data_load()
        {
            chart.Series["expense"].Points.Clear();
            chart.Series["income"].Points.Clear();
            DataTable dt_expense = presenter.get_transaction_byGroup("expense", Username, Month);
            DataTable dt_income = presenter.get_transaction_byGroup("income", Username, Month);

            plot_table(dt_expense, "expense");
            plot_table(dt_income, "income");
        }
    }
}
