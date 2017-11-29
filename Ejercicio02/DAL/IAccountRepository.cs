using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.Domain;

namespace Ejercicio02.DAL
{
    /// <summary>
    /// Interfaz de repositorio de cuentas
    /// </summary>
    /// <typeparam name="TEntity">Entidad</typeparam>
    interface IAccountRepository<TEntity> : IRepository<TEntity> where TEntity : Account
    {

        /// <summary>
        /// Obtencion de cuentas excedidas del descubierto
        /// </summary>
        /// <returns></returns>
        IEnumerable<Account> GetOverdrawnAccounts();
    }
}
