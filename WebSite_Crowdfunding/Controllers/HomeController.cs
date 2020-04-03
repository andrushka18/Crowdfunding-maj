using System.Linq;
using System.Web.Mvc;
using WebSite_Crowdfunding.Models;
using WebSite_Crowdfunding.Usefulls;
using WebSite_Crowdfunding.Services;
using WebSite_Crowdfunding.ViewModels;
using DALAspCrowdfunding.Repositories;

namespace WebSite_Crowdfunding.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inscription()
        {
            ViewBag.Message = "Pas encore de compte, inscrivez-vous";

            return View(new InscriptionUtilisateur());
        }

        public ActionResult Inscription(InscriptionUtilisateur iu)
        {
            ViewBag.Message = "Inscription.";
            if (ModelState.IsValid)
            {
                UtilisateurAspRep.Entity.Add(iu.SignInToUser());
                return RedirectToAction("Index");
            }
            return View(iu);
        }
        public ActionResult SignOut()
        {
            SessionTool.utilisateur = null;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult NomUtilisateur()
        {
            return View(new CompteUtilisateur());
        }

       public ActionResult NomUtilisateur(CompteUtilisateur cu)
        {
            if (ModelState.IsValid)
            {

                foreach (Utilisateur u in UtilisateurAspRep.Entity.Get().Where(b => b.NomUtilisateur == cu.NomUtilisateur))
                {
                    if (u.IsActive)
                    {

                        if (cu.NomUtilisateur == u.NomUtilisateur && cu.Password == u.Password)
                        {
                            SessionTool.utilisateur = u;
                            return RedirectToAction("Index");
                        }

                        else
                        {
                            ViewBag.ErrorMessage = "Nom utilisateur ou mot de passe Incorrect";
                            return View(cu);
                        }
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Votre compte est desactivé";
                        return View("Index");
                    }
                }
                return RedirectToAction("Index");
            }
            else return View(cu);

        }

        public ActionResult ListeProjet()
        {
            return View(ProjetAspRep.Entity.Get());
        }

        public ActionResult ProjetDetails(int id)
        {
            if (SessionTool.utilisateur != null)
            {
                return View(ProjetAspRep.Entity.Get(id));
            }
            else return RedirectToAction("Index");

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