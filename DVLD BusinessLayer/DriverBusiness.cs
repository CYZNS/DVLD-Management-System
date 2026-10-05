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
    public class DriverBusiness
    {

        public static DataTable GetAllDrivers()
        {
            return DriverDataAccess.GetAllDrivers();
        }
        public static Driver FindDriverByPersonID(int personID)
        {
            return DriverDataAccess.FindDriverByPersonID(personID);
        }
        public static Driver FindDriverByDriverID(int driverID)
        {
            return DriverDataAccess.FindDriverByDriverID(driverID);
        }
        public static bool AddDriver(Driver driver)
        {
            driver.DriverID = DriverDataAccess.AddDriver(driver);
            return driver.DriverID != -1;
        }





    }
}
