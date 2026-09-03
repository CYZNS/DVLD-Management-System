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
    public class CountriesBusiness
    {
        public static DataTable getAllCountries()
        {
            return Countries_DataAccess.GetAllCountries();
        }
        public static Country findCountry(int countryID)
        {
            Country country = Countries_DataAccess.FindCountry(countryID);

            return (country == null) ? null : country;
        }
        


    }
}
