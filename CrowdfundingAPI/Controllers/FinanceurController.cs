using CrowdfundingAPI.Models;
using CrowdfundingAPI.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace CrowdfundingAPI.Controllers
{
    [RoutePrefix("api")]
    public class FinanceurController : ApiController
    {
        
        private FinanceurService _service = new FinanceurService();

        [AcceptVerbs("GET")]
        [Route("financeur")]
        
        // GET: api/Financeur
        public IEnumerable<Financeur> Get()
        {
            return _service.Get();
        }

        // GET: api/Financeur/5
        [AcceptVerbs("GET")]
        [Route("financeur/{id}")]
        public Financeur Get(int id)
        {
            return _service.Get(id);
        }

        // POST: api/Financeur
        [AcceptVerbs("POST")]
        [Route("secure/financeur")]
        public void Add([FromBody]Financeur fin)
        {
            _service.Add(fin);
        }

        // PUT: api/Financeur/5
        [AcceptVerbs("PUT")]
        [Route("secure/financeur")]
        public void Update(int id, [FromBody]Financeur fin)
        {
            _service.Update(id, fin);
        }

        // DELETE: api/Financeur/5
        [AcceptVerbs("DELETE")]
        [Route("secure/financeur")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
