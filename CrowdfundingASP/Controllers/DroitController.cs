using CrowdfundingASP.Models;
using CrowdfundingASP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrowdfundingASP.Controllers
{
    [Authorize]
    public class DroitController : Controller
    {
        private DroitAspRep _service = new DroitAspRep();
        // GET: Droit
        public ActionResult Index()
        {
            var D = _service.Get();
            return View(D);
        }
        // GET: api/Droit
        [HttpGet]


        public ActionResult ListDroit()
        {
            var D = _service.Get();
            return View(D);
        }

        // GET: Droit/5
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
        // POST: Droit
        [HttpPost]

        
        public ActionResult Ajouter(Droit role)
        {
             _service.Add(role); 
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var D = _service.Get(id);
            return View(D);
        }
        // PUT: /Droit/5
        [HttpPut]

        public ActionResult Edit(int id, Droit role)
        {
            _service.Update(id, role); 
            return RedirectToAction("Index");
        }

        //[HttpGet]
        public ActionResult Delete(int id)
        {
            var D = _service.Get(id);
            return View(D);
        }

        // DELETE: Droit/5
        //[HttpDelete]
        [HttpPost]
        public ActionResult Delete(int id, Droit role)
        {
            _service.Delete(id); 
            return RedirectToAction("Index");
        }

    }
}