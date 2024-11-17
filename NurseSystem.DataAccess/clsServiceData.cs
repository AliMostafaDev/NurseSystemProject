using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NurseSystem.DataAccess
{
    public class clsServiceData
    {
        public static bool GetServiceInfoByID(int ID, ref string Name, ref string Description, ref int BasicPrice, ref int SalePrice)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from Services where ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Name = (string)reader["Name"];
                    if (reader["Description"] != DBNull.Value)
                        Description = (string)reader["Description"];
                    else
                        Description = "";
                    BasicPrice = (int)(reader["BasicPrice"]);
                    SalePrice = (int)reader["SalePrice"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetServiceInfoByName(string Name, ref int ID, ref string Description, ref int BasicPrice, ref int SalePrice)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from Services where Name = @Name";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["ID"];
                    if (reader["Description"] != DBNull.Value)
                        Description = (string)reader["Description"];
                    else
                        Description = "";
                    BasicPrice = (int)(reader["BasicPrice"]);
                    SalePrice = (int)reader["SalePrice"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewService(string Name, string Description, int BasicPrice, int SalePrice)
        {
            int ServiceID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Insert into Services Values (@Name, @Description, @BasicPrice, @SalePrice);
                             Select SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);

            if (!string.IsNullOrEmpty(Description))
                command.Parameters.AddWithValue("@Description", Description);
            else
                command.Parameters.AddWithValue("@Description", DBNull.Value);

            command.Parameters.AddWithValue("@BasicPrice", BasicPrice);
            command.Parameters.AddWithValue("@SalePrice", SalePrice);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    ServiceID = insertedID;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return ServiceID;
        }

        public static bool UpdateService(int ID, string Name, string Description, int BasicPrice, int SalePrice)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update Services set Name = @Name, Description = @Description, BasicPrice = @BasicPrice,
                            SalePrice = @SalePrice
                            where ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Name", Name);

            if (!string.IsNullOrEmpty(Description))
                command.Parameters.AddWithValue("@Description", Description);
            else
                command.Parameters.AddWithValue("@Description", DBNull.Value);

            command.Parameters.AddWithValue("@BasicPrice", BasicPrice);
            command.Parameters.AddWithValue("@SalePrice", SalePrice);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        public static DataTable GetAllServices()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select * from Services";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool DeleteService(int ID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Delete from Services where ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }

    }
}
