using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.DAL;
using System.Data.Entity;
using Ejercicio02.Domain;

namespace Ejercicio02.DAL.EntityFramework
{
    class UnitOfWork : IUnitOfWork
    {

        private readonly AccountManagerDbContext iDbContext;

        public UnitOfWork(AccountManagerDbContext pContext)
        {
            if (pContext == null)
            {
                throw new ArgumentNullException(nameof(pContext));
            }

            this.iDbContext = pContext;
            this.ClientRepository = new ClientRepository(this.iDbContext);
            this.AccountRepository = new AccountRepository(this.iDbContext);
        }

        public DbContext DbContext { get; }

        /// <summary>
        /// Repositorio de cuentas
        /// </summary>
        public IAccountRepository<Account> AccountRepository
        {
            get; private set;
        }

        /// <summary>
        /// Repositorio de Clientes
        /// </summary>
        public IClientRepository<Client> ClientRepository
        {
            get; private set;
        }

        /// <summary>
        /// Persiste los cambios
        /// </summary>
        public void Complete()
        {
            this.iDbContext.SaveChanges();
        }

        /// <summary>
        /// Elimina los recursos tomados
        /// </summary>
        public void Dispose()
        {
            this.iDbContext.Dispose();
        }
    }
}
