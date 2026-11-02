using Microsoft.SqlServer.Server;
using System;
using System.Data;
using System.Data.SqlClient;
using DVLD.Models;


namespace DVLD_DataAccessLayer
{
    public class People_DataAccess
    {
        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT People.PersonID, People.NationalNo,
              People.FirstName, People.SecondName, People.ThirdName, People.LastName,
			  People.DateOfBirth, People.Gendor,  
				  CASE
                  WHEN People.Gendor = 0 THEN 'Male'

                  ELSE 'Female'

                  END as GendorCaption ,
			  People.Address, People.Phone, People.Email, 
              People.NationalityCountryID, Countries.CountryName, People.ImagePath
              FROM  People inner join Countries on People.NationalityCountryID = Countries.CountryID
              ORDER BY People.FirstName";

            using(SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error"+ex.Message);
                }
            }
            return dt;


        }
        public static People FindPerson(int personID )
        {
            string query = @"select * from people where PersonID = @personID;";
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection) )
            {
                command.Parameters.AddWithValue("@personID", personID);
                try
                {
                    connection.Open();
                    using( SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            return new People(
                         personID,
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
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: "+ex.Message);
                }
            }
            return null;
            
        }
        public static People FindPerson(string nationalNumber)
        {
            string query = @"select * from people where NationalNo = @nationalNo;";
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nationalNo", nationalNumber);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new People(
                         (int)reader["PersonID"],
                         nationalNumber,
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
        public static int addNewPerson(People person)
        {
            int newPersonID = -1;

            string query = @"INSERT INTO people (NationalNo,FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath)
                            VALUES (@nationalNumber,@firstName, @secondName, @thirdName, @lastName, @dateOfBirth, @gender, @address, @phoneNumber, @email, @CountryID, @imagePath);
                            SELECT SCOPE_IDENTITY();";

            using(SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nationalNumber", person.NationalID);
                command.Parameters.AddWithValue("@firstName", person.FirstName);
                command.Parameters.AddWithValue("@secondName", person.SecondName);
                if(string.IsNullOrEmpty(person.ThirdName))
                    command.Parameters.AddWithValue("@thirdName", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@thirdName", person.ThirdName);

                command.Parameters.AddWithValue("@lastName", person.LastName);
                command.Parameters.AddWithValue("@dateOfBirth", person.DateOfBirth);
                command.Parameters.AddWithValue("@gender", person.Gender);
                command.Parameters.AddWithValue("@address", person.Address);
                command.Parameters.AddWithValue("@phoneNumber", person.Phone);

                if (string.IsNullOrEmpty(person.Email))
                    command.Parameters.AddWithValue("@email", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@email", person.Email);

                command.Parameters.AddWithValue("@CountryID", person.NationalityCountryID);
                if (string.IsNullOrEmpty(person.ImagePath))
                    command.Parameters.AddWithValue("@imagePath", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@imagePath", person.ImagePath);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        newPersonID = insertedID;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:"+ex.Message);
                }
            }
            return newPersonID;
        }
        public static bool updatePerson(People person)
        {
            int rowsAffected = 0;
            string query = @"UPDATE people
                            SET NationalNo = @nationalNumber,
                                FirstName = @firstName,
                                SecondName = @secondName,
                                ThirdName = @thirdName,
                                LastName = @lastName,
                                DateOfBirth = @dateOfBirth,
                                Gendor = @gender,
                                Address = @address,
                                Phone = @phoneNumber,
                                Email = @email,
                                NationalityCountryID = @CountryID,
                                ImagePath = @imagePath
                            WHERE PersonID = @personID;";

            using(SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using(SqlCommand command = new SqlCommand(query,connection))
            {
                command.Parameters.AddWithValue("@personID", person.PersonID);
                command.Parameters.AddWithValue("@nationalNumber", person.NationalID);
                command.Parameters.AddWithValue("@firstName", person.FirstName);
                command.Parameters.AddWithValue("@secondName", person.SecondName);
                command.Parameters.AddWithValue("@lastName", person.LastName);
                command.Parameters.AddWithValue("@dateOfBirth", person.DateOfBirth);
                command.Parameters.AddWithValue("@gender", person.Gender);
                command.Parameters.AddWithValue("@address", person.Address);
                command.Parameters.AddWithValue("@phoneNumber", person.Phone);
                command.Parameters.AddWithValue("@CountryID", person.NationalityCountryID);


                if (string.IsNullOrEmpty(person.ThirdName))
                    command.Parameters.AddWithValue("@thirdName", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@thirdName", person.ThirdName);
               
                if (string.IsNullOrEmpty(person.Email))
                    command.Parameters.AddWithValue("@email", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@email", person.Email);

                if (string.IsNullOrEmpty(person.ImagePath))
                    command.Parameters.AddWithValue("@imagePath", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@imagePath",person.ImagePath);
                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error"+ex.Message);
                }
            }
            return rowsAffected > 0;

        }
         public static bool deletePerson(int personID)
         {
            int rowsAffected = 0;
            string query = "delete People where PersonID = @personID";

            using(SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString)) 
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@personID", personID);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();

                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error:"+ex.Message);
                }
            }
            return rowsAffected > 0;


         }
        public static int isPersonExistsByNationalNo(string nationalID)
        {
            int personID = -1;
            string query = "select PersonID from People where NationalNo = @nationalNo;";

            using(SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using( SqlCommand command = new SqlCommand(query,connection))
            {
                command.Parameters.AddWithValue("@nationalNo", nationalID);

                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        personID = insertedID;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:"+ex.Message);
                }
            }
            return personID;
        }

    }
}
