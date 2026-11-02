using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Models
{
    public class InternationalLicenses
    {

        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int UserID { get; set; }
        public InternationalLicenses(int InternationalLicenseID,int applicationID, int driverID, int localLicenseID, DateTime issueDate, DateTime expirationDate, bool isActive, int userID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            LocalLicenseID = localLicenseID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            UserID = userID;
        }
        public InternationalLicenses() : this(-1, -1, -1, -1, DateTime.Now, DateTime.Now.AddYears(1), true, -1)
        {
            
        }

    }
}
