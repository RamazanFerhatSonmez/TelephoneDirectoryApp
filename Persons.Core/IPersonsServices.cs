using System;
using System.Collections.Generic;
using System.Text;

namespace Persons.Core
{
    public interface IPersonsServices
    {
        List<Persons> GetPersons();
    }
}
