using CrowdfundingAPI.Models;
using CrowdfundingAPI.Services;
using System.Collections.Generic;
using System.Web.Http;


namespace CrowdfundingAPI.Controllers
{
    [RoutePrefix("api")]
    public class SocieteController : ApiController
    {
            private SocieteService _service = new SocieteService();
                   
            [AcceptVerbs("GET")]
            [Route("Societe")]

            public IEnumerable<Societe> Get()
            {
                return _service.Get();
            }

            
            [AcceptVerbs("GET")]
            [Route("Societe/{id}")]

            public Societe Get(int id)
            {
                var firm = _service.Get(id);
                return firm;
            }
          
            [AcceptVerbs("POST")]
            [Route("secure/Societe")]

            public void Add([FromBody]Societe firm)
            {
                _service.Add(firm);
            }

            
            [AcceptVerbs("POST")]
            [Route("secure/Societe")]

            public void Update([FromBody]int id, Societe firm)
            {
                _service.Update(id, firm);
            }

            
            [AcceptVerbs("DELETE")]
            [Route("secure/Societe")]

            public void Delete(int id)
            {
                _service.Delete(id);
            }

    }
}