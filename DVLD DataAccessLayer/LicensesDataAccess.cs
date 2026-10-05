using DVLD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataAccessLayer
{
    public class LicensesDataAccess
    {
        public static DataTable GetAllLicensesForPersonID(int PersonID)
        {
            DataTable dt = new DataTable();
            string query = @"select L.LicenseID,L.ApplicationID,LC.ClassName,L.IssueDate,L.ExpirationDate,L.IsActive from Licenses as L inner join Drivers as D
                            on L.DriverID = D.DriverID 
                            inner join LicenseClasses as LC
                            on L.LicenseClass = LC.LicenseClassID
                            where D.PersonID = @personID";

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
        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {
            int LicenseID = -1;

            string query = @"select Licenses.LicenseID from Licenses inner join Drivers on Licenses.DriverID = Drivers.DriverID
                            where PersonID = @PersonID and LicenseClass = @LicenseClass and IsActive = 1";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@LicenseClass", LicenseClassID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        LicenseID = Convert.ToInt32(result);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:" + ex.Message);
                }
            }
            return LicenseID;
        }
        public static int AddLicense(Licenses license)
        {
            int newLicenseID = -1;

            string query = @"INSERT INTO Licenses 
                     (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                     VALUES 
                     (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);
                     SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ApplicationID", license.ApplicationID);
                command.Parameters.AddWithValue("@DriverID", license.DriverID);
                command.Parameters.AddWithValue("@LicenseClass", license.LicenseClassID);
                command.Parameters.AddWithValue("@IssueDate", license.IssueDate);
                command.Parameters.AddWithValue("@ExpirationDate", license.ExpirationDate);
                command.Parameters.AddWithValue("@PaidFees", license.PaidFees);
                command.Parameters.AddWithValue("@IsActive", license.IsActive);
                command.Parameters.AddWithValue("@IssueReason", license.IssueReason);
                command.Parameters.AddWithValue("@CreatedByUserID", license.UserID);

                if (string.IsNullOrEmpty(license.Notes))
                    command.Parameters.AddWithValue("@Notes", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@Notes", license.Notes);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        newLicenseID = insertedID;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return newLicenseID;
        }
        private static Licenses BuildLicenseObject(SqlDataReader reader)
        {
            int licenseClassID = (int)reader["LicenseClass"];

            LicenseClass licenseClass = new LicenseClass(
                licenseClassID,
                reader["ClassName"] as string ?? "",
                reader["ClassDescription"] as string ?? "",
                Convert.ToInt32(reader["MinimumAllowedAge"]),
                Convert.ToInt32(reader["DefaultValidityLength"]),
                Convert.ToDecimal(reader["ClassFees"])
                );

            string notes = reader["Notes"] != DBNull.Value ? (string)reader["Notes"] : "";


            return new Licenses(
                (int)reader["LicenseID"],
                (int)reader["ApplicationID"],
                (int)reader["DriverID"],
                licenseClassID,
                licenseClass,
                (DateTime)reader["IssueDate"],
                (DateTime)reader["ExpirationDate"],
                notes,
                Convert.ToDecimal(reader["PaidFees"]),
                (bool)reader["IsActive"],
                Convert.ToInt32(reader["IssueReason"]),
                Convert.ToInt32(reader["CreatedByUserID"])
                );
        }
        public static Licenses FindLicenseByLicenseID(int licenseID)
        {
            string query = @"SELECT Licenses.*, 
                            LicenseClasses.ClassName, 
                            LicenseClasses.ClassDescription, 
                            LicenseClasses.MinimumAllowedAge, 
                            LicenseClasses.DefaultValidityLength, 
                            LicenseClasses.ClassFees
                            FROM Licenses 
                            INNER JOIN LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
                            WHERE Licenses.LicenseID = @LicenseID";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@LicenseID", licenseID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return BuildLicenseObject(reader);
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
        public static Licenses FindLicenseByApplicationID(int applicationID)
        {
            string query = @"SELECT Licenses.*, 
                            LicenseClasses.ClassName, 
                            LicenseClasses.ClassDescription, 
                            LicenseClasses.MinimumAllowedAge, 
                            LicenseClasses.DefaultValidityLength, 
                            LicenseClasses.ClassFees
                            FROM Licenses 
                            INNER JOIN LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
                            where Licenses.ApplicationID = @applicationID";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@applicationID", applicationID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return BuildLicenseObject(reader);
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
