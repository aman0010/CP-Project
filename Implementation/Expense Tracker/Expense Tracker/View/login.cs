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

        private void Btn_login_Click(object sender, EventArgs e)
        {
            string result;
            username = txt_username.Text;
            string password = txt_password.Text;
            result=presenter.checkuservalitity(username, password);
            MessageBox.Show(result);
            
            if (result == "Login successful!") {
                this.Hide();
                abstract_view frm = new dashboard(username);
                frm.ShowDialog();
                this.Close();
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signup frm = new signup();
            frm.ShowDialog();
            this.Close();
        }
    }
}
