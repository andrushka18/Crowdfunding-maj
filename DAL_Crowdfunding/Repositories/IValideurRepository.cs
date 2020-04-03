using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Crowdfunding.Repositories
{
    public interface IValideurRepository<TKey, T> : IRepository<TKey, T> where T : class
    {
    }
}
