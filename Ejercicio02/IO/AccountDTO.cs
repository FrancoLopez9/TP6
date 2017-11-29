using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.IO
{
    /// <summary>
    /// Clase DTO de Account
    /// </summary>
    public class AccountDTO
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de la cuenta
        /// </summary>
        public String Name { get; set; }
        
        /// <summary>
        /// Limite de descubierto
        /// </summary>
        public double OverDraftLimit { get; set; }

        /// <summary>
        /// Balance de la cuenta
        /// </summary>
        public double Balance { get; set; }
    }
}
