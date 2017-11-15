using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    interface IAccountRepository<TEntity> : IRepository<TEntity> where TEntity : Account
    {

        IEnumerable<Account> GetOverdrawnAccounts();
    }
}
