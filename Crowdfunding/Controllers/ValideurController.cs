using Crowdfunding.Models;
using Crowdfunding.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace Crowdfunding.Controllers
{
    [RoutePrefix("api")]
    public class ValideurController : ApiController
    {
        private ValideurService _service = new ValideurService();

        [AcceptVerbs("GET")]
        [Route("Validation")]
        public IEnumerable<Valideur> RetrieveAll()
        {
            return _service.Get();
        }

        [AcceptVerbs("GET")]
        [Route("Validation/{id}")]
        public Valideur Retrieve(int id)
        {
            return _service.Get(id);
        }

        [AcceptVerbs("PUT")]
        [Route("Secure/Validation/{id}")]
        public void ChangeInfo(int id, Valideur valide)
        {
            _service.Update(id, valide);
        }
    }
}
