using DVLD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class TestAppointmentDataAccess
    {
        public static DataTable GetAllTestAppointmentsForTestTypeForLocalDrivingApplication(int localDrivingApplicationID,int testTypeID)
        {
            DataTable dt = new DataTable();
            string query = "select TestAppointmentID,AppointmentDate,PaidFees,IsLocked from TestAppointments where TestTypeID = @testTypeID and LocalDrivingLicenseApplicationID =@localDrivingApplicationID";
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@testTypeID", testTypeID);
                command.Parameters.AddWithValue("@localDrivingApplicationID", localDrivingApplicationID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);
                }
            }
            return dt;


        }
        public static TestAppointment FindTestAppointment(int testAppointmentID)
        {
            string query = @"select * from TestAppointments where TestAppointmentID = @testAppointmentID;";
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@testAppointmentID", testAppointmentID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new TestAppointment(

                                testAppointmentID,
                                (int)reader["TestTypeID"],
                                (int)reader["LocalDrivingLicenseApplicationID"],
                                (DateTime)reader["AppointmentDate"],
                                (decimal)reader["PaidFees"],
                                (int)reader["CreatedByUserID"],
                                (bool)reader["IsLocked"],
                                (reader["RetakeTestApplicationID"] != DBNull.Value) ? (int)reader["RetakeTestApplicationID"] : -1
                                );
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return null;

        }
        public static int AddNewAppointment(TestAppointment appointment)
        {
            int newAppointmentID = -1;

            string query = @"INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked,RetakeTestApplicationID)
                            VALUES (@testTypeID, @localDrivingApplicationID, @appointmentDate, @paidFees, @createdByUserID, @isLocked,@retakeTestApplicationID);
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@testTypeID", appointment.TestTypeID);
                command.Parameters.AddWithValue("@localDrivingApplicationID", appointment.LocalDrivingApplicationID);
                command.Parameters.AddWithValue("@appointmentDate", appointment.AppointmentDate);
                command.Parameters.AddWithValue("@paidFees", appointment.PaidFees);
                command.Parameters.AddWithValue("@createdByUserID", appointment.UserID);
                command.Parameters.AddWithValue("@isLocked", appointment.isLocked);

                if(appointment.RetakeTestID ==-1)
                    command.Parameters.AddWithValue("@retakeTestApplicationID", DBNull.Value);
                else
                {
                    command.Parameters.AddWithValue("@retakeTestApplicationID", appointment.RetakeTestID);
                }

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        newAppointmentID = insertedID;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return newAppointmentID;
        }
        public static bool HasActiveAppointment(int localDrivingApplicationID, int testTypeID)
        {
            bool isFound = false;

            string query = @"SELECT 1 FROM TestAppointments 
                             WHERE LocalDrivingLicenseApplicationID = @localDrivingApplicationID 
                             AND TestTypeID = @testTypeID 
                             AND IsLocked = 0;";
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@localDrivingApplicationID", localDrivingApplicationID);
                command.Parameters.AddWithValue("@testTypeID", testTypeID);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        isFound = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return isFound;
        }
        public static bool UpdateTestAppointment(TestAppointment appointment)
        {
            int rowsAffected = 0;
            string query = @"update TestAppointments
                             set AppointmentDate = @appointmentDate
                             where TestAppointmentID = @testAppointmentID;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@testAppointmentID", appointment.TestAppointmentID);
                command.Parameters.AddWithValue("@appointmentDate", appointment.AppointmentDate);
                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);
                }
            }
            return rowsAffected > 0;

        }
        public static bool LockTestAppointment(int TestAppointmentID)
        {
            int rowsAffected = 0;
            string query = @"Update TestAppointments 
                            set IsLocked = 1 
                            where TestAppointmentID =@testAppointmentID;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@testAppointmentID", TestAppointmentID);
                
                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:" + ex.Message);
                    return false;
                }
            }
            return rowsAffected > 0;
        }

    }
}
