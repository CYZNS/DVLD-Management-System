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
    public class TestTypesDataAccess
    {
        public static DataTable getAllTestTypes()
        {
            DataTable dt = new DataTable();
            string query = "select * from TestTypes order by TestTypeTitle;";
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
        public static bool updateTestType(TestType testType)
        {
            int rowsAffected = 0;
            string query = @" update TestTypes
                              set TestTypeTitle = @testTypeTitle,
                              TestTypeDescription = @testTypeDescription,
                              TestTypeFees = @testTypeFees
                              where TestTypeID = @testTypeID;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@testTypeTitle", testType.TestTypeTitle);
                command.Parameters.AddWithValue("@testTypeDescription", testType.TestTypeDescription);
                command.Parameters.AddWithValue("@testTypeFees", testType.TestTypeFees);
                command.Parameters.AddWithValue("@testTypeID", testType.TestTypeID);


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
        public static TestType FindTestType(int TestTypeID)
        {
            string query = @"select * from TestTypes where TestTypeID =@testTypeID;";
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@testTypeID", TestTypeID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new TestType(
                         TestTypeID,
                         reader["TestTypeTitle"] as string ?? "",
                         (decimal)reader["TestTypeFees"],
                         reader["TestTypeDescription"] as string ?? ""
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

    }
}
