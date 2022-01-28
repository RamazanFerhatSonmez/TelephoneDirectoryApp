using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Contact.Api.Controllers
{
    public class ContactServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
