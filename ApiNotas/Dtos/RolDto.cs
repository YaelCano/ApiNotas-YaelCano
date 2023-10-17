using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace ApiNotas.Dtos;

    public class RolDto
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Nombre { get; set; }
        public ICollection<RolvsMaestro> RolvsMaestros {get; set;}
        public ICollection<IGenericosvsSubModulos> GenericosvsSubModulos {get; set;}
    }
