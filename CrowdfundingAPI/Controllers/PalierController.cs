using CrowdfundingAPI.Models;
using CrowdfundingAPI.Services;
using System.Collections.Generic;
using System.Web.Http;


namespace CrowdfundingAPI.Controllers
{
    
        [RoutePrefix("api")]
        public class PalierController : ApiController
        {
            private PalierService _service = new PalierService();

            [AcceptVerbs("GET")]
            [Route("Palier")]

            public IEnumerable<Palier> Get()
            {
                return _service.Get();
            }

            [AcceptVerbs("GET")]
            [System.Web.Http.Route("palier/{id}")]

            public Palier Get(int id)
            {
                var don = _service.Get(id);
                return don;
            }
            
            [AcceptVerbs("POST")]
            [Route("secure/Palier")]

            public void Add([FromBody]Palier don)
            {
                _service.Add(don);
            }

            // PUT: api/Palier/5
            [AcceptVerbs("PUT")]
            [System.Web.Http.Route("secure/Palier")]

            public void Update([FromBody]int id, Palier don)
            {
                _service.Update(id, don);
            }

            // DELETE: api/secure/Palier/5
            [AcceptVerbs("DELETE")]
            [Route("secure/Palier")]

            public void Delete(int id)
            {
                _service.Delete(id);
            }

        }
    }

