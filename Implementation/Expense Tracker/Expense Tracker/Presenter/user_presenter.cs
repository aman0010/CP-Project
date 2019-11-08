using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expense_Tracker.Model;
using Expense_Tracker.View;
using System.Data;
using System.Data.SqlClient;

namespace Expense_Tracker.Presenter
{
    public class user_presenter
    {
        IUser_view view;
        User_model model = new User_model();

        public user_presenter(IUser_view view)
        {
            this.view = view;
        }

        public void checkuservalitity(string username, string password)
        {
            model.Username = username;
            model.Password = password;
            string msg;
            
            msg = model.checkuservalitity();
            if (msg==null)
            {
                view.message("Login Successful!");
                view.success();
            }            
            
            view.message(msg);
        }

        public void register(string username, string firstname, string lastname, string password)
        {
            model.Username = username;
            model.Firstname = firstname;
            model.Lastname = lastname;
            model.Password = password;

            string msg = model.register();
            if(msg==null)
            {
                view.message("Registration successful!!");
                view.success();
            }

            view.message(msg);
        }
    }
}
