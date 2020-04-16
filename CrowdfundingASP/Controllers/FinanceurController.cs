using CrowdfundingASP.Models;
using CrowdfundingASP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrowdfundingASP.Controllers
{
    public class FinanceurController : Controller
    {
        private FinanceurAspRep _service = new FinanceurAspRep();
        // GET: Financeur
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]

        public ActionResult Listfinancement()
        {
             var F=_service.Get();
            return View(F);
        }

        [HttpGet]

        public ActionResult Details(int id)
        {
            var F= _service.Get(id);
            return View(id);
        }

        [HttpPost]
        public ActionResult Add(Financeur fin)
        {
            _service.Add(fin);
            return View(fin);
        }

        [HttpPut]
        public ActionResult Edit(int id, Financeur fin)
        {
            _service.Update(id, fin);
            return View(id);
            
        }


        [HttpDelete]
        public ActionResult Delete(int id)
        {
            _service.Delete(id);
            return View(id);

        }

    }
}