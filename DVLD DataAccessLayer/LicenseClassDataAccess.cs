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
    public class LicenseClassDataAccess
    {
        public static DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();
            string query = "select * from LicenseClasses order by LicenseClassID";
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
        public static LicenseClass FindLicenseClass(int LicenseClassID)
        {
            string query = @"select * from LicenseClasses where LicenseClassID = @licenseClassID;";
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@licenseClassID", LicenseClassID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new LicenseClass(LicenseClassID, reader["ClassName"] as string ?? "", reader["ClassDescription"] as string ?? "", (int)reader["MinimumAllowedAge"], (int)reader["DefaultValidityLength"], (decimal)reader["ClassFees"]);
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
