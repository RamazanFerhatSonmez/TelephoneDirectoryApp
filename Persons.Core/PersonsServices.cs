using System;
using System.Collections.Generic;

namespace Persons.Core
{
    public class PersonsServices : IPersonsServices
    {

        List<Persons> IPersonsServices.GetPersons()
        {
            return new List<Persons>
           {
                new Persons
                {
                    Name = "Mehmet",
                    Surname = "Sönmez",
                    Company = "Getir"
                }
           };
        }
    }
}
