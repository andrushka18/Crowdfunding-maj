using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALAspCrowdfunding.Models
{
    public class CompteUtilisateur
    {
        [Required]
        [EmailAddress]
        [MaxLength(50)]
        [Display(Name = "Nom utilisateur")]
        public string NomUtilisateur { get; set; }
        [Required]
        [DataType("password")]
        [Display(Name = "Mot de passe")]
        [MaxLength(20)]
        public string Password { get; set; }
        [Required]
        [DataType("password")]
        [Display(Name = "Mot de passe")]
        [MaxLength(20)]
        public string Role { get; set; }
    }
}
