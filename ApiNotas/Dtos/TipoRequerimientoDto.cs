using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace ApiNotas.Dtos
{
    public class TipoRequerimientoDto
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string NombreTipo { get; set; }
        public ICollection<TipoRequerimiento> TipoRequerimientos { get; set; }
    }
}