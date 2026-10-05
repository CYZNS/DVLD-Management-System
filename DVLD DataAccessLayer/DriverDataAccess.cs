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
    public class DriverDataAccess
    {
        public static DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();

            string query = @"select D.DriverID,P.PersonID,P.NationalNo,(P.FirstName+' '+p.SecondName+' '+p.ThirdName+' '+p.LastName) as FullName
                            ,D.CreatedDate,
                             (
                                select count(*) from Licenses 
                                where IsActive =1 and DriverID = D.DriverID

                             )as ActiveLicenses
                             from Drivers as D inner join People as P 
                             on D.PersonID = P.PersonID";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return dt;
        }
        private static Driver BuildDriverObject(SqlDataReader reader)
        {
            People personInfo = new People(
                            (int)reader["PersonID"],
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

            return new Driver(
                (int)reader["DriverID"],
                (int)reader["PersonID"],
                personInfo,
                (int)reader["CreatedByUserID"],
                (DateTime)reader["CreatedDate"]

            );
        }
        public static Driver FindDriverByPersonID(int personID)
        {
            string query = @"select Drivers.DriverID,Drivers.CreatedByUserID,Drivers.CreatedDate,People.* from Drivers inner join People
                              on Drivers.PersonID = People.PersonID
                                where People.PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonID", personID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            return BuildDriverObject(reader);
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
        public static Driver FindDriverByDriverID(int driverID)
        {
            string query = @"select Drivers.DriverID,Drivers.CreatedByUserID,Drivers.CreatedDate,People.* from Drivers inner join People
                              on Drivers.PersonID = People.PersonID
                              where Drivers.DriverID = @DriverID";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@DriverID", driverID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            return BuildDriverObject(reader);
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
        public static int AddDriver(Driver driver)
        {
            int newDriverID = -1;

            string query = @"INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate)
                             VALUES (@PersonID, @CreatedByUserID, @CreatedDate);
                             SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonID", driver.PersonID);
                command.Parameters.AddWithValue("@CreatedByUserID", driver.UserID);
                command.Parameters.AddWithValue("@CreatedDate", driver.CreatedDate);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        newDriverID = insertedID;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return newDriverID;
        }

         


    }
}
