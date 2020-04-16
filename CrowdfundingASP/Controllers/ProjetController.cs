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
            return View();
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
        [HttpPost]

        public ActionResult Ajouter(Projet projet)
        {
            _service.Add(projet);
            return View(projet);
        }

        // PUT: 
        [HttpPut]

        public ActionResult Edit(int id, Projet projet)
        {
            _service.Update(id, projet);
            return View(id);
        }

        [HttpDelete]
        // DELETE: 
        public ActionResult Delete(int id)
        {
            _service.Delete(id);
            return View(id);
        }
    }

}
