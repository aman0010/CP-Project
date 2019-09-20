using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expense_Tracker.View;
using Expense_Tracker.Model;
using System.Data;

namespace Expense_Tracker.Presenter
{
    class main_presenter
    {
        abstract_view view;
        main_model model;
            


        public DataTable request_expense()
        {
            model = new main_model();
            DataTable dt= model.request_data("expense");
            return (dt);
        }

        public string insert_expense(int amount, DateTime date, string category_name, string username)
        {
            model = new main_model();
            model.Amount = amount;
            model.Date = date;
            model.Category_name = category_name;
            model.Username = username;

            Exception ex= model.insert_transaction();
            return ex.Message;
        }

    }
}
