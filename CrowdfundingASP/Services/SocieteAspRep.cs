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
    public class SocieteAspRep : ISocieteRep<int, Societe>
    {
        private static ISocieteRep<int, Societe> _entity;
        public static ISocieteRep<int, Societe> Entity
        {
            get { return _entity ?? (_entity = new SocieteAspRep()); }
        }
        private ISocieteRep<int, CrowdDAL.Societe> _fromDalrepos;
        public SocieteAspRep()
        {
            _fromDalrepos = new CrowdDALS.SocieteASPRep();
        }
        
        public void Add(FundingASP.Societe entity)
        {
            _fromDalrepos.Add(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _fromDalrepos.Delete(id);
        }

        public IEnumerable<FundingASP.Societe> Get()
        {
            return _fromDalrepos.Get().Select(a => a.ToASP());
        }

        public FundingASP.Societe Get(int id)
        {
            return _fromDalrepos.Get(id).ToASP();
        }

        public void Update(int id, FundingASP.Societe entity)
        {
            _fromDalrepos.Update(id, entity.ToDAL());
        }
    }
}