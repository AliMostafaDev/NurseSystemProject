using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseSystem.DataAccess
{
    public class clsPatientData
    {
        public static bool GetPatientInfoByID(int ID, ref string FirstName, ref string SecondName, ref string LastName,
              ref char Gender, ref DateTime DateOfBirth, ref string PhoneNumber, ref string Email, ref string Address, ref byte Weight, ref int Age)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from Patients where ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    LastName = (string)reader["LastName"];
                    Gender = Convert.ToChar(reader["Gender"]);
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    PhoneNumber = (string)reader["PhoneNumber"];
                    Email = (string)reader["Email"];
                    Address = (string)reader["Address"];
                    Weight = (byte)reader["Weight"];
                    Age = (int)reader["Age"];
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

        public static bool GetPatientInfoByPhoneNumber(string PhoneNumber, ref int ID, ref string FirstName, ref string SecondName, ref string LastName,
             ref char Gender, ref DateTime DateOfBirth, ref string Email, ref string Address, ref byte Weight, ref int Age)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from Patients where PhoneNumber = @PhoneNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["ID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    LastName = (string)reader["LastName"];
                    Gender = Convert.ToChar(reader["Gender"]);
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Email = (string)reader["Email"];
                    Address = (string)reader["Address"];
                    Weight = (byte)reader["Weight"];
                    Age = (int)reader["Age"];

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

        public static int AddNewPatient(string FirstName, string SecondName, string LastName, char Gender,
                    DateTime DateOfBirth, string PhoneNumber, string Email, string Address, byte Weight)
        {
            int PatientID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Insert into Patients Values (@FirstName, @SecondName, @LastName, @Gender, @DateOfBirth,
                              @PhoneNumber, @Email, @Address, @Weight);
                             Select SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Weight", Weight);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    PatientID = insertedID;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return PatientID;
        }

        public static bool UpdatePatient(int ID, string FirstName, string SecondName, string LastName, char Gender,
                    DateTime DateOfBirth, string PhoneNumber, string Email, string Address, byte Weight)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update Patients set FirstName = @FirstName, SecondName = @SecondName, LastName = @LastName, Gender = @Gender,
                            DateOfBirth = @DateOfBirth, PhoneNumber = @PhoneNumber, Email = @Email, Address = @Address, Weight = @Weight
                            where ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Weight", Weight);

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

        public static DataTable GetAllPatients()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select ID, FirstName, SecondName, LastName, 
                             Case
                                When Gender = 'M' Then 'Male'
                                When Gender = 'F' Then 'Female'
                                Else 'Unknown'
                             End as Gender,
                            DateOfBirth, PhoneNumber, Email, Address
                            from Patients";
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

        public static bool DeletePateint(int ID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Delete from Patients where ID = @ID";
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
