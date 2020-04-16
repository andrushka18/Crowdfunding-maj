using A=CrowdfundingASP.Models;
using B=CrowdfundingASP.ViewModels;
using CrowdDAL = DALAspCrowdfunding.Models;
using FundingASP = CrowdfundingASP.Models;



namespace CrowdfundingASP.Usefulls
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
                Role = user.Role,
                IsActive = user.IsActive,
                

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
                Role = user.Role,
                IsActive = user.IsActive,
                
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
                FinanceurId = fin.FinanceurId


            };
        }
        public static FundingASP.Financeur ToASP(this CrowdDAL.Financeur fin)
        {
            return new FundingASP.Financeur
            {
                Montant = fin.Montant,
                Prime = fin.Prime,
                FinanceurId = fin.FinanceurId
            };
        }
        public static CrowdDAL.Valideur ToDAL(this FundingASP.Valideur val)
        {
            return new CrowdDAL.Valideur
            {

                Status = val.Status,
                Commentaire = val.Commentaire,
                ValideurId = val.ValideurId

            };
        }
        public static FundingASP.Valideur ToASP(this CrowdDAL.Valideur val)
        {
            return new FundingASP.Valideur
            {
                Status = val.Status,
                Commentaire = val.Commentaire,
                ValideurId = val.ValideurId

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
                Role = role.Role,


            };
        }
        public static FundingASP.Droit ToASP(this CrowdDAL.Droit role)
        {
            return new FundingASP.Droit
            {
                IdDroit = role.IdDroit,
                Role = role.Role,

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
        public static B.CompteUtilisateur ToASP(this CrowdDAL.CompteUtilisateur s)
        {
            return new B.CompteUtilisateur
            {
                NomUtilisateur = s.NomUtilisateur,
                Password = s.Password,


            };
        }
        public static CrowdDAL.CompteUtilisateur ToDAL(this B.CompteUtilisateur s)
        {
            return new CrowdDAL.CompteUtilisateur
            {

                NomUtilisateur = s.NomUtilisateur,
                Password = s.Password,


            };
        }
        public static B.InscriptionUtilisateur ToASP(this CrowdDAL.InscriptionUtilisateur s)
        {
            return new B.InscriptionUtilisateur
            {
                Nom=s.Nom,
                Prenom = s.Prenom,   
                NomUtilisateur = s.NomUtilisateur,
                Password = s.Password,
                PwdRepeat =s.PwdRepeat
                
            };
        }
        public static CrowdDAL.InscriptionUtilisateur ToDAL(this B.InscriptionUtilisateur s)
        {
            return new CrowdDAL.InscriptionUtilisateur
            {

                Nom = s.Nom,
                Prenom = s.Prenom,
                NomUtilisateur = s.NomUtilisateur,
                Password = s.Password,
                PwdRepeat = s.PwdRepeat


            };
        }


    }
}