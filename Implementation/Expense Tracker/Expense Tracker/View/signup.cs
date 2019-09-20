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
    public partial class signup : Form,IUser_view
    {
        public signup()
        {
            InitializeComponent();
        }
        public string username
        {
            get
            {
                return txt_signup_username.Text;
            }
            set
            {
                txt_signup_username.Text = value;
            }
        }
        public string firstname
        {
            get
            {
                return txt_signup_fname.Text;
            }
            set
            {
                txt_signup_fname.Text = value;
            }
        }
        public string lastname
        {
            get
            {
                return txt_signup_lname.Text;
            }
            set
            {
                txt_signup_lname.Text = value;
            }
        }
        public string password
        {
            get
            {
                return txt_signup_password.Text;
            }
            set
            {
                txt_signup_password.Text = value;
            }
        }
        public string re_password
        {
            get
            {
                return txt_signup_repassword.Text;
            }
            set
            {
                txt_signup_repassword.Text = value;
            }
        }

        private void Btn_signup_signup_Click(object sender, EventArgs e)
        {
            user_presenter presenter = new user_presenter(this);
            string msg = presenter.register(username, firstname, lastname, password);
            MessageBox.Show(msg);
            if (msg == "Registration successful!")
            {
                btn_signup_back.PerformClick();
            }
        }

        private void Btn_signup_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            login frm = new login();
            frm.ShowDialog();
            this.Close();
        }
    }
}
