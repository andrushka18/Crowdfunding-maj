﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL_Crowdfunding.Models
{
    public class Valideur:Utilisateur
    {
        public string Status { get; set; }
        public string Commentaire { get; set; }
    }
}