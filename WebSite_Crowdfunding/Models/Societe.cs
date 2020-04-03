using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSite_Crowdfunding.Models
{
   public class Societe:Employe
    {
        public int NumeroTVA { get; set; }
        public string Description { get; set; }
    }
}
