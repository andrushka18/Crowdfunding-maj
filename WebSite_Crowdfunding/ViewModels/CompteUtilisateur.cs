using System.ComponentModel.DataAnnotations;

namespace WebSite_Crowdfunding.ViewModels
{
    public class CompteUtilisateur
    {
        [Required]
        [Display(Name = "Nom utilisateur")]
        public string NomUtilisateur { get; set; }
        [Required]
        [DataType("password")]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }
    }
}