﻿namespace CrowdfundingASP.Models
{
    public class Financeur:Utilisateur
    {
        public decimal Montant { get; set; }
        public string Prime { get; set; }
        public int FinanceurId { get; set; }
        
    }
}