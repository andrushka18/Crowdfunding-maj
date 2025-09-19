using CrowdfundingAPI.Models;
using CrowdfundingAPI.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace CrowdfundingAPI.Controllers
{
    [RoutePrefix("api")]
    public class ProjetController : ApiController
    {
       

        private ProjetService _service = new ProjetService();

        [AcceptVerbs("GET")]
        [Route("projet")]
        
        // GET: api/Projet
        public IEnumerable<Projet> Get()
        {
            return _service.Get();
        }
        [AcceptVerbs("GET")]
        [Route("projet/{id}")]
        

        // GET: api/Projet/5
        public Projet Get(int id)
        {
            return _service.Get(id); ;
        }

        // POST: api/Projet
        [AcceptVerbs("POST")]
        [Route("secure/projet")]
        
        public void Add([FromBody]Projet projet)
        {
            _service.Add(projet);
        }

        // PUT: api/Projet/5
        [AcceptVerbs("PUT")]
        [Route("secure/Projet")]
        
        public void Update(int id, [FromBody]Projet projet)
        {
            _service.Update(id, projet);
        }

        [AcceptVerbs("DELETE")]
        [Route("secure/projet")]
        
        // DELETE: api/Projet/5
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
