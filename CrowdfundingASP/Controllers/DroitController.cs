using CrowdfundingASP.Models;
using CrowdfundingASP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrowdfundingASP.Controllers
{
    public class DroitController : Controller
    {
        private DroitAspRep _service = new DroitAspRep();
        // GET: Droit
        public ActionResult Index()
        {
            return View();
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
        // POST: Droit
        [HttpPost]

        public ActionResult Ajouter(Droit role)
        {
            { _service.Add(role); }
            
            return View(role);
        }

        // PUT: /Droit/5
        [HttpPut]

        public ActionResult Edit(int id, Droit role)
        {
            { _service.Update(id, role); }
            return View(id);
        }

        // DELETE: Droit/5
        [HttpDelete]

        public ActionResult Delete(int id)
        {
            { _service.Delete(id); }
            return View(id);
        }

    }
}