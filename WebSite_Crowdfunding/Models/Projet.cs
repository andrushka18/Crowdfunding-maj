namespace WebSite_Crowdfunding.Models
{
    public class Projet
    {
        public int IdProjet { get; set; }
        public string Nom { get; set; }
        public decimal PlafondFinance { get; set; }
        private string _NumeroCompte;
        public string NumeroCompte
        {
            get { return _NumeroCompte; }
            set { _NumeroCompte = value; }
        }
        public string UrlVideo { get; set; }

    }
}
