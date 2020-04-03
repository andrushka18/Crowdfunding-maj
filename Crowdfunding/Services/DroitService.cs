using CrowdDALX = DAL_Crowdfunding.Models;
using FundingAPI = Crowdfunding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Crowdfunding.Services.Mapper;
using DAL_Crowdfunding.Repositories;

namespace Crowdfunding.Services
{
    public class DroitService : IDroitRepository<int, FundingAPI.Droit>
    {
        private IDroitRepository<int, CrowdDALX.Droit> _repos = new DroitRepository();

        public void Add(FundingAPI.Droit entity)
        {
            _repos.Add(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _repos.Delete(id);
        }

        public IEnumerable<FundingAPI.Droit> Get()
        {
            return _repos.Get().Select(a => a.ToAPI());
        }

        public FundingAPI.Droit Get(int id)
        {
            return _repos.Get(id).ToAPI();
        }

       

        public void Update(int id, FundingAPI.Droit entity)
        {
            _repos.Update(id, entity.ToDAL());
        }
    }
}