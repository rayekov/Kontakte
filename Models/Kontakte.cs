using Kontakte.Db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontakte.Models
{
    public class Kontakte:DbConnection
    {   // fields
        public int contactID { get; set; }
        public string firstName { get; set; } 
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string email { get; set; }

        //Method for selecting data from database
        public DataTable Select()
        {   //connecting to database
            SqlConnection conn = GetConnection();
            DataTable dt = new DataTable();
            try
            {   //query
                string sql = "SELECT * FROM Table_Contact";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;  
        }

        //method to insert data in database
        public bool Insert(Kontakte k)
        {
            bool isSuccess= false;
            SqlConnection conn = GetConnection();
            try
            {
                string sql = "INSERT INTO Table_Contact * FROM Table_Contact(firstName, lastName, phoneNumber, address, email) VALUES (@firstName, @lastName, @phoneNumber, @address, @email) ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@firstName", k.firstName);
                cmd.Parameters.AddWithValue("@lastName", k.lastName);
                cmd.Parameters.AddWithValue("@phoneNumber", k.phoneNumber);
                cmd.Parameters.AddWithValue("@address", k.address);
                cmd.Parameters.AddWithValue("@email", k.email);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows>0)
                {
                    isSuccess=true;
                } 

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

       
        public bool Update(Kontakte k)
        {
            bool isSuccess= false;
            SqlConnection conn = GetConnection();
            try
            {
                string sql = "UPDATE Table_Contact SET firstName=@firstName, lastName=@lastName, phoneNumber=@phoneNumber, address=@address, email=@email WHERE contactID=@contactID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@firstName", k.firstName);
                cmd.Parameters.AddWithValue("@lastName", k.lastName);
                cmd.Parameters.AddWithValue("@phoneNumber", k.phoneNumber);
                cmd.Parameters.AddWithValue("@address", k.address);
                cmd.Parameters.AddWithValue("@email", k.email);
                cmd.Parameters.AddWithValue("@contactID", k.contactID);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }
        public bool Delete(Kontakte k)
        {
            bool isSuccess = false;
            SqlConnection conn = GetConnection();
            try
            {
                string sql = "DELETE FROM Table_Contact WHERE contactID=@contactID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@contactID", k.contactID);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }
    }
}
