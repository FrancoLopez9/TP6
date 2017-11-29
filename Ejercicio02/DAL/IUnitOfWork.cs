using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.Domain;

namespace Ejercicio02.DAL
{    
    interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Persiste los cambios
        /// </summary>
        void Complete();

        /// <summary>
        /// Repositorio de cuentas
        /// </summary>
        IAccountRepository<Account> AccountRepository { get; }

        /// <summary>
        /// Repositorio de clientes
        /// </summary>
        IClientRepository<Client> ClientRepository { get; }
    }

}
