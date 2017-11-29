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
    /// Clase de repositorio de cuentas
    /// </summary>
    class AccountRepository : Repository<Account, AccountManagerDbContext>, IAccountRepository<Account>
    {
        public AccountRepository(AccountManagerDbContext pContext) : base(pContext)
        {
        }

        /// <summary>
        /// Obtiene el balance de la cuenta
        /// </summary>
        /// <param name="pAccount">Cuenta del cliente</param>
        /// <returns>Balance de la cuenta</returns>
        public double GetAccountBalance(Account pAccount)
        {
            if (pAccount == null)
            {
                throw new ArgumentNullException(nameof(pAccount));
            }

            return pAccount.Movements.Sum(pMovement => pMovement.Amount);
        }

        /// <summary>
        /// Obtiene los ultimos movimientos de la cuenta
        /// </summary>
        /// <param name="pAccount">Cuenta del cliente</param>
        /// <param name="pCount">Cantidad de movimientos</param>
        /// <returns>Movimientos de cuenta</returns>
        public IEnumerable<AccountMovement> GetLastMovements(Account pAccount, int pCount = 7)
        {
            if (pAccount == null)
            {
                throw new ArgumentNullException(nameof(pAccount));
            }

            return pAccount.Movements.OrderBy(pMovement => pMovement.Date).Take(pCount);
        }

        /// <summary>
        /// Obtencion de cuentas excedidas del descubierto
        /// </summary>
        /// <returns>Cuentas</returns>
        public IEnumerable<Account> GetOverdrawnAccounts()
        {
            return from account in this.iDbContext.Set<Account>()
                   select new { Account = account, Balance = account.Movements.Sum(pMovement => pMovement.Amount) } into accountWithBalance
                   where accountWithBalance.Balance < 0 && Math.Abs(accountWithBalance.Balance) > accountWithBalance.Account.OverDraftLimit
                   select accountWithBalance.Account;
        }
    }
}
