using Crowdfunding.Models;
using Crowdfunding.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace Crowdfunding.Controllers
{
    [RoutePrefix("api")]
    public class FinanceurController : ApiController
    {
        private FinanceurService _service = new FinanceurService();

        [AcceptVerbs("GET")]
        [Route("Financement")]
        public IEnumerable<Financeur> RetrieveAll()
        {
            return _service.Get();
        }

        [AcceptVerbs("GET")]
        [Route("Financement/{id}")]
        public Financeur Retrieve(int id)
        {
            return _service.Get(id);
        }

        [AcceptVerbs("PUT")]
        [Route("Secure/Financement/{id}")]
        public void ChangeInfo(int id, Financeur fin)
        {
            _service.Update(id, fin);
        }
    }
}
