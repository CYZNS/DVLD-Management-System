using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Models
{
    public class ApplicationModel
    {
        public int ApplicationID { get; set; }
        public int PersonID { get; set; }
        public People Person { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public ApplicationType applicationType { get; set; }
        public int ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int UserID { get; set; }
        //public User user { get; set; }


        //public ApplicationModel(int applicationID, int personID, People person, DateTime applicationDate,
        //   int applicationTypeID, ApplicationType applicationType, int applicationStatus,
        //   DateTime lastStatusDate, decimal paidFees, int userID)
        //{
        //    this.ApplicationID = applicationID;
        //    this.PersonID = personID;
        //    this.Person = person;
        //    this.ApplicationDate = applicationDate;
        //    this.ApplicationTypeID = applicationTypeID;
        //    this.applicationType = applicationType;
        //    this.ApplicationStatus = applicationStatus;
        //    this.LastStatusDate = lastStatusDate;
        //    this.PaidFees = paidFees;
        //    this.UserID = userID;
        //    //this.user = user;
        //}

        public ApplicationModel(int applicationID, int personID, People person, DateTime applicationDate,
           int applicationTypeID, ApplicationType applicationType, int applicationStatus,
           DateTime lastStatusDate, decimal paidFees, int userID)
        {
            this.ApplicationID = applicationID;
            this.PersonID = personID;
            this.Person = person;
            this.ApplicationDate = applicationDate;
            this.ApplicationTypeID = applicationTypeID;
            this.applicationType = applicationType;
            this.ApplicationStatus = applicationStatus;
            this.LastStatusDate = lastStatusDate;
            this.PaidFees = paidFees;
            this.UserID = userID;
        }

        public ApplicationModel() : this(-1, -1, null, DateTime.Now, -1, null, -1, DateTime.Now, (decimal)0.00, -1)
        {

        }

    }
}
