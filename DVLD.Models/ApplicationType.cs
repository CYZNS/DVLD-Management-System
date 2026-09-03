using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Models
{
    public class ApplicationType
    {
        public int ApplicationID { get; set; }
        public string ApplicationTitle { get; set; }
        public decimal ApplicationFees { get; set; }


        public ApplicationType(int ApplicationID, string ApplicationTitle,decimal ApplicationFees)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicationTitle = ApplicationTitle;
            this.ApplicationFees = ApplicationFees;
        }



    }
}
