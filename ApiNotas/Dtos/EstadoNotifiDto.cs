using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace ApiNotas.Dtos;

    public class EstadoNotifiDto
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModififcacion { get; set; }
        public string NombreEstado { get; set; }
        public ICollection<ModuloNotificaciones> ModuloNotificaciones { get; set; }
    }
