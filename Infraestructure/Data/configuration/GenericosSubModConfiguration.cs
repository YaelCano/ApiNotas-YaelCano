using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data.configuration
{
    public class GenericosSubModConfiguration : IEntityTypeConfiguration<GenericosvsSubmodulos>
{
    
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<GenericosvsSubmodulos> builder)
    {
            builder.ToTable("GenericosvsSubModulos");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(w => w.FechaCreacion)
            .HasColumnType("DateTime");
            builder.Property(w => w.FechaModificacion)
            .HasColumnType("DateTime");

            builder.HasOne(p => p.PermisosGenericos)
            .WithMany(P => P.GenericosvsSubModulos)
            .HasForeignKey(p => p.IdPermisosFk);

            builder.HasOne(p => p.MaestrosvsSubmodulos)
            .WithMany(p => p.GenericosvsSubModulos)
            .HasForeignKey(p => p.IdSubModulos);

            builder.HasOne(p => p.Roles)
            .WithMany(p => p.GenericosvsSubModulos)
            .HasForeignKey(p => p.IdRolFk);
    }
    }
}