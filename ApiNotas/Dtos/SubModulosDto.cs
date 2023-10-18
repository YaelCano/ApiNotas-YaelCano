using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace ApiNotas.Dtos
{
    public class SubModulosDto
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string NombreSubmodulo { get; set; }
        public ICollection<MaestrosvsSubmodulos> MaestrosvsSubmodulos { get; set; }
    }
}