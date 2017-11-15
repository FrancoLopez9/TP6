using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    interface IUnitOfWork : IDisposable
    {
        void Complete();
        IAccountRepository<Account> AccountRepository { get; }
        IClientRepository<Client> ClientRepository { get; }
    }

}
