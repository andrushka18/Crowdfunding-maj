using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdfundingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CrowdfundingAPI.Services.UtilisateurService s = new CrowdfundingAPI.Services.UtilisateurService();
            CrowdfundingAPI.Models.Utilisateur m = new CrowdfundingAPI.Models.Utilisateur();
            m.Nom = "toto3";
            m.Prenom = "tata";
            m.NomUtilisateur = "tata@hotmail.com";
            m.Password = "welcome123";
            m.Role = "utilisateur";
            s.Add(m);
          
                Console.WriteLine(s) ;
                Console.ReadLine();
           
        }
    }
}
