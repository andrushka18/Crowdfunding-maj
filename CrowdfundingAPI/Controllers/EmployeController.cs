using CrowdfundingAPI.Models;
using CrowdfundingAPI.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace CrowdfundingAPI.Controllers
{
    [RoutePrefix("api")]
    public class EmployeController : ApiController
    {
        
        private EmployeService _service = new EmployeService();

        [AcceptVerbs("GET")]
        [Route("employe")]
        
        // GET: api/Employe
        public IEnumerable<Employe> Get()
        {
            return _service.Get();
        }

        [AcceptVerbs("GET")]
        [Route("employe/{id}")]
       

        // GET: api/Employe/5
        public Employe Get(int id)
        {
            return _service.Get(id); 
        }

        // POST: api/Employe
        [AcceptVerbs("POST")]
        [Route("secure/employe")]
       
        public void Add(Employe employe)
        {
            _service.Add(employe);
        }

        // PUT: api/Employe/5
        [AcceptVerbs("PUT")]
        [Route("secure/employe")]
       
        public void Update(int id, [FromBody]Employe employe)
        {
            _service.Update(id, employe);
        }

        [AcceptVerbs("DELETE")]
        [Route("secure/employe")]
        
        // DELETE: api/Employe/5
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
