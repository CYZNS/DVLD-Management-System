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
    public class TestDataAccess
    {
        public static DataTable GetAllTests()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Tests;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
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
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return dt;
        }
        public static Test FindTest(int testID)
        {
            string query = "SELECT * FROM Tests WHERE TestID = @testID;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@testID", testID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Test(
                                (int)reader["TestID"],
                                (int)reader["TestAppointmentID"],
                                (bool)reader["TestResult"],
                                reader["Notes"] as string ?? "", 
                                (int)reader["CreatedByUserID"]
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
        public static int AddNewTest(Test test)
        {
            int newTestID = -1;

            string query = @"INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID) 
                             VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID); 
                             SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TestAppointmentID", test.TestAppointmentID);
                command.Parameters.AddWithValue("@TestResult", test.TestResult);
                command.Parameters.AddWithValue("@CreatedByUserID", test.CreatedByUserID);

                if (string.IsNullOrEmpty(test.Notes))
                    command.Parameters.AddWithValue("@Notes", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@Notes", test.Notes);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        newTestID = insertedID;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return newTestID;
        }
        public static bool DoesFailOrPassOnTestType(int localDrivingLicenseApplicationID, int testTypeID,int passOrFailCheck)
        {
            bool isFailed = false;

            string query = @"SELECT TOP 1 1 
                     FROM Tests 
                     INNER JOIN TestAppointments 
                     ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                     WHERE TestAppointments.LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID 
                     AND TestAppointments.TestTypeID = @testTypeID 
                     AND Tests.TestResult = @passOrFailCheck;"; 

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                command.Parameters.AddWithValue("@testTypeID", testTypeID);
                command.Parameters.AddWithValue("@passOrFailCheck", passOrFailCheck);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        isFailed = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return isFailed;
        }

        public static int TotalTrialsPerTestType(int localDrivingLicenseApplicationID,int testTypeID)
        {
            int totalTrials = 0;

            string query = @"select count(*) as TotalTrials from Tests inner join TestAppointments 
                            on Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                            where LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID 
                            and TestAppointments.TestTypeID = @testTypeID";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                command.Parameters.AddWithValue("@testTypeID", testTypeID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int TotalTrials))
                    {
                        totalTrials = TotalTrials;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return totalTrials;
        }
        
    }
}
