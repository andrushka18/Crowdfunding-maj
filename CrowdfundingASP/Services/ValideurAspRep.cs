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
    public class ValideurAspRep : IValideurRep<int, Valideur>
    {
        private static IValideurRep<int, Valideur> _entity;
        public static IValideurRep<int, Valideur> Entity
        {
            get { return _entity ?? (_entity = new ValideurAspRep()); }
        }
        private IValideurRep<int, CrowdDAL.Valideur> _fromDalrepos;
        public ValideurAspRep()
        {
            _fromDalrepos = new CrowdDALS.ValideurASPRep();
        }
        
        public void Add(FundingASP.Valideur entity)
        {
            _fromDalrepos.Add(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _fromDalrepos.Delete(id);
        }

        public IEnumerable<FundingASP.Valideur> Get()
        {
            return _fromDalrepos.Get().Select(a => a.ToASP());
        }

        public FundingASP.Valideur Get(int id)
        {
            return _fromDalrepos.Get(id).ToASP();
        }

        public void Update(int id, FundingASP.Valideur entity)
        {
            _fromDalrepos.Update(id, entity.ToDAL());
        }
    }
}