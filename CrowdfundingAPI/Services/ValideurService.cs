using CrowdDALX = DAL_Crowdfunding.Models;
using FundingAPI = CrowdfundingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using CrowdfundingAPI.Services.Mapper;
using DAL_Crowdfunding.Repositories;
using CrowdfundingAPI.Models;

namespace CrowdfundingAPI.Services
{
    public class ValideurService : IValideurRepository<int, FundingAPI.Valideur>
    {
        private IValideurRepository<int, CrowdDALX.Valideur> _repos = new ValideurRepository();

        public void Add(FundingAPI.Valideur entity)
        {
            _repos.Add(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _repos.Delete(id);
        }

        public IEnumerable<FundingAPI.Valideur> Get()
        {
            return _repos.Get().Select(a => a.ToAPI());
        }

        public FundingAPI.Valideur Get(int id)
        {
            return _repos.Get(id).ToAPI();
        }

        public void Update(int id, FundingAPI.Valideur entity)
        {
            _repos.Update(id, entity.ToDAL());
        }
    }
}