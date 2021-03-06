﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Ejercicio02.Domain;

namespace Ejercicio02.DAL.EntityFramework.Mappings
{
    /// <summary>
    /// Clase de Mapeo de cuenta
    /// </summary>
    class AccountMap : EntityTypeConfiguration<Account>
    {

        public AccountMap()
        {
            // Nombre de la tabla que tendrá la entidad, en este caso 'Account'.
            this.ToTable("Account");

            // Clave primaria de la entidad, indicando que la columna se llama 'AccountId' y que es autoincremental.
            this.HasKey(pAccount => pAccount.Id)
                .Property(pAccount => pAccount.Id)
                .HasColumnName("AccountId")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Se establece la columna obligatoria (NOT NULL) 'Name', con una longitud máxima de 30 caracteres [varchar(30)].
            this.Property(pAccount => pAccount.Name)
                .IsRequired()
                .HasMaxLength(30);

            // Se establece la columna obligatoria (NOT NULL) 'OverdraftLimit' (límite de descubierto).
            this.Property(pAccount => pAccount.OverDraftLimit)
                .IsRequired();

            // Se establece la relación de uno a cero o muchos entre Account y AccountMovement,
            // permitiendo solamente la navegación desde Account hacia AccountMovement, con eliminación en cascada.
            // El nombre de la columna de la FK se nombra 'AccountId'.
            this.HasMany(pAccount => pAccount.Movements)
                .WithRequired()
                .Map(pMapping => pMapping.MapKey("AccountId"))
                .WillCascadeOnDelete();
        }
    }
 }

