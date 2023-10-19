using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.configuration
{
    public class MaestrosvsSubModConfiguration : IEntityTypeConfiguration<MaestrosvsSubmodulos>
    {
            public void Configure(EntityTypeBuilder<MaestrosvsSubmodulos> builder)
    {
        builder.ToTable("maestrosvssubmodulos");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.FechaCreacion);
        builder.Property(x => x.FechaModificacion);

        builder.HasOne(M => M.ModulosMaestros)
        .WithMany(M => M.MaestrosVsSubmodulos)
        .HasForeignKey(M => M.IdMaestro);

        builder.HasOne(M => M.SubModulos)
        .WithMany(S => S.MaestrosVsSubmodulos)
        .HasForeignKey(M => M.IdSubmodulo);
    }
    }
}