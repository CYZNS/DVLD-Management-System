using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Models
{
    public class Drivers
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        People person;
        public int UserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public Drivers()
        {
            DriverID = -1;
            PersonID = -1;
            UserID = -1;
            CreatedDate = DateTime.Now;
        }
        public Drivers(int driverID, int personID,People person, int userID, DateTime createdDate)
        {
            DriverID = driverID;
            PersonID = personID;
            this.person = person;
            UserID = userID;
            CreatedDate = createdDate;
        }
    }
}
