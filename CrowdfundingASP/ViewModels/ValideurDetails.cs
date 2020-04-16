using CrowdfundingASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdfundingASP.ViewModels
{
    public class ValideurDetails
    {
        public Valideur Valide { get; set; }
        public IEnumerable<Projet> projets { get; set; }
        
    }
}