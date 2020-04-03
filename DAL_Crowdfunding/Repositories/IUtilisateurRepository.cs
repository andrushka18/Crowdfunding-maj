using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Crowdfunding.Repositories
{
    public interface IUtilisateurRepository<TKey, T> : IRepository<TKey, T> where T : class
    {

        void ChangePassword(TKey id, string password);

        TKey Check(string username, string password);
        void SetAdmin(TKey id);
        void UnsetAdmin(TKey id);
    }
}
