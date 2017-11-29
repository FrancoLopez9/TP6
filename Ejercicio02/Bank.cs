using Ejercicio02.DAL.EntityFramework;
using Ejercicio02.IO;
using Ejercicio02.Domain;
using Ejercicio02.DAL;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    /// <summary>
    /// Clase controladora de fachada del sistema
    /// </summary>
    public class Bank
    {
        /// <summary>
        /// Obtiene las cuentas de un cliente
        /// </summary>
        /// <param name="pClientId">Id del cliente</param>
        /// <returns>Cuenta de un cliente</returns>
        public IEnumerable<AccountDTO> GetClientAccounts(int pClientId)
            {
                List<AccountDTO> mAccounts = new List<AccountDTO>();

            using (var bUnitOfWork = new UnitOfWork(new AccountManagerDbContext()))
            {
                // Se obtiene el usuario
                var mClient = bUnitOfWork.ClientRepository.Get(pClientId);

                // Se iteran por cada cuenta del usuario
                foreach (var bAccount in mClient.Accounts)
                {
                    // Se genera el objecto DTO en base al objeto de Dominio
                    mAccounts.Add(new AccountDTO
                    {
                        Balance = bAccount.GetBalance(),
                        Id = bAccount.Id,
                        Name = bAccount.Name,
                        OverDraftLimit = bAccount.OverDraftLimit
                    });
                }

                bUnitOfWork.Complete();
            }

            // Se devuelven las cuentas
            return mAccounts;

      
        }
        /// <summary>
        /// Obtiene los movimientos de la cuenta
        /// </summary>
        /// <param name="pAccountId">Id del movimiento de la cuenta</param>
        /// <returns>Movimientos de la cuenta</returns>
        public IEnumerable<AccountMovementDTO> GetAccountMovements(int pAccountId)
        {
            List<AccountMovementDTO> mAccountMovements = new List<AccountMovementDTO>();

            using (var bUnitOfWork = new UnitOfWork(new AccountManagerDbContext()))
            {
                // Se obtiene el usuario
                var mAccount = bUnitOfWork.AccountRepository.Get(pAccountId);

                // Se iteran por cada movimiento de la cuenta
                foreach (var bAccount in mAccount.Movements)
                {
                    // Se genera el objecto DTO en base al objeto de Dominio
                    mAccountMovements.Add(new AccountMovementDTO
                    {
                        Amount = bAccount.Amount,
                        Id = bAccount.Id,
                        Date = bAccount.Date,
                        Description = bAccount.Description
                    });
                }

                bUnitOfWork.Complete();
            }

            // Se devuelven los movimentos de cuentas
            return mAccountMovements;
        }

        /// <summary>
        /// Apertura de la cuenta del cliente
        /// </summary>
        /// <param name="pClient">Cliente</param>
        /// <param name="pNombre">Nombre de la cuenta</param>
        /// <param name="pOverdraftLimit">Limite del Descubierto</param>
        public void OppenAccount(Client pClient, string pName, double pOverDraftLimit)
        {
            using (var bUnitOfWork = new UnitOfWork(new AccountManagerDbContext()))
            {
                var mClient = bUnitOfWork.ClientRepository.Get(pClient.Id);

                mClient.Accounts.Add(new Account
                {
                    Client = pClient,
                    Name = pName,
                    OverDraftLimit = pOverDraftLimit
                });
                bUnitOfWork.Complete();
            }
        }
                
    

        /// <summary>
        /// Realiza un movimiento de una cuenta
        /// </summary>
        /// <param name="pAccountId">ID de la cuenta</param>
        /// <param name="pDescripcion">Descripcion del movimiento</param>
        /// <param name="pAmount">Cantidad del movimiento</param>
        public void MakeMovement(int pAccountId, string pDescripcion, double pAmount)
        {
            using (UnitOfWork mUnit = new UnitOfWork(new AccountManagerDbContext()))
            {
                Account mAccount = mUnit.AccountRepository.Get(pAccountId);
                mAccount.Movements.Add(new AccountMovement
                {
                    Description = pDescripcion,
                    Date = DateTime.Now,
                    Amount = pAmount
                });
                mUnit.DbContext.Entry(mAccount).State = System.Data.Entity.EntityState.Modified;
                mUnit.Complete();
            }
        }

        /// <summary>
        /// Obtiene las cuentas cuyo balance es negativo y hayan sobrepasado su limite de Descubierto 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AccountDTO> GetOverDrawnAccounts()
        {
            List<AccountDTO> mAccounts = new List<AccountDTO>();
            using (UnitOfWork mUnit = new UnitOfWork(new AccountManagerDbContext()))
            {
                foreach (Account mAccount in mUnit.AccountRepository.GetOverdrawnAccounts())
                {
                    mAccounts.Add(new AccountDTO
                    {
                        Balance = mAccount.GetBalance(),
                        Id = mAccount.Id,
                        Name = mAccount.Name,
                        OverDraftLimit = mAccount.OverDraftLimit
                    });
                }
                mUnit.Complete();
            }
            return mAccounts;
        }
    }
}
