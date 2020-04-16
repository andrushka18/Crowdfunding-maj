using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.JWT;

namespace TestToken
{
    class Program
    {
        static void Main(string[] args)
        {
            JWTService service
                = new JWTService(
                    "azertyuiopqsdfghjklm",
                    "www.mondomaine.com",
                    "www.domaine2.com"
                );

            Utilisateur u = new Utilisateur()
            {
                Nom = "Andre",
                UtilisateurId = 1,
               
            };

            string token = service.Encode(u);
            Console.WriteLine(token);

            if(service.ValidateToken("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJZCI6IjEiLCJOYW1lIjoiS2h1biIsIkJpcnRoRGF0ZSI6IjA2LTA1LTgyIDAwOjAwOjAwIiwibmJmIjoxNTgzMTQwNzU3LCJleHAiOjE1ODMxNDA3NTgsImlzcyI6Ind3dy5tb25kb21haW5lLmNvbSIsImF1ZCI6Ind3dy5kb21haW5lMi5jb20ifQ.9-qqjWiJe_DzjDiXMA25rPY23VEwKMc8q2UPFDxLfWE"))
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("KO");
            }

            Console.ReadKey();

        }
    }

    public class Utilisateur
    {
        public int UtilisateurId { get; set; }
        public string Nom { get; set; }
       
    }
}
