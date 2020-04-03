using WebSite_Crowdfunding.Models;
using WebSite_Crowdfunding.ViewModels;
using CrowdDAL = DALAspCrowdfunding.Models;
using FundingASP = WebSite_Crowdfunding.Models;



namespace WebSite_Crowdfunding.Usefulls
{
    public static class CrowFundMap
    {
        public static CrowdDAL.Utilisateur ToDAL(this FundingASP.Utilisateur user)
        {
            return new CrowdDAL.Utilisateur
            {
                UtilisateurId = user.UtilisateurId,
                Nom = user.Nom,
                Prenom = user.Prenom,
                NomUtilisateur = user.NomUtilisateur,
                Password = user.Password,
                IsActive = user.IsActive,
                IsAdmin = user.IsAdmin,

            };
        }
        public static FundingASP.Utilisateur ToASP(this CrowdDAL.Utilisateur user)
        {
            return new FundingASP.Utilisateur
            {
                UtilisateurId = user.UtilisateurId,
                Nom = user.Nom,
                Prenom = user.Prenom,
                NomUtilisateur = user.NomUtilisateur,
                Password = user.Password,
                IsActive = user.IsActive,
                IsAdmin = user.IsAdmin,
            };
        }

        public static CrowdDAL.Projet ToDAL(this FundingASP.Projet projo)
        {
            return new CrowdDAL.Projet
            {
                IdProjet = projo.IdProjet,
                Nom = projo.Nom,
                PlafondFinance = projo.PlafondFinance,
                UrlVideo = projo.UrlVideo,
                NumeroCompte = projo.NumeroCompte,

            };
        }
        public static FundingASP.Projet ToASP(this CrowdDAL.Projet projo)
        {
            return new FundingASP.Projet
            {
                IdProjet = projo.IdProjet,
                Nom = projo.Nom,
                PlafondFinance = projo.PlafondFinance,
                UrlVideo = projo.UrlVideo,
                NumeroCompte = projo.NumeroCompte,
            };
        }
        public static CrowdDAL.Financeur ToDAL(this FundingASP.Financeur fin)
        {
            return new CrowdDAL.Financeur
            {

                Montant = fin.Montant,
                Prime = fin.Prime,


            };
        }
        public static FundingASP.Financeur ToASP(this CrowdDAL.Financeur fin)
        {
            return new FundingASP.Financeur
            {
                Montant = fin.Montant,
                Prime = fin.Prime,

            };
        }
        public static CrowdDAL.Valideur ToDAL(this FundingASP.Valideur Val)
        {
            return new CrowdDAL.Valideur
            {

                Status = Val.Status,
                Commentaire = Val.Commentaire,


            };
        }
        public static FundingASP.Valideur ToASP(this CrowdDAL.Valideur Val)
        {
            return new FundingASP.Valideur
            {
                Status = Val.Status,
                Commentaire = Val.Commentaire,

            };
        }
        public static CrowdDAL.Employe ToDAL(this FundingASP.Employe emp)
        {
            return new CrowdDAL.Employe
            {

                NumeroNational = emp.NumeroNational,
                Date = emp.Date,


            };
        }
        public static FundingASP.Employe ToASP(this CrowdDAL.Employe emp)
        {
            return new FundingASP.Employe
            {
                NumeroNational = emp.NumeroNational,
                Date = emp.Date,

            };
        }
        public static CrowdDAL.Droit ToDAL(this FundingASP.Droit role)
        {
            return new CrowdDAL.Droit
            {

                IdDroit = role.IdDroit,
                NomDroit = role.NomDroit,


            };
        }
        public static FundingASP.Droit ToASP(this CrowdDAL.Droit role)
        {
            return new FundingASP.Droit
            {
                IdDroit = role.IdDroit,
                NomDroit = role.NomDroit,

            };
        }
        public static Utilisateur SignInToUser(this InscriptionUtilisateur iu)
        {
            return new Utilisateur
            {
                NomUtilisateur = iu.NomUtilisateur,
                Password = iu.Password
            };
        }
        public static CrowdDAL.Palier ToDAL(this FundingASP.Palier p)
        {
            return new CrowdDAL.Palier
            {

                IdPalier = p.IdPalier,
                Montant = p.Montant,
                Prime = p.Prime

            };
        }
        public static FundingASP.Palier ToASP(this CrowdDAL.Palier p)
        {
            return new FundingASP.Palier
            {
                IdPalier = p.IdPalier,
                Montant = p.Montant,
                Prime = p.Prime

            };
        }
        public static CrowdDAL.Societe ToDAL(this FundingASP.Societe s)
        {
            return new CrowdDAL.Societe
            {

                NumeroTVA = s.NumeroTVA,
                Description = s.Description,

            };
        }
        public static FundingASP.Societe ToASP(this CrowdDAL.Societe s)
        {
            return new FundingASP.Societe
            {
                NumeroTVA = s.NumeroTVA,
                Description = s.Description,


            };
        }
       
        
    }
}