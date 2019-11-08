using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expense_Tracker.View;
using Expense_Tracker.Model;
using System.Data;
using System.Data.SqlClient;

namespace Expense_Tracker.Presenter
{
    class category_presenter
    {
        category_model model=new category_model();

        public DataTable reqest(string type)
        {
            model.Type = type;
            DataTable dt = model.retrieve();
            return (dt);
        }

        public string add(string type, string name, string descrition)
        {
            model.Type = type;
            model.Name = name;
            model.Description = descrition;

            string msg=model.insert();
            if(msg==null)
            {
                return "Value added successfully";
            }
            return msg;            
        }

        public string edit(Dictionary<string, string> data)
        {
            model.Type = data["category_type"];
            model.Name_updated = data["category_name_updated"];
            model.Name = data["category_name"];
            model.Description = data["description"];

            string msg = model.update();
            if (msg == null)
            {
                return "Value edited successfully";
            }
            return msg;
        }
    }
}
