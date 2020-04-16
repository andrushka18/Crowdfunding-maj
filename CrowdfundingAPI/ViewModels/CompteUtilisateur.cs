using CrowdfundingAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace CrowdfundingAPI.ViewModels
{
    public class CompteUtilisateur:Utilisateur
    {
        [Required]
        [EmailAddress]
        [MaxLength(320)]
        [Display(Name = "Nom utilisateur")]
        public string NomUtilisateur { get; set; }
        [Required]
        [DataType("password")]
        [Display(Name = "Mot de passe")]
        [MaxLength(20)]
        public string Password { get; set; }
    }
}