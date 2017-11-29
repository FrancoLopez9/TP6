using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.Domain;
using Ejercicio02.IO;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client cliente1 = new Client();
            //cliente1.Id = 1;
            //cliente1.FirstName = "Sonia";
            //cliente1.LastName = "Perez";
            //Document documento = new Document();
            //documento.Number = "16614534";
            //documento.Type = DocumentType.DNI;
            //cliente1.Document = documento;
            
            //banco.OppenAccount(cliente1, "Caja de Ahorros", 1500);

            Bank banco = new Bank();
            IEnumerable<AccountDTO> cuentas = banco.GetClientAccounts(2);

            //Console.WriteLine("Nombre: {0}, Apellido: {1}, Id: {2}",
            //            cliente1.FirstName,
            //            cliente1.LastName,
            //            cliente1.Id);

            foreach(AccountDTO cuentita in cuentas)
            {
                Console.WriteLine("Id: {0}, NombreCuenta: {1}, OverdraftLimit: {2}",
                        cuentita.Id,
                        cuentita.Name,
                        cuentita.OverDraftLimit);
            }
            Console.ReadKey();
        }
    }
}
