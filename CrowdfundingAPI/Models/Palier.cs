using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdfundingAPI.Models
{
    public class Palier
    {
        public int IdPalier { get; set; }
        public decimal Montant { get; set; }
        public string Prime { get; set; }
    }
}