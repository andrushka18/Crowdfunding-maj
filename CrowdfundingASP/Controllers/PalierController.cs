using CrowdfundingASP.Models;
using CrowdfundingASP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrowdfundingASP.Controllers
{
    public class PalierController : Controller
    {
        private PalierAspRep _service = new PalierAspRep();
      
        public ActionResult Index()
        {
            var D = _service.Get();
            return View(D);
        }
      
        [HttpGet]
        public ActionResult ListDroit()
        {
            var D = _service.Get();
            return View(D);
        }

       
        [HttpGet]
        public ActionResult Details(int id)
        {
            var D = _service.Get(id);
            return View(D);
        }

        [HttpGet]
        public ActionResult Ajouter()
        {
            var D = _service.Get();
            return View(D);
        }
       
        [HttpPost]
        public ActionResult Ajouter(Palier don)
        {
            _service.Add(don);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var D = _service.Get(id);
            return View(D);
        }
        
        [HttpPut]

        public ActionResult Edit(int id, Palier don)
        {
            _service.Update(id, don);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var D = _service.Get(id);
            return View(D);
        }

       
        [HttpDelete]
     
        public ActionResult Delete(int id, Palier don)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}