using DALAspCrowdfunding.Repositories;
using CrowdDALS = DALAspCrowdfunding.Repositories;
using CrowdDAL = DALAspCrowdfunding.Models;
using System.Collections.Generic;
using System.Linq;
using WebSite_Crowdfunding.Models;
using FundingASP = WebSite_Crowdfunding.Models;
using WebSite_Crowdfunding.Usefulls;

namespace WebSite_Crowdfunding.Services
{
    public class FinanceurAspRep : IFinanceurRep<int, Financeur>
    {
        private static IFinanceurRep<int, Financeur> _entity;
        public static IFinanceurRep<int, Financeur> Entity
        {
            get { return _entity ?? (_entity = new FinanceurAspRep()); }
        }
        private FinanceurAspRep()
        {
            _fromDalrepos = new CrowdDALS.FinanceurASPRep();
        }
        private IFinanceurRep<int, CrowdDAL.Financeur> _fromDalrepos;
        public void Add(FundingASP.Financeur entity)
        {
            _fromDalrepos.Add(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _fromDalrepos.Delete(id);
        }

        public IEnumerable<FundingASP.Financeur> Get()
        {
            return _fromDalrepos.Get().Select(a => a.ToASP());
        }

        public FundingASP.Financeur Get(int id)
        {
            return _fromDalrepos.Get(id).ToASP();
        }

        public void Update(int id, FundingASP.Financeur entity)
        {
            _fromDalrepos.Update(id, entity.ToDAL());
        }
    }
}