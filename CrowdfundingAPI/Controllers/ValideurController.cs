using System.Collections.Generic;
using System.Web.Http;
using CrowdfundingAPI.Models;
using CrowdfundingAPI.Services;

namespace CrowdfundingAPI.Controllers
{
    [RoutePrefix("api")]
    public class ValideurController : ApiController
    {
       

        private ValideurService _service = new ValideurService();
        // GET: api/Valideur
        [AcceptVerbs("GET")]
        [Route("valideur")]
        
        public IEnumerable<Valideur> Get()
        {
            return _service.Get(); ;
        }

        // GET: api/Valideur/5
        [AcceptVerbs("GET")]
        [Route("valideur/{id}")]
        
        public Valideur Get(int id)
        {
            return _service.Get(id);
        }

        // POST: api/Valideur
        [AcceptVerbs("POST")]
        [Route("secure/valideur")]
        
        public void Add([FromBody]Valideur valide)
        {
            _service.Add(valide);
        }

        // PUT: api/Valideur/5
        [AcceptVerbs("PUT")]
        [Route("secure/valideur")]
        
        public void Update(int id, [FromBody]Valideur valide)
        {
            _service.Update(id, valide);
        }

        // DELETE: api/Valideur/5
        [AcceptVerbs("DELETE")]
        [Route("secure/valideur")]
        
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
