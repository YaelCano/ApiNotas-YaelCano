using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNotas.Dtos;

    public class ModuloNotificacionDto
    {
        public int Id { get; set; }
        public DateTime Fechacreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string AsuntoNotifcacion { get; set; }
        public string TextoNotificacion { get; set; }
    }
