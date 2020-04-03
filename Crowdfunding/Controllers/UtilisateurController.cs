using Crowdfunding.Models;
using Crowdfunding.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace Crowdfunding.Controllers
{
    [RoutePrefix("api")]
    public class UtilisateurController : ApiController
    {
        private UtilisateurService _service = new UtilisateurService();

        [AcceptVerbs("GET")]
        [Route("Utilisateur")]
        public IEnumerable<Utilisateur> RetrieveAll()
        {
            return _service.Get();
        }

        [AcceptVerbs("POST")]
        [Route("Secure/Utilisateur")]
        public void Register(Utilisateur user)
        {
            _service.Add(user);
        }

        [AcceptVerbs("PUT")]
        [Route("Secure/Utilisateur")]
        public void ChangePassword(int id, string password)
        {
            _service.ChangePassword(id, password);
        }


        [AcceptVerbs("GET")]
        [Route("Utilisateur/{id}")]
        public Utilisateur Retrieve(int id)
        {
            return _service.Get(id);
        }

        [AcceptVerbs("PUT")]
        [Route("Secure/Utilisateur/{id}")]
        public void ChangeInfo(int id, Utilisateur user)
        {
            _service.Update(id, user);
        }
        [AcceptVerbs("PUT", "POST")]
        [Route("Secure/Utilisateur/{id}/SetAdmin")]
        public void SetAdmin(int id)
        {
            _service.SetAdmin(id);
        }

        [AcceptVerbs("PUT", "POST")]
        [Route("Secure/Utilisateur/{id}/UnsetAdmin")]
        public void UnsetAdmin(int id)
        {
            _service.UnsetAdmin(id);
        }
    }
}
