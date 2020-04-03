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
    public class ProjetAspRep : IProjetRep<int, Projet>
    {
        private static IProjetRep<int, Projet> _entity;
        public static IProjetRep<int, Projet> Entity
        {
            get { return _entity ?? (_entity = new ProjetAspRep()); }
        }
        private IProjetRep<int, CrowdDAL.Projet> _fromDalrepos;
        private ProjetAspRep()
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