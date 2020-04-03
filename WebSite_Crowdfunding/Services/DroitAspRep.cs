using DALAspCrowdfunding.Repositories;
using System.Collections.Generic;
using System.Linq;
using WebSite_Crowdfunding.Models;
using WebSite_Crowdfunding.Usefulls;
using CrowdDAL = DALAspCrowdfunding.Models;
using CrowdDALS = DALAspCrowdfunding.Repositories;
using FundingASP = WebSite_Crowdfunding.Models;


namespace WebSite_Crowdfunding.Services
{
    public class DroitAspRep : IDroitRep<int, Droit>
    {
        private static IDroitRep<int, Droit> _entity;
        public static IDroitRep<int, Droit> Entity
        {
            get { return _entity ?? (_entity = new DroitAspRep()); }
        }
        private DroitAspRep()
        {
            _fromDalrepos = new CrowdDALS.DroitASPRep();
        }
        private IDroitRep<int, CrowdDAL.Droit> _fromDalrepos;

        public void Add(FundingASP.Droit entity)
        {
            _fromDalrepos.Add(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _fromDalrepos.Delete(id);
        }

        public IEnumerable<Droit> Get()
        {
            return _fromDalrepos.Get().Select(c => c.ToASP());
        }

        public Droit Get(int id)
        {
            return _fromDalrepos.Get(id)?.ToASP();
        }

      

        public void Update(int id, FundingASP.Droit entity)
        {
            _fromDalrepos.Update(id, entity.ToDAL());
        }
    }


}