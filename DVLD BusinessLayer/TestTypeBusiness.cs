using DVLD.Models;
using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class TestTypeBusiness
    {

        public static DataTable getAllTestTypes()
        {
            return TestTypesDataAccess.getAllTestTypes();
        }

        public static bool updateTestType(TestType testType)
        {
            return TestTypesDataAccess.updateTestType(testType);
        }

        public static TestType FindTestType(int TestTypeID)
        {
            TestType testType = TestTypesDataAccess.FindTestType(TestTypeID);
            return (testType == null) ? null : testType;
        }


    }
}
