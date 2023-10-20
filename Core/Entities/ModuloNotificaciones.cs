using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class ModuloNotificaciones : BaseEntity
    {
        public string AsuntoNotificacion { get; set; }
        public string TextoNotificacion { get; set; }
        public TipoNotificaciones TipoNotificacione { get; set; }
        public int IdNotificacionFk { get; set; }
        public Radicado Radicado { get; set; }
        public int IdRadicado { get; set; }
        public EstadoNotificacion EstadoNot { get; set; }
        public int IdEstadoNotificacionFk { get; set; }
        public HiloRespuestaNotificaciones HiloRespuestaNot { get; set; }
        public int IdHiloRespuestaFk { get; set; }
        public Formatos Formatos { get; set; }
        public int IdFormatoFk { get; set; }
        public TipoRequerimiento TpRequerimiento { get; set; }
        public int IdRequerimiento { get; set; }

    }
