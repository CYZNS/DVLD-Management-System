using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Models
{
    public class People
    {
        public int PersonID { get;  set; }
        public string NationalID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        // 0 for male , 1 for female , 2 unknown ( maybe enum here) 
        public byte Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }

        public People(int personID, string nationalID, string firstName, string secondName, string thirdName,
            string lastName, DateTime dateOfBirth, byte gender, string address, string phone, string email,
            int nationalityCountryID, string imagePath)
        {
            this.PersonID = personID;
            this.NationalID = nationalID;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.NationalityCountryID = nationalityCountryID;
            this.ImagePath = imagePath;
        }
        public People() : this(-1, "", "", "", "", "", DateTime.Now, 2, "", "", "", -1, "")
        {

        }
    }
}
