using DVLD.Models;
using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class TestAppointmentBusiness
    {
        public static DataTable GetAllTestAppointmentsForTestTypeForLocalDrivingApplication(int testTypeIDlocalDrivingApplicationID, int testTypeID)
        {
            return TestAppointmentDataAccess.GetAllTestAppointmentsForTestTypeForLocalDrivingApplication(testTypeIDlocalDrivingApplicationID, testTypeID);
        }
        public static TestAppointment FindTestAppointment(int testAppointmentID)
        {
            return TestAppointmentDataAccess.FindTestAppointment(testAppointmentID);
        }
        public static bool HasActiveAppointment(int localDrivingApplicationID, int testTypeID)
        {
            return TestAppointmentDataAccess.HasActiveAppointment(localDrivingApplicationID, testTypeID);
        }
        private static bool AddTestAppointment(TestAppointment testAppointment)
        {
            testAppointment.TestAppointmentID = TestAppointmentDataAccess.AddNewAppointment(testAppointment);
            return testAppointment.TestAppointmentID != -1;
        }
        private static bool UpdateTestAppointment(TestAppointment testAppointment)
        {
            return TestAppointmentDataAccess.UpdateTestAppointment(testAppointment);
        }
        public static bool SaveTestAppointment(TestAppointment testAppointment)
        {
            if (testAppointment.TestAppointmentID == -1)
                return AddTestAppointment(testAppointment);
            else
                return UpdateTestAppointment(testAppointment);
        }

        public static bool LockTestAppointment(int TestAppointmentID)
        {
            return TestAppointmentDataAccess.LockTestAppointment(TestAppointmentID);
        }

    }
}