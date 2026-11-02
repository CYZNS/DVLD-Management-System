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
    public class InternationalLicenseDataAccess
    {
        public static DataTable GetAllInternationalLicensesForPersonID(int PersonID)
        {
            DataTable dt = new DataTable();
            string query = @"select InternationalLicenseID,ApplicationID,IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,IsActive 
                            FROM InternationalLicenses 
                            INNER JOIN Drivers ON InternationalLicenses.DriverID = Drivers.DriverID 
                            WHERE Drivers.PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@personID", PersonID);
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
        public static DataTable GetAllInternationalLicenses()
        {
            DataTable dt = new DataTable();
            string query = @"select InternationalLicenseID,ApplicationID,DriverID,IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,IsActive
                            from InternationalLicenses";

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
                    Console.WriteLine("Error" + ex.Message);
                }
            }
            return dt;


        }

        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {
            int InternationalLicenseID = -1;

            string query = @"SELECT InternationalLicenseID
                            FROM InternationalLicenses
                            WHERE DriverID = @DriverID
                            AND IsActive = 1;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@driverID", DriverID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        InternationalLicenseID = Convert.ToInt32(result);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:" + ex.Message);
                }
            }
            return InternationalLicenseID;
        }
        public static int AddInternationalLicense(InternationalLicenses internationalLicense)
        {
            int newInternationalLicenseID = -1;

            string query = @"INSERT INTO InternationalLicenses 
                     (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive,CreatedByUserID)
                     VALUES 
                     (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate,@IsActive,@CreatedByUserID);
                     SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ApplicationID", internationalLicense.ApplicationID);
                command.Parameters.AddWithValue("@DriverID", internationalLicense.DriverID);
                command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", internationalLicense.LocalLicenseID);
                command.Parameters.AddWithValue("@IssueDate", internationalLicense.IssueDate);
                command.Parameters.AddWithValue("@ExpirationDate", internationalLicense.ExpirationDate);
                command.Parameters.AddWithValue("@IsActive", internationalLicense.IsActive);
                command.Parameters.AddWithValue("@CreatedByUserID", internationalLicense.UserID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        newInternationalLicenseID = insertedID;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return newInternationalLicenseID;
        }
        public static InternationalLicenses FindInternationalLicenseInfoByLicenseID(int InternationallicenseID)
        {
            string query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@InternationalLicenseID", InternationallicenseID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new InternationalLicenses
                            {
                                InternationalLicenseID = (int)reader["InternationalLicenseID"],
                                ApplicationID = (int)reader["ApplicationID"],
                                DriverID = (int)reader["DriverID"],
                                LocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"],
                                IssueDate = (DateTime)reader["IssueDate"],
                                ExpirationDate = (DateTime)reader["ExpirationDate"],
                                IsActive = (bool)reader["IsActive"],
                                UserID = (int)reader["CreatedByUserID"]
                            };
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


    }
}
