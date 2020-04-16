using CrowdfundingASP.Models;
using CrowdfundingASP.Services;
using CrowdfundingASP.ViewModels;
using sun.security.util;
using System.Web.Mvc;
using ToolBox.JWT;

namespace CrowdfundingASP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Inscription()
        {
            ViewBag.Message = "Pas encore de compte, inscrivez-vous";

            return View(new InscriptionUtilisateur());
        }
        [HttpPost]
        public ActionResult Inscription(InscriptionUtilisateur iu)
        {
            UtilisateurAspRep _service = new UtilisateurAspRep();
            {
                _service.Add(iu);
            }
            return View(iu);
        }

        [HttpGet]
        public ActionResult NomUtilisateur()
        {
            ViewBag.Message = "Deja un compte, connectez-vous";
            return View(new CompteUtilisateur());
        }
        [HttpPost]
        public ActionResult NomUtilisateur(CompteUtilisateur cu)
        {
             UtilisateurAspRep _service = new UtilisateurAspRep();
            { 
                _service.Check(cu.NomUtilisateur, cu.Password);
            }
            return View(cu);
            
        }



        public ActionResult About()
        {
            ViewBag.Message = "Description de Crowdfunding.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contactez-Nous.";

            return View();
        }

    }
}