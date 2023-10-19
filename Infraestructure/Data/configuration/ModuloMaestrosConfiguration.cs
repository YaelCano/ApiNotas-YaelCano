using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infraestructure.Data.configuration
{
    public class ModuloMaestrosConfiguration : IEntityTypeConfiguration<ModulosMaestros>
    {
    public void Configure(EntityTypeBuilder<ModulosMaestros> builder)
    {
        builder.ToTable("modulosmaestros");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.NombreModulo).IsRequired().HasMaxLength(100);
        builder.Property(x => x.FechaCreacion);
        builder.Property(x => x.FechaModificacion);
    }
    }
}