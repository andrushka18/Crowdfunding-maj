using CrowdDALX = DAL_Crowdfunding.Models;
using FundingAPI = Crowdfunding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Crowdfunding.Services.Mapper;
using DAL_Crowdfunding.Repositories;

namespace Crowdfunding.Services
{
    public class FinanceurService : IFinanceurRepository<int, FundingAPI.Financeur>
    {
        private IFinanceurRepository<int, CrowdDALX.Financeur> _repos = new FinanceurRepository();

        public void Add(FundingAPI.Financeur entity)
        {
            _repos.Add(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _repos.Delete(id);
        }

        public IEnumerable<FundingAPI.Financeur> Get()
        {
            return _repos.Get().Select(a => a.ToAPI());
        }

        public FundingAPI.Financeur Get(int id)
        {
            return _repos.Get(id).ToAPI();
        }

        public void Update(int id, FundingAPI.Financeur entity)
        {
            _repos.Update(id, entity.ToDAL());
        }
    }
}