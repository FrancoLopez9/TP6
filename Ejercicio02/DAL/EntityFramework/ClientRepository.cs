using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Ejercicio02.Domain;

namespace Ejercicio02.DAL.EntityFramework
{
     /// <summary>
     /// Repositorio de entidad cliente
     /// </summary>
     class ClientRepository : Repository<Client, AccountManagerDbContext>, IClientRepository<Client>
    {
        public ClientRepository(AccountManagerDbContext pContext) : base(pContext)
        {
        }
    }
}
