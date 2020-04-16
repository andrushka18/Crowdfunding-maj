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
    public class ProjetAspRep : IProjetRep<int, Projet>
    {
        private static IProjetRep<int, Projet> _entity;
        public static IProjetRep<int, Projet> Entity
        {
            get { return _entity ?? (_entity = new ProjetAspRep()); }
        }
        private IProjetRep<int, CrowdDAL.Projet> _fromDalrepos;
        public ProjetAspRep()
        {
            _fromDalrepos = new CrowdDALS.ProjetASPRep();
        }

        public void Add(FundingASP.Projet entity)
        {
            _fromDalrepos.Add(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _fromDalrepos.Delete(id);
        }

        public IEnumerable<FundingASP.Projet> Get()
        {
            return _fromDalrepos.Get().Select(a => a.ToASP());
        }

        public FundingASP.Projet Get(int id)
        {
            return _fromDalrepos.Get(id).ToASP();
        }

        public void Update(int id, FundingASP.Projet entity)
        {
            _fromDalrepos.Update(id, entity.ToDAL());
        }
    }
}