using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.configuration;

public class TipoRequrimientoConfiguration: IEntityTypeConfiguration<TipoRequerimiento>
{
    public void Configure(EntityTypeBuilder<TipoRequerimiento> builder)
    {
        builder.ToTable("tiporequerimiento");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Nombre).HasMaxLength(80).IsRequired();
        builder.Property(x => x.FechaCreacion);
        builder.Property(x => x.FechaModificacion);
    }
}
