using CrowdfundingASP.Models;
using CrowdfundingASP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrowdfundingASP.Controllers
{
    public class EmployeController : Controller
    {
        private EmployeAspRep _service = new EmployeAspRep();
        // GET: Employe
        public ActionResult Index()
        {
            var D = _service.Get();
            return View(D);
        }

        [HttpGet]
        
        public ActionResult ListEmploye()
        {
            var Employe = _service.Get();
            return View(Employe);
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            var Employe =_service.Get(id);
            return View(Employe);
        }


        [HttpGet]
        public ActionResult Add()
        {
            var D = _service.Get();
            return View(D);
        }

        [HttpPost]

        public ActionResult Add(Employe employe)
        {
             _service.Add(employe); 
            return RedirectToAction("Index");
        }



        [HttpGet]
        public ActionResult Edit(int id)
        {
            var D = _service.Get(id);
            return View(D);
        }

        [HttpPut]

        public ActionResult Edit(int id, Employe employe)
        {
            _service.Update(id, employe);
            return RedirectToAction("Index");
        }



        [HttpGet]
        public ActionResult Delete(int id, Employe employe)
        {
            var D = _service.Get(id);
            return View(D);
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            _service.Delete(id); 
            return RedirectToAction("Index");
        }
    }


}
