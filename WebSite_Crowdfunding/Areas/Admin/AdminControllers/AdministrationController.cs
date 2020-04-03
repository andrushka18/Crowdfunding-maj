using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite_Crowdfunding.Models;
using WebSite_Crowdfunding.Services;
using WebSite_Crowdfunding.Usefulls;

namespace WebSite_Crowdfunding.Areas.Admin.AdminControllers
{
    
        public class AdministrationController : Controller

        {
            // GET: Admin/Admin
            public ActionResult Index()
            {
                if (SessionTool.utilisateur != null && SessionTool.utilisateur.IsAdmin == true)
                {
                    return View();
                }
                else return RedirectToAction("../");
            }

            public ActionResult ListProjet()
            {
                if (SessionTool.utilisateur != null && SessionTool.utilisateur.IsAdmin == true)
                {
                    return View(ProjetAspRep.Entity.Get());
                }
                else return RedirectToAction("../");
            }

            public ActionResult DetailProjet(int id)
            {
                if (SessionTool.utilisateur != null && SessionTool.utilisateur.IsAdmin == true)
                {
                    return View(ProjetAspRep.Entity.Get(id));
                }
                else return RedirectToAction("../");
            }
            [HttpGet]
            public ActionResult EditerProjet(int id)
            {
                if (SessionTool.utilisateur != null && SessionTool.utilisateur.IsAdmin == true)
                {
                    return View(ProjetAspRep.Entity.Get(id));
                }
                else return RedirectToAction("../");
            }

            public ActionResult DesactiverProjet(Projet projo)
            {
                if (ModelState.IsValid)
                {
                    if (SessionTool.utilisateur != null && SessionTool.utilisateur.IsAdmin == true)
                    {
                        return RedirectToAction("ListeProjet");
                    }
                    else return RedirectToAction("../");
                }
                else return View(projo);
            }

            public ActionResult ListeUtilisateur()
            {
                if (SessionTool.utilisateur != null && SessionTool.utilisateur.IsAdmin == true)
                {
                    return View(UtilisateurAspRep.Entity.Get());
                }
                else return RedirectToAction("../");
            }

            public ActionResult ListeUtilisateur(int id)
            {
                if (SessionTool.utilisateur != null && SessionTool.utilisateur.IsAdmin == true)
                {
                    Utilisateur uUpdate = UtilisateurAspRep.Entity.Get(id);
                    uUpdate.IsActive = !uUpdate.IsActive;
                    UtilisateurAspRep.Entity.Update(id, uUpdate);
                    return RedirectToAction("ListeUtilisateur");
                }
                else return RedirectToAction("../");
            }
        }
    
}