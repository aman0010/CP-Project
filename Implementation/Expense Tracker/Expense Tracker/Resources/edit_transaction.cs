using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Expense_Tracker.Presenter;

namespace Expense_Tracker.Resources
{
    public partial class edit_transaction : Expense_Tracker.View.abstract_transaction
    {
        transaction_presenter presenter = new transaction_presenter();

        public edit_transaction()
        {
            InitializeComponent();
        }

        private void Edit_transaction_Load(object sender, EventArgs e)
        {
            form("edit");
        }

        public override void Btn_action_Click(object sender, EventArgs e)
        {

        }
    }
}
