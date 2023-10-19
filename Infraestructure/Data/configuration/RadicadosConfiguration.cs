using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.configuration
{
    public class RadicadosConfiguration :IEntityTypeConfiguration<Radicado>
    {
        public void Configure(EntityTypeBuilder<Radicado> builder)
        {
            builder.ToTable("radicados");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.FechaCreacion);
            builder.Property(x => x.FechaModificacion);
        }
    }
}