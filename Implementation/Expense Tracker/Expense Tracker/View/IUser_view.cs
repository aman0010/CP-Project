using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Tracker.View
{
    public interface IUser_view
    {
        string username { get; set; }
        string password { get; set; }

        void message(string msg);
        void success();
    }
}
