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
    public class SocieteService : ISocieteRepository<int, FundingAPI.Societe>
    {
        private ISocieteRepository<int, CrowdDALX.Societe> _repos = new SocieteRepository();

        public void Add(FundingAPI.Societe entity)
        {
            _repos.Add(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _repos.Delete(id);
        }

        public IEnumerable<FundingAPI.Societe> Get()
        {
            return _repos.Get().Select(a => a.ToAPI());
        }

        public FundingAPI.Societe Get(int id)
        {
            return _repos.Get(id).ToAPI();
        }

        public void Update(int id, FundingAPI.Societe entity)
        {
            _repos.Update(id, entity.ToDAL());
        }
    }
}