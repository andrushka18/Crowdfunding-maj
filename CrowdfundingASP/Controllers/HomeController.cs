using CrowdfundingASP.Models;
using CrowdfundingASP.Services;
using CrowdfundingASP.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace CrowdfundingASP.Controllers
{
    public class HomeController : Controller
    {
        private UtilisateurAspRep _service = new UtilisateurAspRep();
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
            if (ModelState.IsValid)
            {

                foreach (Utilisateur u in _service.Get().Where(b => b.NomUtilisateur == cu.NomUtilisateur))
                {
                    if ( u != null)
                    {

                        if (cu.NomUtilisateur == u.NomUtilisateur && cu.Password == u.Password)
                        {
                            _service.Add(u);
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

        [HttpGet]
        // GET: Home/Delete/5
        public ActionResult SignOut()
        {
            Utilisateur u = null;
            return RedirectToAction("Index");
        }


        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult ToggleUser(int id)
        {
            
                Utilisateur u = UtilisateurAspRep.Entity.Get(id);
                UtilisateurAspRep.Entity.Update(id, u);
                return RedirectToAction("ListUtilisateur");
            
            
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