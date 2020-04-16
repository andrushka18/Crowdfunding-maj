using CrowdfundingASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdfundingASP.ViewModels
{
    public class FinanceurDetails
    {
        public Financeur Financements { get; set; }
        public IEnumerable<Projet> projets { get; set; }
        public IEnumerable<Palier> paliers { get; set; }
    }
}