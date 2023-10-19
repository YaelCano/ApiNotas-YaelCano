using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.configuration;

    public class TipoNotificacionConfiguration : IEntityTypeConfiguration<TipoNotificaciones>
    {
        public void Configure(EntityTypeBuilder<TipoNotificaciones> builder)
        {
            builder.ToTable("TipoNotificaciones");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.NombreTipo).HasMaxLength(80).IsRequired();
            builder.Property(x => x.FechaCreacion);
            builder.Property(x => x.FechaModificacion);
        }
    }
