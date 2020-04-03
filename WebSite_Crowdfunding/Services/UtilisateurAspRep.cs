using DALAspCrowdfunding.Repositories;
using CrowdDALS = DALAspCrowdfunding.Repositories;
using System.Collections.Generic;
using System.Linq;
using WebSite_Crowdfunding.Models;
using WebSite_Crowdfunding.Usefulls;
using CrowdDAL = DALAspCrowdfunding.Models;
using FundingASP = WebSite_Crowdfunding.Models;

namespace WebSite_Crowdfunding.Services
{
    public class UtilisateurAspRep : IUtilisateurRep<int, Utilisateur>
    {
        private static IUtilisateurRep<int, Utilisateur> _entity;
        public static IUtilisateurRep<int, Utilisateur> Entity
        {
            get { return _entity ?? (_entity = new UtilisateurAspRep()); }
        }
        private UtilisateurAspRep()
        {
            _fromDalrepos = new CrowdDALS.UtilisateurASPRep();
        }
        private IUtilisateurRep<int, CrowdDAL.Utilisateur> _fromDalrepos;
        public void Add(FundingASP.Utilisateur entity)
        {
            _fromDalrepos.Add(entity.ToDAL());
        }

        public void ChangePassword(int id, string motDePasse)
        {
            _fromDalrepos.ChangePassword(id, motDePasse);
        }

        public void Check(string nomUtilisateur, string motDePasse)
        {
            _fromDalrepos.Check(nomUtilisateur, motDePasse);
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