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
        validation validate=new validation();
        user_presenter presenter;


        public signup()
        {
            InitializeComponent();
            presenter = new user_presenter(this);
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
            Dictionary<string, string> dataValidate = new Dictionary<string, string>();
            dataValidate.Add("username", username);
            dataValidate.Add("Firstname", firstname);
            dataValidate.Add("Lastname", lastname);
            dataValidate.Add("password", password);
            dataValidate.Add("re-password", re_password);

            string validate_msg;
            validate_msg = validate.isEmpty(dataValidate);
            if (validate_msg != null)
            {
                message(validate_msg);
                return;
            }

            validate_msg = validate.match(password, re_password);
            if (validate_msg != null)
            {
                message(validate_msg);
                return;
            }

            presenter.register(username, firstname, lastname, password);
        }

        private void Btn_signup_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            login frm = new login();
            frm.ShowDialog();
            this.Close();
        }

        public void message(string msg)
        {
            MessageBox.Show(msg);
        }

        public void success()
        {
            btn_signup_back.PerformClick();
        }
    }
}
