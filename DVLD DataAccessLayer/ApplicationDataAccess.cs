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
    public class ApplicationDataAccess
    {   

        public static DataTable GetAllApplications()
        {
            DataTable dt = new DataTable();
            string query = "select * from Applications order by ApplicationID;";
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
        public static ApplicationModel FindApplication(int ApplicantID)
        {
            //here I stored all the objects of the foreign keys in the Applications Table but without the object of the user 
            // because I think I will not use frequently so no problem to call the User.Find(UserID)

            string query = @"select * from Applications 
                            inner join People on Applications.ApplicantPersonID = People.PersonID
                            inner join ApplicationTypes on Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID
                            where ApplicationID =@applicationID;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@applicationID", ApplicantID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int PersonID = (int)reader["ApplicantPersonID"];

                            People PersonInfo = new People(
                                PersonID,
                                reader["NationalNo"] as string ?? "",
                                reader["FirstName"] as string ?? "",
                                reader["SecondName"] as string ?? "",
                                reader["ThirdName"] as string ?? "",
                                reader["LastName"] as string ?? "",
                                (DateTime)reader["DateOfBirth"],
                                (byte)reader["Gendor"],
                                reader["Address"] as string ?? "",
                                reader["Phone"] as string ?? "",
                                reader["Email"] as string ?? "",
                                (int)reader["NationalityCountryID"],
                                reader["ImagePath"] as string ?? ""
                            );
                            int UserID = (int)reader["CreatedByUserID"];
                            int ApplicationTypeID = Convert.ToInt32(reader["ApplicationTypeID"]);

                            ApplicationType applicationType = new ApplicationType(ApplicationTypeID,
                                reader["ApplicationTypeTitle"] as string ?? ""
                                , (decimal)reader["ApplicationFees"]);


                            return new ApplicationModel(
                                ApplicantID, PersonID,PersonInfo,
                                 (DateTime)reader["ApplicationDate"],
                                ApplicationTypeID, applicationType,
                                Convert.ToInt32(reader["ApplicationStatus"]), 
                                (DateTime)reader["LastStatusDate"],
                                (decimal)reader["PaidFees"], UserID);
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
        public static int AddNewApplication(ApplicationModel application)
        {
            int NewApplicationID = -1;

            string query = @"INSERT INTO Applications(ApplicantPersonID, ApplicationDate, ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID)
                            Values(@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID,@ApplicationStatus,@LastStatusDate,@PaidFees,@CreatedByUserID);
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@ApplicantPersonID", application.PersonID);
                command.Parameters.AddWithValue("@ApplicationDate", application.ApplicationDate);
                command.Parameters.AddWithValue("@ApplicationTypeID", application.ApplicationTypeID);
                command.Parameters.AddWithValue("@ApplicationStatus", application.ApplicationStatus);
                command.Parameters.AddWithValue("@LastStatusDate", application.LastStatusDate);
                command.Parameters.AddWithValue("@PaidFees", application.PaidFees);
                command.Parameters.AddWithValue("@CreatedByUserID", application.UserID);


                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        NewApplicationID = insertedID;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:" + ex.Message);
                }
            }
            return NewApplicationID;
        }

        public static bool UpdateApplication(ApplicationModel application)
        {
            int rowsAffected = 0;

            string query = @"UPDATE Applications 
                     SET ApplicantPersonID = @ApplicantPersonID, 
                         ApplicationDate = @ApplicationDate, 
                         ApplicationTypeID = @ApplicationTypeID,
                         ApplicationStatus = @ApplicationStatus,
                         LastStatusDate = @LastStatusDate,
                         PaidFees = @PaidFees,
                         CreatedByUserID = @CreatedByUserID
                     WHERE ApplicationID = @ApplicationID;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                
                command.Parameters.AddWithValue("@ApplicationID", application.ApplicationID);

                command.Parameters.AddWithValue("@ApplicantPersonID", application.PersonID);
                command.Parameters.AddWithValue("@ApplicationDate", application.ApplicationDate);
                command.Parameters.AddWithValue("@ApplicationTypeID", application.ApplicationTypeID);
                command.Parameters.AddWithValue("@ApplicationStatus", application.ApplicationStatus);
                command.Parameters.AddWithValue("@LastStatusDate", application.LastStatusDate);
                command.Parameters.AddWithValue("@PaidFees", application.PaidFees);
                command.Parameters.AddWithValue("@CreatedByUserID", application.UserID);

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
