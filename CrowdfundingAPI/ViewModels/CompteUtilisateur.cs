using CrowdfundingAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace CrowdfundingAPI.ViewModels
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
        [MaxLength(20)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }
        //public string Role { get; set; }
    }
}