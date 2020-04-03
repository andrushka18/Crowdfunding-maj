namespace DALAspCrowdfunding.Repositories
{
    public interface IUtilisateurRep<TKey, T>: IRep<TKey, T> where T : class
    {
        void ChangePassword(TKey id, string password);

        void  Check(string username, string password);
        void SetAdmin(TKey id);
        void UnsetAdmin(TKey id);
    }
}