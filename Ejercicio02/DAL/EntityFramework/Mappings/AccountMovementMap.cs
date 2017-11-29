using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Ejercicio02.Domain;

namespace Ejercicio02.DAL.EntityFramework.Mappings
{
    /// <summary>
    /// Clase de mapeo de movimiento de la cuenta
    /// </summary>
    class AccountMovementMap : EntityTypeConfiguration<AccountMovement>
    {

        public AccountMovementMap()
        {
            // Nombre de la tabla que tendrá la entidad, en este caso 'AccountMovement'.
            this.ToTable("AccountMovement");

            // Clave primaria de la entidad, indicando que la columna se llama 'AccountMovementId' y que es autoincremental.
            this.HasKey(pAccountMovement => pAccountMovement.Id)
                .Property(pAccountMovement => pAccountMovement.Id)
                .HasColumnName("AccountMovementId")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Se establece la columna obligatoria (NOT NULL) 'Date'.
            this.Property(pAccountMovement => pAccountMovement.Date)
                .IsRequired();

            // Se establece la columna obligatoria (NOT NULL) 'Description', con una longitud máxima de 50 caracteres [varchar(50)].
            this.Property(pAccountMovement => pAccountMovement.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Se establece la columna obligatoria (NOT NULL) 'Amount'.
            this.Property(pAccountMovement => pAccountMovement.Amount)
                .IsRequired();

        }

    }
}
