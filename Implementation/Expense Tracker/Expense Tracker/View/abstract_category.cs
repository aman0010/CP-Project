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
    public partial class abstract_category : Form
    {
        category_presenter presenter = new category_presenter();
        
        public abstract_category()
        {
            InitializeComponent();
        }

        public string category_name
        {
            get
            {
                return txt_name.Text;
            }
            set
            {
                txt_name.Text = value;
            }
        }

        public string category_description
        {
            get
            {
                return txt_description.Text;
            }
            set
            {
                txt_description.Text = value;
            }
        }

        public string category_type
        {
            get
            {
                if (radio_expense.Checked) return "Expense";
                else return "Income";
            }

            set
            {
                if (value.ToLower() == "expense") radio_expense.Checked = true;
                else radio_income.Checked = true;
                
            }
        }

        public void form(string frm)
        {
            if (frm == "add")
            {
                label_title.Text = "Add Category";
                btn_action.Text = "Add";
            }
            else
            {
                label_title.Text = "Edit Category";
                btn_action.Text = "Edit";
                radio_expense.Enabled = false;
                radio_income.Enabled = false;
            }
        }

        public void data_fill(Dictionary<string, string> data)
        {
            category_name = data["category_name"];
            category_type = data["category_type"];
            category_description = data["description"];
        }

        private void Abstract_category_Load(object sender, EventArgs e)
        {

        }
        

        public virtual void btn_action_Click(object sender, EventArgs e)
        {

        }
    }
}
