using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Expense_Tracker.Model
{
    class category_model
    {
        string type;
        string name_updated;
        string name;
        string description;
        string query;

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AOM3DBG;Initial Catalog=Expense_tracker;Integrated Security=True");

        public string Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Name_updated { get => name_updated; set => name_updated = value; }

        public string insert()
        {
            try
            { 
                conn.Open();
                query = "INSERT INTO category VALUES ('" + name + "','" + type + "','" + description + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (MissingPrimaryKeyException ex)
            {
                return ex.Message;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    return "This value is already added";
                }
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

        public DataTable retrieve ()
        {
            conn.Open();
            query = "SELECT category_name, category_description FROM category WHERE category_type = '" + type + "'";

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
                query = "UPDATE category " +
                    "SET category_name ='" + name_updated + "', category_description ='" + description + "'" +
                    "WHERE category_name = '" + name + "' AND category_type = '" + type + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (MissingPrimaryKeyException ex)
            {
                return ex.Message;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    return "This value is already exist";
                }
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
