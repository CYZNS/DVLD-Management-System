using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Models
{
    public class TestType
    {
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }

        public decimal TestTypeFees { get; set; }


        public TestType(int TestTypeID, string TestTypeTitle, decimal TestTypeFees,string TestTypeDescription)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeFees = TestTypeFees;
            this.TestTypeDescription = TestTypeDescription;
        }

    }
}
