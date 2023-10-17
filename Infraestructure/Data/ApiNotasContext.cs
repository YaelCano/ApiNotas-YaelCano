using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data;

public class ApiNotasContext : DbContext
{
    public ApiNotasContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Auditoria> Auditorias { get; set; }
    public DbSet<BlockChain> BlockChains { get; set; }
    public DbSet<EstadoNotificacion> EstadoNotificacions { get; set; }
    public DbSet<Formatos> Formatos { get; set; }
    public DbSet<GenericosvsSubmodulos> genericosvsSubmodulos { get; set; }
    public DbSet<HiloRespuestaNotificaciones> HiloRespuetasNot { get; set; }
    public DbSet<MaestrosvsSubmodulos> MaestrosvsSubmodulos { get; set; }
    public DbSet<ModuloNotificaciones> ModuloNotificaciones { get; set; }
    public DbSet<ModulosMaestros> ModulosMaestros { get; set; }
    public DbSet<PermisosGenericos> PermisosGenericos { get; set; }
    public DbSet<Radicado> Radicados { get; set; }
    public DbSet<Rol> Rol { get; set; }
    public DbSet<RolvsMaestro> RolvsMaestros { get; set; }
    public DbSet<SubModulos> SubModulos { get; set; }
    public DbSet<TipoNotificaciones> TipoNotificaciones { get; set; }
    public DbSet<TipoRequerimiento> TipoRequerimientos { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    public async Task<int> SaveAsync()
    {
        return await base.SaveChangesAsync();
    }
}

