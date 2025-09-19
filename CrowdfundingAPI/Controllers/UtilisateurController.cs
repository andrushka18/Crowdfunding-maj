using CrowdfundingAPI.Models;
using CrowdfundingAPI.Services;
using CrowdfundingAPI.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace CrowdfundingAPI.Controllers
{
    [RoutePrefix("api")]
    public class UtilisateurController : ApiController
    {

        private UtilisateurService _service = new UtilisateurService();
        // GET: api/Utilisateur
        [AcceptVerbs("GET")]
        [Route("Utilisateur")]
        [HttpGet]
        public IEnumerable<Utilisateur> Get()
        {
            return _service.Get();
        }

        // GET: api/Utilisateur/5
        [AcceptVerbs("GET")]
        [Route("Utilisateur/{id}")]
        [HttpGet]
        public Utilisateur Get(int id)
        {
            return _service.Get(id);
        }

        // POST: api/Utilisateur
        [AcceptVerbs("POST")]
        [Route("Utilisateur")]
        [HttpPost]
        public void Registration([FromBody]Utilisateur u)
        {
            _service.Add(u);
        }


        [AcceptVerbs("PUT")]
        [Route("Secure/Utilisateur")]
        [HttpPut]
        public void ChangePassword(int id, string password)
        {
            _service.ChangePassword(id, password);
        }
        // PUT: api/Utilisateur/5
        [AcceptVerbs("PUT")]
        [Route("Secure/Utilisateur")]
        [HttpPut]
        public void Update(int id, [FromBody]Utilisateur utilisateur)
        {
            _service.Update(id, utilisateur);
        }

        // DELETE: api/Utilisateur/5
        [AcceptVerbs("DELETE")]
        [Route("Secure/Utilisateur/{id}/setAdmin")]
        [HttpPut]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
        [AcceptVerbs("PUT", "POST")]
        [Route("Secure/Utilisateur/{id}/setAdmin")]
        [HttpPost]
        public void SetAdmin(int id)
        {
            _service.SetAdmin(id);
        }

        [AcceptVerbs("PUT", "POST")]
        [Route("Secure/Utilisateur/{id}/unsetAdmin")]
        [HttpPost]
        public void UnsetAdmin(int id)
        {
            _service.UnsetAdmin(id);
        }

    }
}

