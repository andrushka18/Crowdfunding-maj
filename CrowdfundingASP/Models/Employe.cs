using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdfundingASP.Models
{
    public class Employe:Utilisateur
    {
        public int NumeroNational { get; set; }
        public DateTime Date { get; set; }
        
    }
}
