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
    public class clsPatientServiceData
    {
        public static bool GetPatientServiceInfoByID(int ID, ref int PatientID, ref int NurseID, ref int DoctorID, ref string Services,
                            ref DateTime StartingDate, ref DateTime ApplicationDate, ref string Period, ref string Shift, ref string EquipmentsNeeded,
                            ref string PatientDiagnostic, ref string HospitalName, ref string ApplicationRequest, ref int TotalAmount, ref int AmountPaid)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from PatientServices where ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    PatientID = (int)reader["PatientID"];

                    if (reader["NurseID"] != DBNull.Value)
                    {
                        NurseID = (int)reader["NurseID"];
                    }
                    else
                    {
                        NurseID = -1;
                    }

                    if (reader["DoctorID"] != DBNull.Value)
                    {
                        DoctorID = (int)reader["DoctorID"];
                    }
                    else
                    {
                        DoctorID = -1;
                    }

                    Services = (string)reader["Services"];       
                    StartingDate = (DateTime)(reader["StartingDate"]);
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    Period = (string)reader["Period"];
                    Shift = (string)reader["Shift"];

                    if (reader["EquipmentsNeeded"] != DBNull.Value)
                    {
                        EquipmentsNeeded = (string)reader["EquipmentsNeeded"];
                    }
                    else
                    {
                        EquipmentsNeeded = "";
                    }

                    PatientDiagnostic = (string)reader["PatientDiagnostic"];
                    HospitalName = (string)reader["HospitalName"];
                    ApplicationRequest = (string)reader["ApplicationRequest"];
                    TotalAmount = (int)reader["TotalAmount"];
                    AmountPaid = (int)reader["AmountPaid"];

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

        public static int AddNewPatientService(int PatientID, int NurseID, int DoctorID, string Services,
                            DateTime StartingDate, DateTime ApplicationDate, string Period, string Shift, string EquipmentsNeeded,
                            string PatientDiagnostic, string HospitalName, string ApplicationRequest, int TotalAmount, int AmountPaid)
        {
            int PatientServiceID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Insert into PatientServices Values (@PatientID, @NurseID, @DoctorID, @Services, @StartingDate,
                             @ApplicationDate, @Period, @Shift, @EquipmentsNeeded, @PatientDiagnostic, @HospitalName,
                             @ApplicationRequest, @TotalAmount, @AmountPaid);
                             Select SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PatientID", PatientID);

            if (NurseID != -1)
            {
                command.Parameters.AddWithValue("@NurseID", NurseID);
            }
            else
            {
                command.Parameters.AddWithValue("@NurseID", DBNull.Value);
            }

            if (DoctorID != -1)
            {
                command.Parameters.AddWithValue("@DoctorID", DoctorID);
            }
            else
            {
                command.Parameters.AddWithValue("@DoctorID", DBNull.Value);
            }
            command.Parameters.AddWithValue("@Services", Services);
            command.Parameters.AddWithValue("@StartingDate", StartingDate);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@Period", Period);
            command.Parameters.AddWithValue("@Shift", Shift);

            if (!string.IsNullOrEmpty(EquipmentsNeeded))
            {
                command.Parameters.AddWithValue("@EquipmentsNeeded", EquipmentsNeeded);
            }
            else
            {
                command.Parameters.AddWithValue("@EquipmentsNeeded", DBNull.Value);
            }

            command.Parameters.AddWithValue("@PatientDiagnostic", PatientDiagnostic);
            command.Parameters.AddWithValue("@HospitalName", HospitalName);
            command.Parameters.AddWithValue("@ApplicationRequest", ApplicationRequest);
            command.Parameters.AddWithValue("@TotalAmount", TotalAmount);
            command.Parameters.AddWithValue("@AmountPaid", AmountPaid);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    PatientServiceID = insertedID;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return PatientServiceID;
        }

        public static bool UpdatePatientService(int ID, int PatientID, int NurseID, int DoctorID, string Services, 
                            DateTime StartingDate, DateTime ApplicationDate, string Period, string Shift, string EquipmentsNeeded,
                            string PatientDiagnostic, string HospitalName, string ApplicationRequest, int TotalAmount, int AmountPaid)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update PatientServices set PatientID = @PatientID, NurseID = @NurseID, DoctorID = @DoctorID, Services = @Services,
                            StartingDate = @StartingDate, ApplicationDate = @ApplicationDate, Period = @Period, Shift = @Shift, EquipmentsNeeded = @EquipmentsNeeded,
                            PatientDiagnostic = @PatientDiagnostic, HospitalName = @HospitalName, ApplicationRequest = @ApplicationRequest, TotalAmount = @TotalAmount,
                            AmountPaid = @AmountPaid
                            where ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@PatientID", PatientID);

            if (NurseID != -1)
            {
                command.Parameters.AddWithValue("@NurseID", NurseID);
            }
            else
            {
                command.Parameters.AddWithValue("@NurseID", DBNull.Value);
            }

            if (DoctorID != -1)
            {
                command.Parameters.AddWithValue("@DoctorID", DoctorID);
            }
            else
            {
                command.Parameters.AddWithValue("@DoctorID", DBNull.Value);
            }
            command.Parameters.AddWithValue("@Services", Services);
            command.Parameters.AddWithValue("@StartingDate", StartingDate);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@Period", Period);
            command.Parameters.AddWithValue("@Shift", Shift);

            if (!string.IsNullOrEmpty(EquipmentsNeeded))
            {
                command.Parameters.AddWithValue("@EquipmentsNeeded", EquipmentsNeeded);
            }
            else
            {
                command.Parameters.AddWithValue("@EquipmentsNeeded", DBNull.Value);
            }

            command.Parameters.AddWithValue("@PatientDiagnostic", PatientDiagnostic);
            command.Parameters.AddWithValue("@HospitalName", HospitalName);
            command.Parameters.AddWithValue("@ApplicationRequest", ApplicationRequest);
            command.Parameters.AddWithValue("@TotalAmount", TotalAmount);
            command.Parameters.AddWithValue("@AmountPaid", AmountPaid);

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

        public static DataTable GetAllPatientServices()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select * from GetAllPatientServices";

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

        public static bool DeletePatientService(int ID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Delete from PatientServices where ID = @ID";
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

        public static int GetAmountPaidForMonth(int SelectedYear, int SelectedMonth)
        {
            int AmountPaid = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT SUM(AmountPaid) AS TotalAmountPaid
                                FROM PatientServices
                                WHERE YEAR(ApplicationDate) = @SelectedYear
                                  AND MONTH(ApplicationDate) = @SelectedMonth";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SelectedYear", SelectedYear);
            command.Parameters.AddWithValue("@SelectedMonth", SelectedMonth);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int amount))
                    AmountPaid = amount;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return AmountPaid;
        }

        public static int GetAllAmountPaid()
        {
            int AmountPaid = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT SUM(AmountPaid) AS TotalAmountPaid
                                FROM PatientServices";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int amount))
                    AmountPaid = amount;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return AmountPaid;
        }

        public static int GetCollectedMoney()
        {
            int CollectedMoney = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select CollectedMoney from Money";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int amount))
                    CollectedMoney = amount;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return CollectedMoney;
        }

        public static bool UpdateCollectedMoney(int Money)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update Money set CollectedMoney = @Money";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Money", Money);

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
