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
    public partial class edit_category : Expense_Tracker.View.abstract_category
    {
        Dictionary<string, string> data;
        category_presenter presenter = new category_presenter();
        public edit_category(Dictionary<string, string> data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void Edit_category_Load(object sender, EventArgs e)
        {
            form("edit");
            data_fill(data);
        }

        public override void btn_action_Click(object sender, EventArgs e)
        {
            data["description"] = category_description;
            data["category_name_updated"] = category_name;

            MessageBox.Show(presenter.edit(data));
        }
    }
}
