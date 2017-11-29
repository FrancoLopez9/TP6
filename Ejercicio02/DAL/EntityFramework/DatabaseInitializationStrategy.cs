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
    /// Inicilización de BBDD
    /// </summary>
    class DatabaseInitializationStrategy : CreateDatabaseIfNotExists<AccountManagerDbContext>
    {
        protected override void Seed(AccountManagerDbContext pContext)
        {
           
            pContext.Clients.Add(new Client
            {
                Id = 1,
                Document = new Document
                {
                    Type = DocumentType.DNI,
                    Number = "13179327"
                },
                FirstName = "Alberto",
                LastName = "Moroni",
                Accounts = new List<Account>()
                {
                    new Account
                    {
                        Name = "Caja Ahorros",
                        OverDraftLimit = 1000,
                        Movements = new List<AccountMovement>
                        {
                            new AccountMovement
                            {
                                Date = DateTime.Now.AddDays(-10),
                                Description = "Acreditación de sueldo",
                                Amount = 40000
                            },
                            new AccountMovement
                            {
                                Date = DateTime.Now.AddDays(-5),
                                Description = "Pago de tarjeta de crédito",
                                Amount = -13200.5
                            },
                            new AccountMovement
                            {
                                Date = DateTime.Now.AddDays(-3),
                                Description = "Pago de seguro de vida",
                                Amount = -150
                            },
                            new AccountMovement
                            {
                                Date = DateTime.Now.AddDays(-3),
                                Description = "Pago de seguro automotor",
                                Amount = -1500
                            },
                            new AccountMovement
                            {
                                Date = DateTime.Now.AddDays(-1),
                                Description = "Devolución del IVA",
                                Amount = 85
                            },
                            new AccountMovement
                            {
                                Date = DateTime.Now,
                                Description = "Transferencia bancaria",
                                Amount = -5000
                            }
                        }
                    }
                }
            });

            pContext.Clients.Add(new Client
            {
                Id = 2,
                Document = new Document
                {
                    Type = DocumentType.CUIL,
                    Number = "0341166140841"
                },
                FirstName = "Liliana",
                LastName = "Roncaglia",
                Accounts = new List<Account>
                {
                    new Account
                    {
                        Name = "Caja Ahorros",
                        OverDraftLimit = 2000,
                        Movements = new List<AccountMovement>
                        {
                            new AccountMovement
                            {
                                Date = DateTime.Now.AddDays(-10),
                                Description = "Acreditación de sueldo",
                                Amount = 35000
                            },
                            new AccountMovement
                            {
                                Date = DateTime.Now.AddDays(-5),
                                Description = "Pago de tarjeta de crédito",
                                Amount = -7570
                            }
                        }
                    },
                    new Account
                    {
                        Name = "Cuenta Corriente",
                        OverDraftLimit = 5000
                    }
                }
            });

            base.Seed(pContext);
        }

    
    }
}
