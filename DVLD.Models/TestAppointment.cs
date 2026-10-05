using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Models
{
    public class TestAppointment
    {
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int UserID { get; set; }
        public bool isLocked { get; set; }
        public int RetakeTestID { get; set; }


        public TestAppointment(int testAppointmentID, int testTypeID, int localDrivingApplicationID, DateTime appointmentDate, decimal paidFees, int userID, bool isLocked, int retakeTestID)
        {
            TestAppointmentID = testAppointmentID;
            TestTypeID = testTypeID;
            LocalDrivingApplicationID = localDrivingApplicationID;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            UserID = userID;
            this.isLocked = isLocked;
            RetakeTestID = retakeTestID;
        }
        public TestAppointment(int testAppointmentID, int testTypeID, int localDrivingApplicationID, DateTime appointmentDate, decimal paidFees, int userID, bool isLocked)
        {
            TestAppointmentID = testAppointmentID;
            TestTypeID = testTypeID;
            LocalDrivingApplicationID = localDrivingApplicationID;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            UserID = userID;
            this.isLocked = isLocked;
            RetakeTestID = -1; // Default value for RetakeTestID if not provided
        }

        public TestAppointment() : this(-1, -1, -1, DateTime.Now, 0.00m, -1, false, -1)
        {

        }
    }
}
