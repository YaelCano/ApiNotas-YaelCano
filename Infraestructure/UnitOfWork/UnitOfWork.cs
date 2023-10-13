using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infraestructure.Data;

namespace Infraestructure.UnitOfWork;

public class UnitOfWork : IUnitOfwork, IDisposable
{
    private readonly ApiNotasContext _context;
    public UnitOfWork(ApiNotasContext context)
    {
        _context = context;
    }
    public IAuditoria _Auditorias;
    public IBlockChain _BlockChain;
    public IEstadoNotificacion _EstadoNotificacion;
    public IFormato  _Formatos;
    public IGenericosvsSubModulos _GenericosvsSubModulos;
    public IHiloRespuestaNot _HilosRespuesta;
    public IMaestrovsSubModulos _MaestrosvsSubmodulos;
    public IModulosNotificaciones _ModulosNotificaciones;
    public IModuloMaestros _ModulosMaestros;
    public IPermisosGenericos _PermisosGenericos;
    public IRadicados _Radicados;
    public IRol _Roles;
    public IRolvsMaestro _RolesvsMaestros;
    public ISubModulo _Submodulos;
    public ITipoNotificaciones _TipoNotificaciones;
    public ITipoRequerimiento _TiposRequerimientos;

    public IAuditoria Auditoria{
        get{
            if(_Auditorias == null){
                // _Auditorias = new 
            }
            return _Auditorias;
        }
    }

    public Task<int> SaveAsync()
    {
        return _context.SaveChangesAsync();
    }
    public void Dispose()
    {
        _context.Dispose();
    }
}