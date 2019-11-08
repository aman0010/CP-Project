using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Tracker
{
    public class validation
    {
        public string isEmpty(Dictionary<string, string> kvdata)
        {
            foreach(string key in kvdata.Keys)
            {
                if(kvdata[key]=="")
                {
                    return "Please enter " + key;
                }
            }
            return null;
        }
        
        public string match(string password, string re_password)
        {
            if(password==re_password)
            {
                return null;
            }
            return "Password and re-password does not match";
        }
    }
}
