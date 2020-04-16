namespace DALAspCrowdfunding.Repositories
{
    public interface IUtilisateurRep<TKey, T>: IRep<TKey, T> where T : class
    {
        void ChangePassword(TKey id, string Password);

        TKey  Check(string NomUtilisateur, string Password);
        
        void SetAdmin(TKey id);
        void UnsetAdmin(TKey id);
    }
}