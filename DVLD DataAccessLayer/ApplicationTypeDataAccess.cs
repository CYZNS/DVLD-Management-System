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
    public class ApplicationTypeDataAccess
    {
        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();
            string query = "select * from ApplicationTypes order by ApplicationTypeTitle;";
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
        public static ApplicationType FindApplicationType(int ApplicationTypeID)
        {
            string query = @"select * from ApplicationTypes where ApplicationTypeID = @applicationTypeID;";
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@applicationTypeID", ApplicationTypeID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ApplicationType(ApplicationTypeID, reader["ApplicationTypeTitle"] as string ?? "" ,(decimal)reader["ApplicationFees"]);
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

        public static bool UpdateApplicationType(ApplicationType applicationType)
        {
            int rowsAffected = 0;
            string query = @"UPDATE ApplicationTypes
                            SET ApplicationTypeTitle = @applicationTypeTitle,
                            ApplicationFees = @applicationFees
                            WHERE ApplicationTypeID = @applicationTypeID;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@applicationTypeID", applicationType.ApplicationID);
                command.Parameters.AddWithValue("@applicationTypeTitle", applicationType.ApplicationTitle);
                command.Parameters.AddWithValue("@applicationFees", applicationType.ApplicationFees);

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


    }
}
