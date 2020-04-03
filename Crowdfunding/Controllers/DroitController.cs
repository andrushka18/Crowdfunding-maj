using Crowdfunding.Models;
using Crowdfunding.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace Crowdfunding.Controllers
{
    [RoutePrefix("api")]
    public class DroitController : ApiController
    {
        private DroitService _service = new DroitService();

        [AcceptVerbs("GET")]
        [Route("Droit")]
        public IEnumerable<Droit> RetrieveAll()
        {
            return _service.Get();
        }

        [AcceptVerbs("GET")]
        [Route("Droit/{id}")]
        public Droit Retrieve(int id)
        {
            return _service.Get(id);
        }

        [AcceptVerbs("PUT")]
        [Route("Secure/Droit/{id}")]
        public void ChangeInfo(int id, Droit role)
        {
            _service.Update(id, role);
        }

       
    }
}