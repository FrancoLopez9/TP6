using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.Domain;

namespace Ejercicio02.DAL

{
    /// <summary>
    /// Interfaz de repositorio de clientes
    /// </summary>
    /// <typeparam name="TEntity">Entidad</typeparam>
    interface IClientRepository<TEntity> : IRepository<TEntity> where TEntity : Client
    {
    }
}
