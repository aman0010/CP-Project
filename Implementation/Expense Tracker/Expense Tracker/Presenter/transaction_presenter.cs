using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expense_Tracker.Model;
using System.Data;
using System.Data.SqlClient;

namespace Expense_Tracker.Presenter
{
    public class transaction_presenter
    {
        transaction_model model=new transaction_model();
        public string add(string type, int amount, DateTime date, string category, string description, string user)
        {
            model.Category_type = type;
            model.Amount = amount;
            model.Date = date;
            model.Category_name = category;
            model.Description = description;
            model.Username = user;

            string msg = model.insert();
            if (msg == null)
            {
                return "Value added successfully";
            }
            return msg;
        }

        public List<string> get_category(string type)
        {
            category_model model = new category_model();
            model.Type = type;
            DataTable dt= model.retrieve();

            List<string> categories = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                categories.Add(row[0].ToString());
            }

            return categories;
        }

        public DataTable get_transaction_byGroup(string type, string username, int month)
        {
            model.Category_type = type;
            model.Username = username;
            //model.Pk = pk;

            DataTable dt = model.retrieve_group(month);
            return dt;
            //return null;
        }

        public DataTable get_transaction_byMonth(string type, string username, int month)
        {
            model.Category_type = type;
            model.Username = username;

            DataTable dt=model.retrieve(month);
            return dt;
        }

        public string edit(Dictionary<string, string> data)
        {
            model.Category_type = data["category_type"];
            model.Amount = int.Parse(data["amount"]);
            model.Date = Convert.ToDateTime(data["date"]);
            model.Category_name = data["category_name"];
            model.Description = data["description"];
            model.Id = data["id"];

            string msg = model.update();
            if (msg == null)
            {
                return "Value updated successfully";
            }
            return msg;
        }
    }
}