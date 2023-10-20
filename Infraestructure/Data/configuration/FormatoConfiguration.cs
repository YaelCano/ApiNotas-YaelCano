using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.configuration
{
    public class FormatoConfiguration  : IEntityTypeConfiguration<Formatos>
    {
        public void Configure(EntityTypeBuilder<Formatos> builder)
        {
            builder.ToTable("formatos");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.NombreFormatos).IsRequired().HasMaxLength(50);
            builder.Property(x => x.FechaCreacion);
            builder.Property(x => x.FechaModificacion);
        }
    }
}