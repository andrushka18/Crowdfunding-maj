using CrowdfundingASP.Models;
using System.ComponentModel.DataAnnotations;

namespace CrowdfundingASP.ViewModels
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
        public string Role { get; set; }
    }
}