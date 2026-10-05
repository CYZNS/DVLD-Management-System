using DVLD.Models;
using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class TestBusiness
    {
        public static DataTable GetAllTests()
        {
            return TestDataAccess.GetAllTests();
        }

        public static Test FindTest(int testID)
        {
            return TestDataAccess.FindTest(testID);
        }

        public static bool SaveTest(Test test)
        {
            if (test.TestID == -1)
            {
                test.TestID = TestDataAccess.AddNewTest(test);

                return (test.TestID != -1);
            }
            else
            {
                
                return false;
            }
        }

        public static bool DoesFailOnTestType(int localDrivingLicenseApplicationID, int testTypeID)
        {
            return TestDataAccess.DoesFailOrPassOnTestType(localDrivingLicenseApplicationID, testTypeID,0);
        }
        public static bool DoesPassOnTestType(int localDrivingLicenseApplicationID, int testTypeID)
        {
            return TestDataAccess.DoesFailOrPassOnTestType(localDrivingLicenseApplicationID, testTypeID, 1);
        }
        
        public static int TotalTrialsPerTestType(int localDrivingLicenseApplicationID, int testTypeID)
        {
            return TestDataAccess.TotalTrialsPerTestType(localDrivingLicenseApplicationID, testTypeID);
        }
    }
}
