using CrowdfundingASP.Models;
using CrowdfundingASP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrowdfundingASP.Controllers
{
    public class ValideurController : Controller
    {
        private ValideurAspRep _service = new ValideurAspRep();
        // GET: Valideur
        public ActionResult Index()
        {
            var D = _service.Get();
            return View(D);
        }
        // GET: /Valideur
        [HttpGet]

        public ActionResult Get()
        {
            var D = _service.Get();
            return View(D);

        }

        // GET: Valideur/5
        [HttpGet]

        public ActionResult Get(int id)
        {
            var D = _service.Get(id);
            return View(D);

        }

        // POST: api/Valideur
        [HttpGet]
        public ActionResult Add()
        {
            var D = _service.Get();
            return View(D);
        }

        [HttpPost]

        public ActionResult Add(Valideur valide)
        {
            _service.Add(valide);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var D = _service.Get(id);
            return View(D);
        }

        [HttpPut]

        public ActionResult Edit(int id, Valideur valide)
        {
            _service.Update(id, valide);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Delete(int id, Valideur valide)
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