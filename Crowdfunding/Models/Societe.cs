using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crowdfunding.Models
{
    public class Societe:Employe
    {
        public int NumeroTVA { get; set; }
        public string Description { get; set; }
    }
}