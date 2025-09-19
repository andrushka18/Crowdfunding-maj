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
    public class DroitAspRep : IDroitRep<int, Droit>
    {
        private static IDroitRep<int, Droit> _entity;
        public static IDroitRep<int, Droit> Entity
        {
            get { return _entity ?? (_entity = new DroitAspRep()); }
        }

        private IDroitRep<int, CrowdDAL.Droit> _fromDalrepos;
        public  DroitAspRep()
        {
            _fromDalrepos = new CrowdDALS.DroitASPRep();
        }
        

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