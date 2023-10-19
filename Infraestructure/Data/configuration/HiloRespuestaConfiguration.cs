using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.configuration
{
    public class HiloRespuestaConfiguration : IEntityTypeConfiguration<HiloRespuestaNotificaciones>
    {
    public void Configure(EntityTypeBuilder<HiloRespuestaNotificaciones> builder)
        {
            builder.ToTable("HiloRespuestaNotificacion");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nombretipo).IsRequired().HasMaxLength(80);
            builder.Property(x => x.FechaCreacion);
            builder.Property(x => x.FechaModificacion);
        }
    }
}