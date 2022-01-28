using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Report.Microservice.Controllers
{
    public class ReportServiceController : Controller
    {
        // GET: ReportServiceController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReportServiceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReportServiceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReportServiceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReportServiceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReportServiceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReportServiceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReportServiceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
