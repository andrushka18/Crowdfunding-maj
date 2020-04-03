using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crowdfunding.Models
{
    public class Financeur:Utilisateur
    {
        public string Prime { get; set; }
        public decimal Montant { get; set; }
    }
}