using CrowdfundingASP.Models;
using CrowdfundingASP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrowdfundingASP.Controllers
{
    public class ProjetController : Controller
    {
        private ProjetAspRep _service = new ProjetAspRep();
        // GET: Projet
        public ActionResult Index()
        {
            var D = _service.Get();
            return View(D);
        }

        [HttpGet]
        // GET:
        public ActionResult ListProjet()
        {
            var p = _service.Get();
            return View(p);
        }

        [HttpGet]
        // GET:
        public ActionResult Details(int id)
        {
            var p= _service.Get(id);
            return View(p); 
        }

        // POST:

        [HttpGet]
        public ActionResult Add()
        {
            var D = _service.Get();
            return View(D);
        }

        [HttpPost]

        public ActionResult Add(Projet projo)
        {
            _service.Add(projo);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var D = _service.Get(id);
            return View(D);
        }

        [HttpPut]

        public ActionResult Edit(int id, Projet projo)
        {
            _service.Update(id, projo);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Delete(int id, Projet projo)
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
