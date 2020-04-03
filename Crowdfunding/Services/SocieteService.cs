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
    public class SocieteService : ISocieteRepository<int, FundingAPI.Societe>
    {
        private ISocieteRepository<int, CrowdDALX.Societe> _repos = new SocieteRepository();

        public void Add(Societe entity)
        {
            _repos.Add(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _repos.Delete(id);
        }

        public IEnumerable<Societe> Get()
        {
            return _repos.Get().Select(a => a.ToAPI());
        }

        public Societe Get(int id)
        {
            return _repos.Get(id).ToAPI();
        }

        public void Update(int id, Societe entity)
        {
            _repos.Update(id, entity.ToDAL());
        }
    }
}