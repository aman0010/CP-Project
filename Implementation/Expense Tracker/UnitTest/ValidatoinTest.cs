using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expense_Tracker;
using Xunit;

namespace UnitTest
{
    public class ValidatoinTest
    {
        Dictionary<string, string> dataValidate = new Dictionary<string, string>();

        [Theory]
        [InlineData("", "")]
        [InlineData("username", "")]
        [InlineData("username", "admin")]
        public void isEmpty_returnNull(string first, string last)
        {
            validation validate = new validation();
            dataValidate.Add(first, last);
            string msg = validate.isEmpty(dataValidate);

            Assert.Null(msg);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("username", "")]
        [InlineData("username", "admin")]
        public void isEmpty_returnMsg(string first, string last)
        {
            validation validate = new validation();
            dataValidate.Add(first, last);
            string msg = validate.isEmpty(dataValidate);

            Assert.Equal("Please enter " + first, msg);
        }

    }
}
