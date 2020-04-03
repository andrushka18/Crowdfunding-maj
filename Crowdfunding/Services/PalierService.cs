using CrowdDALX = DAL_Crowdfunding.Models;
using FundingAPI = Crowdfunding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Crowdfunding.Services.Mapper;
using DAL_Crowdfunding.Repositories;
using Crowdfunding.Models;

namespace Crowdfunding.Services
{
    public class PalierService : IPalierRepository<int, FundingAPI.Palier>
    {
        private IPalierRepository<int, CrowdDALX.Palier> _repos = new PalierRepository();

        public void Add(Palier entity)
        {
            _repos.Add(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _repos.Delete(id);
        }

        public IEnumerable<Palier> Get()
        {
            return _repos.Get().Select(a => a.ToAPI());
        }

        public Palier Get(int id)
        {
            return _repos.Get(id).ToAPI();
        }

        public void Update(int id, Palier entity)
        {
            _repos.Update(id, entity.ToDAL());
        }
    }
}