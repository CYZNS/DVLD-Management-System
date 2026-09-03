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
    public class LocalDrivingLicenseDataAccess
    {
        public static DataTable GetAllLocalDrivingApplications()
        {
            DataTable dt = new DataTable();
            string query = "select * from LocalDrivingLicenseApplications_View;";
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
            Console.WriteLine(dt.Rows.Count);
            return dt;


        }
        public static LocalDrivingLicenseApplication FindLocalDrivingApplication(int LocalDrivingApplicationID)
        {
            int LicenseClassID = -1;
            int ApplicationID = -1;

            string query = @"select * from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingApplicationID;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@LocalDrivingApplicationID", LocalDrivingApplicationID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                             LicenseClassID = (int)reader["LicenseClassID"];
                            ApplicationID = (int)reader["ApplicationID"];

                           
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
            ApplicationModel BaseApplication = ApplicationDataAccess.FindApplication(ApplicationID);
            if(BaseApplication != null)
            {
                return new LocalDrivingLicenseApplication(BaseApplication.ApplicationID, BaseApplication.PersonID, BaseApplication.Person, BaseApplication.ApplicationDate, BaseApplication.ApplicationTypeID, BaseApplication.applicationType, BaseApplication.ApplicationStatus
                    , BaseApplication.LastStatusDate, BaseApplication.PaidFees, BaseApplication.UserID, LocalDrivingApplicationID, LicenseClassID);
            }

           


            return null;

        }
        public static int AddNewLocalDrivingApplication(LocalDrivingLicenseApplication LocalDrivingApplication)
        {
            int NewLocalDrivingApplicationID = -1;

            string query = @"INSERT INTO LocalDrivingLicenseApplications(ApplicationID,LicenseClassID)
                            Values(@ApplicationID,@LicenseClassID);
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@ApplicationID", LocalDrivingApplication.ApplicationID);
                command.Parameters.AddWithValue("@LicenseClassID", LocalDrivingApplication.LicenseClassID);
           
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        NewLocalDrivingApplicationID = insertedID;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:" + ex.Message);
                }
            }
            return NewLocalDrivingApplicationID;
        }
        public static bool UpdateLocalDrivingApplication(LocalDrivingLicenseApplication application)
        {
            int rowsAffected = 0;

            string query = @"UPDATE LocalDrivingLicenseApplications 
                     SET LicenseClassID = @LicenseClassID
                     WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@LicenseClassID", application.LicenseClassID);
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", application.LocalDrivingLicenseApplicationID);

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

            // Returns true if at least one row was updated
            return (rowsAffected > 0);
        }


    }
}
