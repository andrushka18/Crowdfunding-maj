using CrowdDALX = DAL_Crowdfunding.Models;
using FundingAPI = CrowdfundingAPI.Models;
using System.Collections.Generic;
using System.Linq;
using CrowdfundingAPI.Services.Mapper;
using DAL_Crowdfunding.Repositories;

namespace CrowdfundingAPI.Services
{
    public class UtilisateurService : IUtilisateurRepository<int, FundingAPI.Utilisateur>
    {
        private IUtilisateurRepository<int, CrowdDALX.Utilisateur> _repos = new UtilisateurRepository();
        public void Add(FundingAPI.Utilisateur entity)
        {
            _repos.Add(entity.ToDAL());
        }

        public void ChangePassword(int id, string Password)
        {
            _repos.ChangePassword(id, Password);
        }

        public int Check(string NomUtilisateur, string Password)
        {
            return _repos.Check(NomUtilisateur, Password);
        }

        public void Delete(int id)
        {
            _repos.Delete(id);
        }

        public IEnumerable<FundingAPI.Utilisateur> Get()
        {
            return _repos.Get().Select(a => a.ToAPI());
        }

        public FundingAPI.Utilisateur Get(int id)
        {
            return _repos.Get(id).ToAPI();
        }

        public void Update(int id, FundingAPI.Utilisateur entity)
        {
            _repos.Update(id, entity.ToDAL());
        }
        public void SetAdmin(int id)
        {
            _repos.SetAdmin(id);
        }

        public void UnsetAdmin(int id)
        {
            _repos.UnsetAdmin(id);
        }

        public void Registration(FundingAPI.Utilisateur entity)
        {
            _repos.Registration(entity.ToDAL()); 
        }
    }
}