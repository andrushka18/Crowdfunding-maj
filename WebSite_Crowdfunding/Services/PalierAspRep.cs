using DALAspCrowdfunding.Repositories;
using CrowdDALS = DALAspCrowdfunding.Repositories;
using System.Collections.Generic;
using System.Linq;
using WebSite_Crowdfunding.Models;
using WebSite_Crowdfunding.Usefulls;
using CrowdDAL = DALAspCrowdfunding.Models;
using FundingASP = WebSite_Crowdfunding.Models;

namespace WebSite_Crowdfunding.Services
{
    public class PalierAspRep : IPalierRep<int, Palier>
    {
        private static IPalierRep<int, Palier> _entity;
        public static IPalierRep<int, Palier> Entity
        {
            get { return _entity ?? (_entity = new PalierAspRep()); }
        }
        private IPalierRep<int, CrowdDAL.Palier> _fromDalrepos;
        private PalierAspRep()
        {
            _fromDalrepos = new CrowdDALS.PalierASPRep();
        }
        public void Add(FundingASP.Palier entity)
        {
            _fromDalrepos.Add(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _fromDalrepos.Delete(id);
        }

        public IEnumerable<FundingASP.Palier> Get()
        {
            return _fromDalrepos.Get().Select(a => a.ToASP());
        }

        public FundingASP.Palier Get(int id)
        {
            return _fromDalrepos.Get(id).ToASP();
        }

        public void Update(int id, FundingASP.Palier entity)
        {
            _fromDalrepos.Update(id, entity.ToDAL());
        }
    }
}