﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdfundingAPI.Models
{
    public class Financeur:Utilisateur
    {
        public int FinanceurId { get; set; } 
        public string Prime { get; set; }
        public decimal Montant { get; set; }
    }
}