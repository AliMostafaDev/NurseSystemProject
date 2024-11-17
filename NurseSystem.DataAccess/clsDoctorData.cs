using System;
using System.Data;
using System.Data.SqlClient;

namespace NurseSystem.DataAccess
{
    public class clsDoctorData
    {
        public static bool GetDoctorInfoByID(int ID, ref string FirstName, ref string LastName, ref char Gender,
                    ref string Major, ref DateTime DateOfBirth, ref string PhoneNumber, ref string Email,
                    ref string Address, ref int Salary)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from Doctors where ID = @ID";
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
                    LastName = (string)reader["LastName"];
                    Gender = Convert.ToChar(reader["Gender"]);
                    Major = (string)(reader["Major"]);
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    PhoneNumber = (string)reader["PhoneNumber"];
                    Email = (string)reader["Email"];
                    Address = (string)reader["Address"];
                    Salary = (int)reader["Salary"];
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

        public static bool GetDoctorInfoByFirstName(string FirstName, ref int ID, ref string LastName, ref char Gender,
                    ref string Major, ref DateTime DateOfBirth, ref string PhoneNumber, ref string Email,
                    ref string Address, ref int Salary)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from Doctors where FirstName = @FirstName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["ID"];
                    LastName = (string)reader["LastName"];
                    Gender = Convert.ToChar(reader["Gender"]);
                    Major = (string)(reader["Major"]);
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    PhoneNumber = (string)reader["PhoneNumber"];
                    Email = (string)reader["Email"];
                    Address = (string)reader["Address"];
                    Salary = (int)reader["Salary"];
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

        public static int AddNewDoctor(string FirstName, string LastName, char Gender, string Major,
                    DateTime DateOfBirth, string PhoneNumber, string Email, string Address, int Salary)
        {
            int DoctorID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Insert into Doctors Values (@FirstName, @LastName, @Gender, @Major,
                             @DateOfBirth, @PhoneNumber, @Email, @Address, @Salary);
                             Select SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Major", Major);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Salary", Salary);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    DoctorID = insertedID;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return DoctorID;
        }

        public static bool UpdateDoctor(int ID, string FirstName, string LastName, char Gender, string Major,
                    DateTime DateOfBirth, string PhoneNumber, string Email, string Address, int Salary)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update Doctors set FirstName = @FirstName, LastName = @LastName, Gender = @Gender,
                            Major = @Major, DateOfBirth = @DateOfBirth, PhoneNumber = @PhoneNumber, Email = @Email,
                            Address = @Address, Salary = @Salary
                            where ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Major", Major);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Salary", Salary);

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

        public static DataTable GetAllDoctors()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select ID, FirstName, LastName, 
                             Case
                                When Gender = 'M' Then 'Male'
                                When Gender = 'F' Then 'Female'
                                Else 'Unknown'
                             End as Gender,
                           Major, DateOfBirth, PhoneNumber, Address, Salary
                            from Doctors";
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

        public static DataTable GetAllDoctorsWithoutSalary()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select ID, FirstName, LastName, 
                             Case
                                When Gender = 'M' Then 'Male'
                                When Gender = 'F' Then 'Female'
                                Else 'Unknown'
                             End as Gender,
                            Major, DateOfBirth, PhoneNumber, Address
                            from Doctors";
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

        public static bool DeleteDoctor(int ID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Delete from Doctors where ID = @ID";
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
