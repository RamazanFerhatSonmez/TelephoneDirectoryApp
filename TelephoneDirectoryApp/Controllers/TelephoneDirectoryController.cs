using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Persons.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelephoneDirectoryApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TelephoneDirectoryController : ControllerBase
    {

        private readonly IPersonsServices _personsServices;
        public TelephoneDirectoryController(IPersonsServices personServices)
        {
            _personsServices = personServices;

        }
        [HttpGet]
        public IActionResult GetPersons ()
        {
            return Ok(_personsServices.GetPersons());
        }
    }
}
