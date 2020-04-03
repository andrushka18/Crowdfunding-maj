namespace DALAspCrowdfunding.Models
{
    public class Financeur:Utilisateur
    {
        public decimal Montant { get; set; }
        public string Prime { get; set; }
        
    }
}
