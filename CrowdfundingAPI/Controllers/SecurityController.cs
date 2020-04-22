using CrowdfundingAPI.Models;
using CrowdfundingAPI.Services;
using CrowdfundingAPI.ViewModels;
using System.Web.Http;
using ToolBox.JWT;

namespace CrowdfundingAPI.Controllers
{
    [RoutePrefix("api")]

    public class SecurityController : ApiController
    {
        [Route("NomUtilisateur")]
        [HttpPost]
        public IHttpActionResult NomUtilisateur(Utilisateur model)
        {
            UtilisateurService _service = new UtilisateurService();
             int id=_service.Check(model.NomUtilisateur, model.Password);
            // //string role = _service.Check(model.NomUtilisateur, model.Password);
            //if (id == 0 && role =="Utilisateur")
            //{
            //    return Unauthorized;
            //}
            //else
            
                Models.Utilisateur u = _service.Get(id);
                JWTService service = new JWTService(
                     "Tn!_bTZ&Gt^7LM&X!HxnTT6H",
                     "localhost",
                     "postman"
                 );
                return Ok(service.Encode(u));
            

        }
    }
}
