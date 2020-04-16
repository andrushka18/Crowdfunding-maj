using CrowdfundingAPI.Models;
using CrowdfundingAPI.Services;
using System.Collections.Generic;
using System.Web.Http;


namespace CrowdfundingAPI.Controllers
{
    [RoutePrefix("api")]
    public class DroitController : ApiController
    {
        
        private DroitService _service = new DroitService();

        

        // GET: api/Droit
        [AcceptVerbs("GET")]
        [Route("droit")]
        
        public IEnumerable<Droit> Get()
        {
            return _service.Get();
        }

        // GET: api/Droit/5
        [AcceptVerbs("GET")]
        [Route("droit")]
        
        public Droit Get(int id)
        {
            return _service.Get(id);
        }
        // POST: api/Droit
        [AcceptVerbs("POST")]
        [Route("secure/droit")]

        public void Add([FromBody]Droit role)
        {
            _service.Add(role);
        }

        // PUT: api/Droit/5
        [AcceptVerbs("PUT")]
        [Route("secure/droit")]

        public void Update([FromBody]int id, Droit role)
        {
            _service.Update(id, role);
        }

        // DELETE: api/secure/Droit/5
        [AcceptVerbs("DELETE")]
        [Route("secure/droit")]

        public void Delete(int id)
        {
            _service.Delete(id);
        }

    }
}
