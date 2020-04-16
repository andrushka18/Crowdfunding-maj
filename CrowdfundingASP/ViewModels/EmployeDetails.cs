using CrowdfundingASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdfundingASP.ViewModels
{
    public class EmployeDetails
    {
        public Employe Employe { get; set; }
        public IEnumerable<Projet> projets { get; set; }
        public IEnumerable<Palier> paliers { get; set; }

    }
}