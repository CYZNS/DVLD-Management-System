using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Models
{
    public class Licenses
    {
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClassID { get; set; }
        public LicenseClass licenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public string IsActiveAsString
        {
            get
            {
                return (IsActive == true) ? "Yes" : "No";
            }
        }


        //1-FirstTime, 2-Renew, 3-Replacement for Damaged, 4- Replacement for Lost.
        public int IssueReason { get; set; }
        public string IssueReasonAsString
        {
            get
            {
                switch(IssueReason)
                {
                    case 1:
                        return "First Time";
                    case 2:
                        return "Renew";
                    case 3:
                        return "Replacement for Damaged";
                    case 4:
                        return "Replacement for Lost";
                    default:
                        return "Error";
                }
            }
        }
        public int UserID { get; set; }

        // Constructor 1: Used ONLY by DataAccess.Find() (Takes all exact DB values)
        public Licenses(int LicenseID, int ApplicationID, int DriverID, int licenseClassID, LicenseClass licenseClass, DateTime IssueDate, DateTime ExpirationDate, string notes, decimal PaidFees,bool isActive, int IssueReason, int UserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClassID = licenseClassID;
            this.licenseClass = licenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate; // Uses the exact DB date!
            this.Notes = notes;
            this.PaidFees = PaidFees;
            this.IsActive = isActive;
            this.IssueReason = IssueReason;
            this.UserID = UserID;
        }
        // Constructor 2: Used ONLY for creating NEW Licenses
        public Licenses(int ApplicationID, int DriverID,LicenseClass licenseClass, string notes, int IssueReason, int UserID)
        {
            this.LicenseID = -1;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClassID = licenseClass.LicenseClassID;
            this.licenseClass = licenseClass;

            this.IssueDate = DateTime.Now;
            this.ExpirationDate = this.IssueDate.AddYears(this.licenseClass.DefaultValidityLength);

            this.Notes = notes;
            this.PaidFees = licenseClass.ClassFees;
            this.IsActive = true;
            this.IssueReason = IssueReason;
            this.UserID = UserID;
        }

        
    }
}
