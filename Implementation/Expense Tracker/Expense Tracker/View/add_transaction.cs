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
    public partial class add_transaction : abstract_transaction
    {
        string username = transaction.Username;

        public add_transaction()
        {
            InitializeComponent();
        }

        private void Add_transaction_Load(object sender, EventArgs e)
        {
            form("add");
        }

        public override void Btn_action_Click(object sender, EventArgs e)
        {
            string validate_msg;
            Dictionary<string, string> dataValidate = new Dictionary<string, string>();
            dataValidate.Add("Type", type);
            dataValidate.Add("Amount", amount.ToString());
            dataValidate.Add("Category", category);

            validate_msg = validate.isEmpty(dataValidate);
            if (validate_msg != null)
            {
                MessageBox.Show(validate_msg);
                return;
            }

            string msg = presenter.add(type, amount, date, category, description, username);
            MessageBox.Show(msg);
        }
    }
}
