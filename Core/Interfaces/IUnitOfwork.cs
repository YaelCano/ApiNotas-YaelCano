using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        IAuditoria Auditoria{ get; }
        IBlockChain BlockChain{ get; }
        IEstadoNotificacion EstadoNotificacion { get; }
        IFormato Formato{ get; }
        IGenericosvsSubModulos GenericosvsSubModulos{ get; }
        IHiloRespuestaNot HiloRespuestaNot{ get; }
        IMaestrovsSubModulos MaestrovsSubModulos{ get; }
        IModuloMaestros ModuloMaestros{ get; }
        IModulosNotificaciones ModulosNotificaciones{ get; }
        IPermisosGenericos PermisosGenericos{ get; }
        IRadicados Radicados{ get; }
        IRol Rol{ get; }
        IRolvsMaestro RolvsMaestro{ get; }
        ISubModulo SubModulo{ get; }
        ITipoNotificaciones TipoNotificaciones{ get; }
        ITipoRequerimiento TipoRequerimiento{ get; }
        
        Task<int> SaveAsync();
    }
}
