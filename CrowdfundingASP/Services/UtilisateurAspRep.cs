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
    public class UtilisateurAspRep : IUtilisateurRep<int, Utilisateur>
    {
        private static IUtilisateurRep<int, Utilisateur> _entity;
        public static IUtilisateurRep<int, Utilisateur> Entity
        {
            get { return _entity ?? (_entity = new UtilisateurAspRep()); }
        }
        private IUtilisateurRep<int, CrowdDAL.Utilisateur> _fromDalrepos;
        public UtilisateurAspRep()
        {
            _fromDalrepos = new CrowdDALS.UtilisateurASPRep();
        }
       
        public void Add(FundingASP.Utilisateur entity)
        {
            _fromDalrepos.Add(entity.ToDAL());
        }

        public void ChangePassword(int id, string Password)
        {
            _fromDalrepos.ChangePassword(id, Password);
        }

        public int Check(string nomUtilisateur, string password)
        {
            return _fromDalrepos.Check(nomUtilisateur, password);
        }

        public void Delete(int id)
        {
            _fromDalrepos.Delete(id);
        }

        public IEnumerable<FundingASP.Utilisateur> Get(Utilisateur utilisateur)
        {
            return _fromDalrepos.Get().Select(a => a.ToASP());
        }

        public FundingASP.Utilisateur Get(int id)
        {
            return _fromDalrepos.Get(id).ToASP();
        }

        public IEnumerable<Utilisateur> Get()
        {
            return _fromDalrepos.Get().Select(a => a.ToASP());
        }

        public void Update(int id, FundingASP.Utilisateur entity)
        {
            _fromDalrepos.Update(id, entity.ToDAL());
        }
        public void SetAdmin(int id)
        {
            _fromDalrepos.SetAdmin(id);
        }

        public void UnsetAdmin(int id)
        {
            _fromDalrepos.UnsetAdmin(id);
        }
    }
}