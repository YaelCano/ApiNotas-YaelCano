using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.configuration
{
    public class ModuloNotificacionesConfiguration : IEntityTypeConfiguration<ModuloNotificaciones>
    
    {
    public void Configure(EntityTypeBuilder<ModuloNotificaciones> builder)
        {
            builder.ToTable("ModuloNotificaciones");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.asuntoNotificacion).HasMaxLength(80).IsRequired();
            builder.Property(x => x.FechaCreacion);
            builder.Property(x => x.FechaModificacion);


            builder.HasOne(M => M.Radicados)
            .WithMany(N => N.ModuloNoficaciones)
            .HasForeignKey(M => M.IdRadicado);

            builder.HasOne(M => M.Formatos)
            .WithMany(F => F.ModuloNoficaciones)
            .HasForeignKey(M => M.IdFormatoFk);

            builder.HasOne(M => M.TpRequerimiento)
            .WithMany(T => T.ModuloNoficaciones)
            .HasForeignKey(M => M.IdRequerimiento);

            builder.HasOne(M => M.TipoNotificacione)
            .WithMany(T => T.ModuloNoficaciones)
            .HasForeignKey(M => M.IdEstadoNotificacionFk);

            builder.HasOne(M => M.HiloRespuestaNot)
            .WithMany(H => H.ModuloNoficaciones)
            .HasForeignKey(M => M.IdHiloRespuestaFk);

            builder.HasOne(M => M.EstadoNot)
            .WithMany(E => E.ModuloNoficaciones)
            .HasForeignKey(M => M.IdEstadoNotificacionFk);
        }
    }
}