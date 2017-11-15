using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Bank
    {
        public IEnumerable<AccountDTO> GetClientAccounts(int pClientId) { }

        public IEnumerable<AccountMovementDTO> GetAccountMovements(int pAccountId) { }
    }
}
