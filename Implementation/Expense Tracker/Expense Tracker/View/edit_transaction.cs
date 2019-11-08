using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Expense_Tracker.View
{
    public partial class edit_transaction : Expense_Tracker.View.abstract_transaction
    {
        Dictionary<string, string> data;
        public edit_transaction(Dictionary<string, string> data)
        {
            InitializeComponent();
            this.data = data;

        }

        private void Edit_transaction_Load(object sender, EventArgs e)
        {
            form("edit");
            data_fill(data);
        }

        public override void Btn_action_Click(object sender, EventArgs e)
        {
            data["amount"] = amount.ToString();
            data["date"] = date.ToString();
            data["description"] = description;
            data["category_name"] = category;

            MessageBox.Show(presenter.edit(data));
        }

    }
}
