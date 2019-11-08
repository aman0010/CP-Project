using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Expense_Tracker.Model
{
    class transaction_model
    {
        string id;
        int amount;
        DateTime date;
        string description;
        string category_name;
        string category_type;
        string username;
        string query;

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AOM3DBG;Initial Catalog=Expense_tracker;Integrated Security=True");
        
        public int Amount { get => amount; set => amount = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Description { get => description; set => description = value; }
        public string Category_name { get => category_name; set => category_name = value; }
        public string Category_type { get => category_type; set => category_type = value; }
        public string Username { get => username; set => username = value; }
        public string Id { get => id; set => id = value; }

        public string insert()
        {
            try { 
                conn.Open();
                query = "INSERT INTO transact VALUES ('" + amount + "','" + date + "','" + description + "','" + category_name + "','" + category_type + "','" + username + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (MissingPrimaryKeyException ex)
            {
                return ex.Message;
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                conn.Close();
            }
            
            return null;
        }

        public DataTable retrieve(int month)
        {
            conn.Open();
            query = "SELECT * INTO #temp FROM transact WHERE username = '" + username + "' AND category_type = '" + category_type + "'";

            if (month != 0) query += "AND MONTH(date) = " + month;

            query += "ALTER TABLE #temp DROP COLUMN category_type, username " +
                     "SELECT* FROM #temp";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            conn.Close();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable retrieve_group(int month)
        {
            string query_month = "";
            conn.Open();
            if (month != 0) query_month = "AND MONTH(date) = " + month;

            query = "SELECT SUM(amount) AS amount, category_name FROM transact " +
                    "WHERE username = '" + username + "' AND category_type = '" + category_type + "'" + query_month +
                    "GROUP BY category_name";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            conn.Close();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string update()
        {
            try
            {
                conn.Open();
                query = "UPDATE transact " +
                    "SET amount = '" + amount + "', date = '" + date + "', description = '" + description + "'," +
                    " category_name = '" + category_name + "'" +
                    "WHERE transaction_id = " + id;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (MissingPrimaryKeyException ex)
            {
                return ex.Message;
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return null;
        }
    }
}
