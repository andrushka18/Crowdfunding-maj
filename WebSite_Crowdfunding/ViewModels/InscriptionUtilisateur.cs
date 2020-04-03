using System.ComponentModel.DataAnnotations;

namespace WebSite_Crowdfunding.ViewModels
{
    public class InscriptionUtilisateur
    {
        [Required]
        [Display(Name = "Nom d'utilisateur")]
        public string NomUtilisateur { get; set; }
        [DataType("password")]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Les mots de passes saisis ne correspondent pas")]
        [DataType("password")]
        [Display(Name = "Répétez le mot de passe")]
        public string PwdRepeat { get; set; }
    }
}