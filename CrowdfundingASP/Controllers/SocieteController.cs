using CrowdfundingASP.Models;
using CrowdfundingASP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrowdfundingASP.Controllers
{
    public class SocieteController : Controller
    {
        private SocieteAspRep _service = new SocieteAspRep();
        
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


        public ActionResult Ajouter(Societe firm)
        {
            _service.Add(firm);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var D = _service.Get(id);
            return View(D);
        }
        
        [HttpPut]

        public ActionResult Edit(int id, Societe firm)
        {
            _service.Update(id, firm);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var D = _service.Get(id);
            return View(D);
        }

        
        //[HttpDelete]
        [HttpPost]
        public ActionResult Delete(int id, Societe firm)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}