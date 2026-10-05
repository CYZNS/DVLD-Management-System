using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Models
{
    public class Driver
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public People personInfo { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public Driver()
        {
            DriverID = -1;
            PersonID = -1;
            UserID = -1;
            CreatedDate = DateTime.Now;
        }
        public Driver(int driverID, int personID,People personInfo,int userID, DateTime createdDate) // personInfo will be filled in the business layer
        {
            DriverID = driverID;
            PersonID = personID;
            UserID = userID;
            CreatedDate = createdDate;
            this.personInfo = personInfo;
        }
        public Driver(int driverID, int personID, int userID, DateTime createdDate) // personInfo will be filled in the business layer
        {
            DriverID = driverID;
            PersonID = personID;
            UserID = userID;
            CreatedDate = createdDate;
        }
    }
}
