using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.IO
{
    /// <summary>
    /// Clase DTO de Movimiento de la cuenta
    /// </summary>
    public class AccountMovementDTO
    {
        /// <summary>
        /// Identificador del movimiento
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
        /// Monto
        /// </summary>
        public double Amount { get; set; }
    }
}
