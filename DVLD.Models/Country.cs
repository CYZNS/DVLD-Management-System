using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Models
{
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public Country()
        {
            this.CountryID = -1;
            this.CountryName = "";
        }

        public Country(int countryID, string countryName)
        {
            this.CountryID = countryID;
            this.CountryName = countryName;
        }
        
    }
}
