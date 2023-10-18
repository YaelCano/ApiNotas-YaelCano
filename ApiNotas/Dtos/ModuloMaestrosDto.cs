using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace ApiNotas.Dtos
{
    public class ModuloMaestrosDto
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string NombreModulo { get; set; }
        public ICollection<RolvsMaestro> RolvsMaestros { get; set; }
        public ICollection<MaestrosvsSubmodulos> MaestrosvsSubModulos { get; set; }
    }
}