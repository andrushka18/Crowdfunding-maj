using CrowdDALX = DAL_Crowdfunding.Models;
using FundingAPI = Crowdfunding.Models;

namespace Crowdfunding.Services.Mapper
{
    public static class CrowFundMap
    {
        public static CrowdDALX.Utilisateur ToDAL(this FundingAPI.Utilisateur user)
        {
            return new CrowdDALX.Utilisateur
            {
                UtilisateurId = user.Id,
                Nom = user.Nom,
                Prenom = user.Prenom,
                NomUtilisateur = user.NomUtilisateur,
                Password = user.MotDePasse,
                IsAdmin = user.IsAdmin,
                IsActive = user.IsActive

            };
        }
        public static FundingAPI.Utilisateur ToAPI(this CrowdDALX.Utilisateur user)
        {
            return new FundingAPI.Utilisateur
            {
                Id = user.UtilisateurId,
                Nom = user.Nom,
                Prenom = user.Prenom,
                NomUtilisateur = user.NomUtilisateur,
                MotDePasse = user.Password,
                IsActive = user.IsActive,
                IsAdmin = user.IsAdmin
            };
        }

        public static CrowdDALX.Projet ToDAL(this FundingAPI.Projet projo)
        {
            return new CrowdDALX.Projet
            {
                IdProjet = projo.IdProjet,
                Nom = projo.Nom,
                PlafondFinance = projo.PlafondFinance,
                UrlVideo = projo.UrlVideo,
                NumeroCompte = projo.NumeroCompte,

            };
        }
        public static FundingAPI.Projet ToAPI(this CrowdDALX.Projet projo)
        {
            return new FundingAPI.Projet
            {
                IdProjet = projo.IdProjet,
                Nom = projo.Nom,
                PlafondFinance = projo.PlafondFinance,
                UrlVideo = projo.UrlVideo,
                NumeroCompte = projo.NumeroCompte,
            };
        }
        public static CrowdDALX.Financeur ToDAL(this FundingAPI.Financeur fin)
        {
            return new CrowdDALX.Financeur
            {

                Montant = fin.Montant,
                Prime = fin.Prime,


            };
        }
        public static FundingAPI.Financeur ToAPI(this CrowdDALX.Financeur fin)
        {
            return new FundingAPI.Financeur
            {
                Montant = fin.Montant,
                Prime = fin.Prime,

            };
        }
        public static CrowdDALX.Valideur ToDAL(this FundingAPI.Valideur Val)
        {
            return new CrowdDALX.Valideur
            {

                Status = Val.Status,
                Commentaire = Val.Commentaire,


            };
        }
        public static FundingAPI.Valideur ToAPI(this CrowdDALX.Valideur Val)
        {
            return new FundingAPI.Valideur
            {
                Status = Val.Status,
                Commentaire = Val.Commentaire,

            };
        }
        public static CrowdDALX.Employe ToDAL(this FundingAPI.Employe emp)
        {
            return new CrowdDALX.Employe
            {

                NumeroNational = emp.NumeroNational,
                Date = emp.Date,


            };
        }
        public static FundingAPI.Employe ToAPI(this CrowdDALX.Employe emp)
        {
            return new FundingAPI.Employe
            {
                NumeroNational = emp.NumeroNational,
                Date = emp.Date,

            };
        }
        public static CrowdDALX.Droit ToDAL(this FundingAPI.Droit role)
        {
            return new CrowdDALX.Droit
            {

                IdDroit = role.IdDroit,
                NomDroit = role.NomDroit,


            };
        }
        public static FundingAPI.Droit ToAPI(this CrowdDALX.Droit role)
        {
            return new FundingAPI.Droit
            {
                IdDroit = role.IdDroit,
                NomDroit = role.NomDroit,

            };
        }
        public static CrowdDALX.Palier ToDAL(this FundingAPI.Palier p)
        {
            return new CrowdDALX.Palier
            {

                IdPalier = p.IdPalier,
                Montant = p.Montant,
                Prime = p.Prime


            };
        }
        public static FundingAPI.Palier ToAPI(this CrowdDALX.Palier p)
        {
            return new FundingAPI.Palier
            {
                IdPalier = p.IdPalier,
                Montant = p.Montant,
                Prime = p.Prime

            };
        }
        public static CrowdDALX.Societe ToDAL(this FundingAPI.Societe soc)
        {
            return new CrowdDALX.Societe
            {

                NumeroTVA = soc.NumeroTVA,
                Description = soc.Description


            };
        }
        public static FundingAPI.Societe ToAPI(this CrowdDALX.Societe soc)
        {
            return new FundingAPI.Societe
            {
                NumeroTVA = soc.NumeroTVA,
                Description = soc.Description
                

            };
        }
    }
}