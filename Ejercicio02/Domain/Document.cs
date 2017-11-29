using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Domain
{
    /// <summary>
    /// Clase Documento de un cliente
    /// </summary>
    public class Document
    {
        /// <summary>
        /// Numero de documento del cliente
        /// </summary>
        public String Number { get; set; }

        /// <summary>
        /// Tipo de documento del cliente
        /// </summary>
        public DocumentType Type { get; set; }
    }
}
