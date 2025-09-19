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
    public class EmployeAspRep : IEmployeRep<int, Employe>
    {
        private static IEmployeRep<int, Employe> _entity;
        public static IEmployeRep<int, Employe> Entity
        {
            get { return _entity ?? (_entity = new EmployeAspRep()); }
        }
        private IEmployeRep<int, CrowdDAL.Employe> _fromDalrepos;
        public EmployeAspRep()
        {
            _fromDalrepos = new CrowdDALS.EmployeASPRep();
        }
        
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