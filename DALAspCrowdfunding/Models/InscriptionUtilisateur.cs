using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALAspCrowdfunding.Models
{
    public class InscriptionUtilisateur
    {
        [Required]
        [MaxLength(50)]
        [Display(Name = "Nom ")]
        public string Nom { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Prenom")]
        public string Prenom { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(50)]
        [Display(Name = "Nom d'utilisateur")]
        public string NomUtilisateur { get; set; }
        [DataType("password")]
        [Display(Name = "Mot de passe")]
        [MaxLength(20)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Les mots de passes saisis ne correspondent pas")]
        [DataType("password")]
        [Display(Name = "Répétez le mot de passe")]
        [MaxLength(20)]
        public string PwdRepeat { get; set; }
        public string Role { get; set; }
    }
}
