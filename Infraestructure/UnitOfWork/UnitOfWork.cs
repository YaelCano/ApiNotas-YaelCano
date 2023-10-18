using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infraestructure.Data;
using Infraestructure.Repository;


namespace Infraestructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ApiNotasContext _context;
    public UnitOfWork(ApiNotasContext context)
    {
        _context = context;
    }
    public IAuditoria _Auditorias;
    public IBlockChain _BlockChain;
    public IEstadoNotificacion _EstadoNotificacion;
    public IFormato _Formatos;
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

    public IAuditoria Auditoria
    {
        get
        {
            if (_Auditorias == null)
            {
                _Auditorias = new AuditoriaRepository(_context);
            }
            return _Auditorias;
        }
    }
    public IBlockChain Blockchain
    {
        get
        {
            if (_BlockChain == null)
            {
                _BlockChain = new BlockChainRepository(_context);
            }
            return _BlockChain;
        }
    }
    public IEstadoNotificacion EstadoNotificacion
    {
        get
        {
            if (_EstadoNotificacion == null)
            {
                _EstadoNotificacion = new EstadoNotificacionRepository(_context);
            }
            return _EstadoNotificacion;
            {

            }
        }
    }
    public IFormato Formato
    {
        get
        {
            if (_Formatos == null)
            {
                _Formatos = new FormatoRepository(_context);
            }
            return _Formatos;
        }
    }
    public IGenericosvsSubModulos GenericosvsSubModulos
    {
        get
        {
            if (_GenericosvsSubModulos == null)
            {
                _GenericosvsSubModulos = new GenericovsModulosRepository(_context);
            }
            return _GenericosvsSubModulos;
        }
    }
    public IHiloRespuestaNot HiloRespuestaNot
    {
        get
        {
            if (_HilosRespuesta == null)
            {
                _HilosRespuesta = new HiloRespuestaNotRepository(_context);
            }
            return _HilosRespuesta;
        }
    }
    public IMaestrovsSubModulos MaestrovsSubModulos
    {
        get
        {
            if (_MaestrosvsSubmodulos == null)
            {
                _MaestrosvsSubmodulos = new MaestrovsSubModuloRepository(_context);
            }
            return _MaestrosvsSubmodulos;
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