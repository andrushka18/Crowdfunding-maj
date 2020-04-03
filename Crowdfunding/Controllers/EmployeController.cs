using Crowdfunding.Models;
using Crowdfunding.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace Crowdfunding.Controllers
{
    [RoutePrefix("api")]
    public class EmployeController : ApiController
    {
        private EmployeService _service = new EmployeService();

        [AcceptVerbs("GET")]
        [Route("Employe")]
        public IEnumerable<Employe> RetrieveAll()
        {
            return _service.Get();
        }

        [AcceptVerbs("GET")]
        [Route("Employe/{id}")]
        public Employe Retrieve(int id)
        {
            return _service.Get(id);
        }

        [AcceptVerbs("PUT")]
        [Route("Secure/Employe/{id}")]
        public void ChangeInfo(int id, Employe emp)
        {
            _service.Update(id, emp);
        }
    }
}