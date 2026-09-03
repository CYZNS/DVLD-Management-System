using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Models
{
    public class User
    {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public People Person;   
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }


        public User(int UserID ,int personID, People person, string UserName,string Password,bool isActive)
        {
            this.UserID = UserID;
            this.Person = person;
            this.PersonID = personID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = isActive;
        }

        public User(int personID, People person1) : this(-1,personID, person1, "", "", false)
        {

        }


    }
}
