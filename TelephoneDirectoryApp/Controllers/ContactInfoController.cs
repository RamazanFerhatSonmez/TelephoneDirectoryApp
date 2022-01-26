using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelephoneDirectoryApp.Models;

namespace TelephoneDirectoryApp.Controllers
{
    public class ContactInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactInfo info)
        {
            return View();
        }
    }
}
