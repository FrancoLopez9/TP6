using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Domain
{
    /// <summary>
    /// Clase de dominio y de datos de movimientos de la cuenta
    /// </summary>
    public class AccountMovement
    {
        /// <summary>
        /// Id del movimiento
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Fecha del movimiento
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Descripcion del movimiento
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// Monto del movimiento
        /// </summary>
        public double Amount { get; set; }
    }
}
