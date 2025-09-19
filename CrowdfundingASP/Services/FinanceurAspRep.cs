using DALAspCrowdfunding.Repositories;
using System.Collections.Generic;
using System.Linq;
using CrowdfundingASP.Models;
using CrowdfundingASP.Usefulls;
using CrowdDAL = DALAspCrowdfunding.Models;
using CrowdDALS = DALAspCrowdfunding.Repositories;
using FundingASP = CrowdfundingASP.Models;


namespace CrowdfundingASP.Services
{
    public class FinanceurAspRep : IFinanceurRep<int, Financeur>
    {
        private static IFinanceurRep<int, Financeur> _entity;
        public static IFinanceurRep<int, Financeur> Entity
        {
            get { return _entity ?? (_entity = new FinanceurAspRep()); }
        }
        private IFinanceurRep<int, CrowdDAL.Financeur> _fromDalrepos;
        public FinanceurAspRep()
        {
            _fromDalrepos = new CrowdDALS.FinanceurASPRep();
        }
        
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