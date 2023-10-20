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
    public IFormato _Formatos;
    public IEstadoNotificacion _EstadoNotificacion;
    public IGenericosvsSubModulos _GenericosvsSubModulos;
    public IHiloRespuestaNot _HilosRespuesta;
    public IMaestrovsSubModulos _MaestrosvsSubmodulos;
    public IModulosNotificaciones _ModulosNotificaciones;
    public IModuloMaestros _ModulosMaestros;
    public IPermisosGenericos _PermisosGenericos;
    public IRadicados _Radicados;
    public IRol _Rol;
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
    public IBlockChain BlockChain
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
        }
    }

        public IFormato Formatos
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
    public IModuloMaestros ModuloMaestros
    {
        get
        {
            if (_ModulosMaestros == null)
            {
                _ModulosMaestros = new ModuloMaestroRepository(_context);
            }
            return _ModulosMaestros;
        }
    }
    public IModulosNotificaciones ModulosNotificaciones
    {
        get
        {
            if (_ModulosNotificaciones == null)
            {
                _ModulosNotificaciones = new ModuloNotificacionesRepository(_context);
            }
            return _ModulosNotificaciones;
        }
    }
    public IPermisosGenericos PermisosGenericos
    {
        get
        {
            if (_PermisosGenericos == null)
            {
                _PermisosGenericos = new PermisosGenericosRepository(_context);
            }
            return _PermisosGenericos;
        }
    }
    public IRadicados Radicados
    {
        get
        {
            if (_Radicados == null)
            {
                _Radicados = new RadicadoRepository(_context);
            }
            return _Radicados;
        }
    }
    public IRol Rol 
    {
        get
        {
            if (_Rol == null)
            {
                _Rol = new RolRepository(_context);
            }
            return _Rol;
        }
    }
    public IRolvsMaestro RolvsMaestro
    {
        get
        {
            if (_RolesvsMaestros == null)
            {
                _RolesvsMaestros = new RolvsMaestroRepository(_context);
            }
            return _RolesvsMaestros;
        }
    }
    public ISubModulo SubModulo
    {
        get
        {
            if (_Submodulos == null)
            {
                _Submodulos = new SubmodulosRepository(_context);
            }
            return _Submodulos;
        }
    }


    public ITipoNotificaciones TipoNotificaciones
    {
        get
        {
            if (_TipoNotificaciones == null)
            {
                _TipoNotificaciones = new TipoNotificacionesRepository(_context);
            }
            return _TipoNotificaciones;
        }
    }
    public ITipoRequerimiento TipoRequerimiento
    {
        get
        {
            if (_TiposRequerimientos == null)
            {
                _TiposRequerimientos = new TipoRequerimientosRepository(_context);
            }
            return _TiposRequerimientos;
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