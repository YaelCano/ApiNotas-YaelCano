using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.configuration
{
    public class AuditoriaConfiguration
    {
        public void Configure(EntityTypeBuilder<Auditoria> builder)
        {
            builder.ToTable("Auditoria");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.NombreUsuario).HasMaxLength(100).IsRequired();
            builder.Property(x => x.DesAccion).IsRequired();
            builder.Property(x => x.FechaCreacion);
            builder.Property(x => x.FechaModificacion);
        }
    }
}