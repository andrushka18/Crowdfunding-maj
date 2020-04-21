using CrowdfundingASP.Models;
using CrowdfundingASP.Services;
using CrowdfundingASP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrowdfundingASP.Controllers
{
    public class UtilisateurController : Controller
    {
        private UtilisateurAspRep _service = new UtilisateurAspRep();

        // GET: Utilisateur
        public ActionResult Index()
        {
            var D = _service.Get();
            return View(D);
        }
        // GET: 
        [AcceptVerbs("GET")]

        [HttpGet]
        public ActionResult ListUtilisateur()
        {
            var user=_service.Get();
            return View(user);
        }

        // GET: Utilisateur
        [AcceptVerbs("GET")]

        [HttpGet]
        public ActionResult Details(int id)
        {
            var user = _service.Get(id);
            return View(user);
        }

        // POST: Utilisateur

        [HttpGet]
        public ActionResult ChangePassword(int id)
        {
            var D = _service.Get(id);
            return View(D);
        }

        [HttpPut]
        public ActionResult ChangePassword(int id, string password)
        {
            _service.ChangePassword(id, password); 
            return RedirectToAction("Index");
        }
       
        [HttpGet]
        public ActionResult ChangeInfo(int id)
        {
            var D = _service.Get(id);
            return View(D);
        }
        // PUT: Utilisateur/5

        [HttpPut]
        public ActionResult ChangeInfo(int id, Utilisateur utilisateur)
        {
            _service.Update(id, utilisateur);
            return RedirectToAction("Index");
        }


        // DELETE: Utilisateur/5


        [HttpGet]
        public ActionResult Delete(int id, Utilisateur u)
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

        [AcceptVerbs("PUT", "POST")]

        [HttpPost]
        public void SetAdmin(int id)
        {
            _service.SetAdmin(id);
        }

        [AcceptVerbs("PUT", "POST")]

        [HttpPost]
        public void UnsetAdmin(int id)
        {
            _service.UnsetAdmin(id);
        }

    }
}