using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Expense_Tracker.Model
{
    class User_model
    {
        string username;
        string firstname;
        string lastname;
        string password;
        string query;

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AOM3DBG;Initial Catalog=Expense_tracker;Integrated Security=True");


        public string Username { get => username; set => username = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Password { get => password; set => password = value; }

        public Exception register() {
            try
            {
                conn.Open();
                query = "INSERT INTO users VALUES ('" + username + "','" + firstname + "','" + lastname + "','" + password + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (MissingPrimaryKeyException ex)
            {
                return ex;
            }
            catch (SqlException ex)
            {
                return ex;
            }
            catch (Exception ex)
            {
                return ex;
            }
            finally
            {
                conn.Close();
            }
            return null;            
        }
        public bool checkuservalitity() {
            conn.Open();
            query = "SELECT * FROM users WHERE username='" + username + "' AND pwd='" + password + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            if (dt.Rows.Count > 0){
                return true;
            }

            return false;
        }
    }
}
