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
    public partial class add_category : Expense_Tracker.View.abstract_category
    {

        category_presenter presenter = new category_presenter();
        validation validate = new validation();

        public add_category()
        {
            InitializeComponent();
        }

        private void Add_category_Load(object sender, EventArgs e)
        {
            form("add");
        }

        public override void btn_action_Click(object sender, EventArgs e)
        {
            string validate_msg;
            Dictionary<string, string> dataValidate = new Dictionary<string, string>();
            dataValidate.Add("Name", category_name);
            dataValidate.Add("Type", category_type);


            validate_msg = validate.isEmpty(dataValidate);
            if (validate_msg != null)
            {
                MessageBox.Show(validate_msg);
                return;
            }

            MessageBox.Show(presenter.add(category_type, category_name, category_description));
        }
    }
}
