using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio02.Domain;
using Ejercicio02.IO;
using Ejercicio02.DAL;
using Ejercicio02;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OpenAccountsTest()
        {
            Client cliente1 = new Client();
            cliente1.Id = 1;
            cliente1.FirstName = "Sonia";
            cliente1.LastName = "Perez";
            cliente1.Document.Number = "16614534";
            cliente1.Document.Type = DocumentType.DNI;

            Bank banco = new Bank();
            banco.OppenAccount(cliente1, "Caja de Ahorros", 1500);

            banco.GetClientAccounts(1);





        }
    }
}
