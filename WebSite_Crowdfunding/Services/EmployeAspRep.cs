using CrowdDAL = DALAspCrowdfunding.Models;
using FundingASP = WebSite_Crowdfunding.Models;

using System.Collections.Generic;
using System.Linq;
using WebSite_Crowdfunding.Models;
using WebSite_Crowdfunding.Usefulls;
using CrowdDALS = DALAspCrowdfunding.Repositories;
using DALAspCrowdfunding.Repositories;

namespace WebSite_Crowdfunding.Services
{
    public class EmployeAspRep : IEmployeRep<int, Employe>
    {
        private static IEmployeRep<int, Employe> _entity;
        public static IEmployeRep<int, Employe> Entity
        {
            get { return _entity ?? (_entity = new EmployeAspRep()); }
        }
        private EmployeAspRep()
        {
            _fromDalrepos = new CrowdDALS.EmployeASPRep();
        }
        private IEmployeRep<int, CrowdDAL.Employe> _fromDalrepos;
        public void Add(FundingASP.Employe entity)
        {
            _fromDalrepos.Add(entity.ToDAL());
        }
        
        public void Delete(int id)
        {
            _fromDalrepos.Delete(id);
        }

        public IEnumerable<FundingASP.Employe> Get()
        {
            return _fromDalrepos.Get().Select(a => a.ToASP());
        }

        public FundingASP.Employe Get(int id)
        {
            return _fromDalrepos.Get(id).ToASP();
        }

        public void Update(int id, FundingASP.Employe entity)
        {
            _fromDalrepos.Update(id, entity.ToDAL());
        }
    }
}