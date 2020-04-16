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
            return View();
        }
        [HttpGet]
        //public IEnumerable<Employe> ListEmploye()
        //{
        //    return _service.Get();
        //}
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

        [HttpPost]

        public ActionResult Add(Employe employe)
        {
            _service.Add(employe);
            return View();
        }

        [HttpPut]

        public ActionResult Edit(int id, Employe employe)
        {
           _service.Update(id, employe);
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
