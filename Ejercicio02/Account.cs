using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Account
    { 
        public int Id { get; set; }
        public String Name { get; set; }
        public double OverdraftLimit { get; set; }
        public List<AccountMovement> Movements { get; set; }

        public double GetBalance() { }

        public IEnumerable<AccountMovement> GetLastMovements(pCount: int = 7) { }; 
    }
}
