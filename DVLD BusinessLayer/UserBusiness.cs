using DVLD_DataAccessLayer;
using DVLD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;

namespace DVLD_BusinessLayer
{
    public class UserBusiness
    {
        public static DataTable GetAllUsers()
        {
            return UsersDataAccess.listUsers();
        }
        public static DataTable getAllUsersWithPersonFullName()
        {
            return UsersDataAccess.listUsersWithPersonFullName();
        }
        public static User FindUser(int userID)
        {
            User user = UsersDataAccess.FindUser(userID);
            return (user == null) ? null : user;
        }
        public static User FindUser(string userName , string password)
        {
            User user = UsersDataAccess.FindUser(userName, password);
            return (user == null) ? null : user;
        }
        public static bool IsPersonAUser(int personID)
        {
            return UsersDataAccess.IsPersonAUser(personID);
        }
        public static bool DeleteUser(int userID)
        {
            return UsersDataAccess.DeleteUser(userID);
        }
        private static bool AddNewUser(User user)
        {
            user.UserID = UsersDataAccess.AddNewUser(user);
            return user.UserID != -1;
        }
        private static bool UpdateUser(User user)
        {
            return UsersDataAccess.UpdateUser(user);
        }
        public static bool ChangePassword(int userID,string newpassword)
        {
            if(newpassword.Length>=4)
            {
                UsersDataAccess.ChangePassword(userID, newpassword);
                return true;
            }
            else
                return false;

        }
        public static bool Save(User user)
        {
            if (user.UserID == -1)
                return AddNewUser(user);
            else
                return UpdateUser(user);
        }


    }
}
