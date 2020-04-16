using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdfundingAPI.Models
{
    public class Valideur:Utilisateur
    {
        public int ValideurId { get; set; }
        public string Status { get; set; }
        public string Commentaire { get; set; }
    }
}