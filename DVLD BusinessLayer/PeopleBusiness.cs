using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccessLayer;
using DVLD.Models;

namespace DVLD_BusinessLayer
{
    public class PeopleBusiness
    {

        public static DataTable getAllPeople()
        {
            return People_DataAccess.listPeople();
        }
        public static People FindPerson(int personID)
        {
            People person = People_DataAccess.FindPerson(personID);
            
            return (person == null) ? null : person;
        }
        public static People FindPerson(string nationalNumber)
        {
            People person = People_DataAccess.FindPerson(nationalNumber);

            return (person == null) ? null : person;
        }
        public static bool deletePerson(int personID)
        {
            return People_DataAccess.deletePerson(personID);
        }
        public static bool isPersonExistsByNationalNo(string nationalNo)
        {
            return People_DataAccess.isPersonExistsByNationalNo(nationalNo);
        }
        private static bool addPerson(People person)
        {
            person.PersonID = People_DataAccess.addNewPerson(person);

            return person.PersonID != -1;
        }
        private static bool updatePerson(People person)
        {
            return People_DataAccess.updatePerson(person);
        }    
        public static bool savePerson(People person)
        {
            if(person.PersonID == -1)
                return addPerson(person);
            
            else
                return updatePerson(person);
        }
        
        

    }
}
