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
    public partial class abstract_transaction : Form
    {
        public transaction_presenter presenter=new transaction_presenter();        
        public validation validate = new validation();
        public abstract_transaction()
        {
            InitializeComponent();
        }

        public string type
        {
            get
            {
                return combo_type.Text;
            }
            set
            {
                combo_type.Text = value;
            }
        }
        public int amount
        {
            get
            {
                return Convert.ToInt32(Math.Round(num_amount.Value));
            }
            set
            {
                num_amount.Value = value;
            }
        }

        public DateTime date
        {
            get
            {
                return dateTimePicker.Value;
            }
            set
            {
                dateTimePicker.Value = value;
            }
        }

        public string category
        {
            get
            {
                return combo_category.Text;
            }
            set
            {
                combo_category.Text = value;
            }
        }
        public string description
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

        public void form(string frm)
        {
            if (frm=="add")
            {
                label_heading.Text = "Add";
                btn_action.Text = "Add";
                btn_delete.Visible = false;
            }
            else
            {
                label_heading.Text = "Edit";
                btn_action.Text = "Edit";
                btn_delete.Visible = true;
                combo_type.Enabled = false;
                btn_addcategory.Visible = false;
            }
        }

        private void Btn_addcategory_Click(object sender, EventArgs e)
        {
            add_category frm = new add_category();
            frm.ShowDialog();
        }

        private void Combo_type_SelectionChangeCommitted(object sender, EventArgs e)
        {
            load_category();
        }

        public void load_category()
        {
            List<string> categories = presenter.get_category(combo_type.Text);
            combo_category.DataSource = categories;
        }

        public void data_fill(Dictionary<string, string> data)
        {
            type = data["category_type"];
            load_category();
            amount = int.Parse(data["amount"]);
            date = Convert.ToDateTime(data["date"]);
            this.category = data["category_name"];
            description = data["description"];
        }

        public virtual void Btn_action_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void Abstract_transaction_Load(object sender, EventArgs e)
        {

        }
    }
}
