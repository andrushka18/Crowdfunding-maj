using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL_Crowdfunding.Models
{
    public class Utilisateur
    {
        public int UtilisateurId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NomUtilisateur { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
      
    }
}