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
using Expense_Tracker.View;

namespace Expense_Tracker
{
    public partial class login : Form,IUser_view
    {
        user_presenter presenter;
        validation validate = new validation();
        public login()
        {
            InitializeComponent();
            presenter = new user_presenter(this);
        }

        public  string username
        {
            get
            {
                return txt_username.Text;
            }
            set
            {
                txt_username.Text = value;
            }
        }

        public string password
        {
            get
            {
                return txt_password.Text;
            }
            set
            {
                txt_password.Text = value;
            }
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dataValidate = new Dictionary<string, string>();
            dataValidate.Add("username", username);
            dataValidate.Add("password", password);

            string validate_msg=validate.isEmpty(dataValidate);
            if (validate_msg!=null)
            {
                message(validate_msg);
                return;
            }

            presenter.checkuservalitity(username, password);                     
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signup frm = new signup();
            frm.ShowDialog();
            this.Close();
        }

        public void message(string msg)
        {
            MessageBox.Show(msg);
        }

        public void success()
        {
            this.Hide();
            abstract_view frm = new transaction(username);
            frm.ShowDialog();
            this.Close();
        }

        
    }
}
