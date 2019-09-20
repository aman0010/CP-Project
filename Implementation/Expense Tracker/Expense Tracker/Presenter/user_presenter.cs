using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expense_Tracker.Model;
using Expense_Tracker.View;

namespace Expense_Tracker.Presenter
{
    class user_presenter
    {
        IUser_view user_view;
        User_model user = new User_model();

        public user_presenter(IUser_view view) {
            this.user_view = view;
        }

        public string checkuservalitity(string username, string password) {
            user.Username = username;
            user.Password = password;
            bool validity;
            validity= user.checkuservalitity();
            if (validity)
            {
                return("Login successful!");
            }
            return "Username and Password not matched!";
        }

        public string register(string username, string firstname, string lastname, string password) {            
            user.Username = username;
            user.Firstname = firstname;
            user.Lastname = lastname;
            user.Password = password;
            Exception ex=user.register();
            if (ex == null) {
                return "Registration successful!";
            }
            return ex.Message;
        }
    }
}
