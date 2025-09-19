using CrowdDALX = DAL_Crowdfunding.Models;
using FundingAPI = CrowdfundingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using CrowdfundingAPI.Services.Mapper;
using DAL_Crowdfunding.Repositories;

namespace CrowdfundingAPI.Services
{
    public class PalierService : IPalierRepository<int, FundingAPI.Palier>
    {
        private IPalierRepository<int, CrowdDALX.Palier> _repos = new PalierRepository();

        public void Add(FundingAPI.Palier entity)
        {
            _repos.Add(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _repos.Delete(id);
        }

        public IEnumerable<FundingAPI.Palier> Get()
        {
            return _repos.Get().Select(a => a.ToAPI());
        }

        public FundingAPI.Palier Get(int id)
        {
            return _repos.Get(id).ToAPI();
        }

        public void Update(int id, FundingAPI.Palier entity)
        {
            _repos.Update(id, entity.ToDAL());
        }
    }
}