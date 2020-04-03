using Crowdfunding.Models;
using Crowdfunding.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace Crowdfunding.Controllers
{
    [RoutePrefix("api")]
    public class ProjetController : ApiController
    {
        private ProjetService _service = new ProjetService();

        [AcceptVerbs("GET")]
        [Route("Projet")]
        public IEnumerable<Projet> RetrieveAll()
        {
            return _service.Get();
        }

        [AcceptVerbs("GET")]
        [Route("Projet/{id}")]
        public Projet Retrieve(int id)
        {
            return _service.Get(id);
        }

        [AcceptVerbs("PUT")]
        [Route("Secure/Projet/{id}")]
        public void ChangeInfo(int id, Projet projo)
        {
            _service.Update(id, projo);
        }
    }
}
