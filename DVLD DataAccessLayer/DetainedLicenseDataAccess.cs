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
    public class DetainedLicenseDataAccess
    {
        public static int IsLicenseDetained(int licenseID)
        {
            int detainedLicenseID = -1;
            string query = "select top 1 DetainID from DetainedLicenses where LicenseID = @licenseID and IsReleased =0";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@licenseID", licenseID);

                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        detainedLicenseID = insertedID;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:" + ex.Message);
                }
            }
            return detainedLicenseID;
        }
        public static int DetainLicense(DetainedLicense license)
        {
            int detainedLicense = -1;
            string query = @"INSERT INTO DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased)
                            VALUES (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased);
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@LicenseID", license.LicenseID);
                command.Parameters.AddWithValue("@DetainDate", license.DetainDate);
                command.Parameters.AddWithValue("@FineFees", license.FineFees);
                command.Parameters.AddWithValue("@CreatedByUserID", license.CreatedByUserID);
                command.Parameters.AddWithValue("@IsReleased", license.IsReleased);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        detainedLicense = insertedID;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:" + ex.Message);
                }
            }
            return detainedLicense;
        }
        public static DetainedLicense FindDetainedLicense(int DetainedID)
        {
            string query = "select * from DetainedLicenses where DetainID =@detainID";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@detainID", DetainedID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new DetainedLicense(
                                DetainedID,
                                (int)reader["LicenseID"],
                                (DateTime)reader["DetainDate"],
                                Convert.ToDecimal(reader["FineFees"]),
                                (int)reader["CreatedByUserID"],
                                (bool)reader["IsReleased"],
                                reader["ReleaseDate"] as DateTime?,
                                reader["ReleasedByUserID"] as int?,
                                reader["ReleaseApplicationID"] as int?
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
        public static bool ReleaseDetainedLicense(int detainID,int ReleasedByUserID,int ReleaseApplicationID)
        {
            int rowsAffected = 0;
            string query = @"update DetainedLicenses
                            set IsReleased = 1,
                            ReleaseDate = GETDATE(),
                            ReleasedByUserID = @userID ,
                            ReleaseApplicationID = @applicationID 
                            where DetainID = @detainID and IsReleased =0";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@detainID", detainID);
                command.Parameters.AddWithValue("@userID", ReleasedByUserID);
                command.Parameters.AddWithValue("@applicationID", ReleaseApplicationID);
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

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();
            string query = @"select DL.DetainID,DL.LicenseID,DL.DetainDate,DL.IsReleased,DL.FineFees,DL.ReleaseDate,P.NationalNo,P.FirstName+' '+p.SecondName+' '+p.ThirdName+' '+p.LastName as FullName,DL.ReleaseApplicationID 
                            from DetainedLicenses as DL inner join licenses L on DL.LicenseID = L.LicenseID
                            inner join Drivers as D on D.DriverID = L.DriverID
                            inner join People as p on p.PersonID = D.PersonID";

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


    }
}
