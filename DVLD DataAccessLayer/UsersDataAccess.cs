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
    public class UsersDataAccess
    {
        public static DataTable listUsers()
        {
            DataTable dt = new DataTable();
            string query = "select * from Users;";
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
        public static DataTable listUsersWithPersonFullName()
        {
            DataTable dt = new DataTable();
            string query = @"select U.UserID,P.PersonID,(P.FirstName+' '+P.SecondName+' '+P.ThirdName+' '+P.LastName) as FullName,UserName,U.IsActive 
                            from Users as U inner join People as P
                            on U.PersonID = P.PersonID
                            order by U.UserID;";
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
        //public static User FindUser(int UserID)
        //{
        //    string query = @"select * from Users where UserID = @userID;";
        //    using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
        //    using (SqlCommand command = new SqlCommand(query, connection))
        //    {
        //        command.Parameters.AddWithValue("@userID", UserID);
        //        try
        //        {
        //            connection.Open();
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    int personID = (int)reader["PersonID"];
        //                    return new User(
        //                        UserID,
        //                        personID,
        //                        People_DataAccess.FindPerson(personID),
        //                        reader["UserName"] as string ?? "",
        //                        reader["Password"] as string ?? "",
        //                        (bool)reader["IsActive"]
        //                        );
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Error: " + ex.Message);
        //        }
        //    }
        //    return null;

        //}
        public static User FindUser(int UserID)
        {
            // 1. The JOIN query fetches all columns from both tables at exactly the same time.
            string query = @"SELECT * 
                     FROM Users 
                     INNER JOIN People ON Users.PersonID = People.PersonID 
                     WHERE Users.UserID = @userID;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userID", UserID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 2. Extract the shared PersonID
                            int personID = (int)reader["PersonID"];

                            // 3. Construct the People object manually using the joined columns
                            People personInfo = new People(
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

                            // 4. Construct the User object and inject the fully built People object into it
                            return new User(
                                UserID,
                                personID,
                                personInfo,
                                reader["UserName"] as string ?? "",
                                reader["Password"] as string ?? "",
                                (bool)reader["IsActive"]
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
        public static User FindUser(string userName , string password)
        {
            
            string query = @"SELECT * 
                     FROM Users 
                     INNER JOIN People ON Users.PersonID = People.PersonID 
                     where UserName =@userName and Password = @password";
;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 2. Extract the shared PersonID
                            int personID = (int)reader["PersonID"];

                            // 3. Construct the People object manually using the joined columns
                            People personInfo = new People(
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

                            // 4. Construct the User object and inject the fully built People object into it
                            return new User(
                                (int)reader["UserID"],
                                personID,
                                personInfo,
                                userName,
                                password,
                                (bool)reader["IsActive"]
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

        public static int AddNewUser(User user)
        {
            int newUserID = -1;

            string query = @"INSERT INTO Users (PersonID,UserName, Password, IsActive)
                            Values(@personID,@userName ,@password,@isActive);
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@personID", user.PersonID);
                command.Parameters.AddWithValue("@userName", user.UserName);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@isActive", user.IsActive);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        newUserID = insertedID;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:" + ex.Message);
                }
            }
            return newUserID;
        }
        public static bool UpdateUser(User user)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Users
                            SET UserName = @userName,
                            Password = @password,
                            IsActive = @isActive
                            WHERE UserID = @userID;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userID", user.UserID);
                command.Parameters.AddWithValue("@userName", user.UserName);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@isActive", user.IsActive);

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
        //public static bool UpdatePassword(User user)
        //{
        //    int rowsAffected = 0;
        //    string query = @"UPDATE Users
        //                    SET Password = @password,
        //                    WHERE UserID = @userID;";

        //    using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
        //    using (SqlCommand command = new SqlCommand(query, connection))
        //    {
        //        command.Parameters.AddWithValue("@userID", user.UserID);
        //        command.Parameters.AddWithValue("@password", user.Password);

        //        try
        //        {
        //            connection.Open();
        //            rowsAffected = command.ExecuteNonQuery();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Error" + ex.Message);
        //        }
        //    }
        //    return rowsAffected > 0;

        //}
        public static bool DeleteUser(int userID)
        {
            int rowsAffected = 0;
            string query = "delete Users where UserID = @userID";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userID", userID);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:" + ex.Message);
                }
            }
            return rowsAffected > 0;


        }
        public static bool IsPersonAUser(int personID)
        {
            bool isFound = false;
            string query = "select 1 from Users where PersonID = @personID;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@personID", personID);

                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        isFound = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:" + ex.Message);
                }
            }
            return isFound;
        }
        public static bool ChangePassword(int userID,string newPassword)
        {
            int rowsAffected = 0;
            string query = @"update Users set Password = @password
                             where UserID =@userID";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userID", userID);
                command.Parameters.AddWithValue("@password", newPassword);
                

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
