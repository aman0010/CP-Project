using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Expense_Tracker.Model
{
    class main_model
    {
        int amount;
        DateTime date;
        string description;
        string category_name;
        string username;
        string query;

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AOM3DBG;Initial Catalog=Expense_tracker;Integrated Security=True");

        public int Amount { get => amount; set => amount = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Description { get => description; set => description = value; }
        public string Category_name { get => category_name; set => category_name = value; }
        public string Username { get => username; set => username = value; }

        public DataTable request_data(string type)
        {
            conn.Open();
            query = "SELECT * FROM transaction";            

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            conn.Close();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public Exception insert_category(string name, string type)
        {
            try
            {
                conn.Open();
                query = "INSERT INTO category VALUES ('" + name + "','" + type + "')";
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

        public Exception insert_transaction()
        {
            try
            {
                conn.Open();
                query = "INSERT INTO trannsaction VALUES ('" + amount + "','" + date + "','" + description + "','" + category_name + "','" + username + "')";
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
    }
}
