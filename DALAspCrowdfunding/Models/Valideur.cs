using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALAspCrowdfunding.Models
{
    public class Valideur:Utilisateur
    {
        public string Status { get; set; }
        public string Commentaire { get; set; }
        public int ValideurId { get; set; }
        
    }
}
