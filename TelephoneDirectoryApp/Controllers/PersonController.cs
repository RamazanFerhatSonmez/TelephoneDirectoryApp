using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelephoneDirectoryApp.Models;

namespace TelephoneDirectoryApp.Controllers
{
    public class PersonController : Controller
    {
        private MongoClient client = new MongoClient("mongodb://localhost:27017");
        
        public IActionResult Index()
        {
            var database = client.GetDatabase("TelephoneDirectoryDb");
            var tablePerson = database.GetCollection<Person>("Persons");
            var persons = tablePerson.Find(persons => true).ToList();

            return View(persons);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            var database = client.GetDatabase("TelephoneDirectoryDb");
            var table = database.GetCollection<Person>("Persons");
            person.UUID = Guid.NewGuid().ToString();
            table.InsertOne(person);
            ViewBag.Mgs = "Person has been saved.";
            return RedirectToAction("Index");
        }
        public IActionResult CreateContact(string uuId)
        {
            return View(uuId); ;
        }
        public IActionResult Delete( String id)
        {
            var database = client.GetDatabase("TelephoneDirectoryDb");
            var table = database.GetCollection<Person>("Persons");
            var person = table.Find(p => p.UUID == id).FirstOrDefault();
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }
        [HttpPost]
        public IActionResult Delete(Person person)
        {
            var database = client.GetDatabase("TelephoneDirectoryDb");
            var table = database.GetCollection<Person>("Persons");
            table.DeleteOne(p => p.UUID == person.UUID);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult CreateContact(ContactInfo contactInfo, string id)
        {
            var database = client.GetDatabase("TelephoneDirectoryDb");
            var table = database.GetCollection<ContactInfo>("ContactInfo");
            contactInfo.personUUID = id;
            contactInfo.Id = null;
            table.InsertOne(contactInfo);
            ViewBag.Mgs = "Person Contact Info has been saved.";
            return RedirectToAction("Index");
        }
    }
}
