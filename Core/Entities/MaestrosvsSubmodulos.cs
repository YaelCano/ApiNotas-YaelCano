using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class MaestrosvsSubmodulos : BaseEntity
    {
        public ModulosMaestros Maestros { get; set; }
        public int IdMaestro { get; set; }
        public SubModulos subModulos { get; set; }
        public int IdSubModulo { get; set; }
        public ICollection<GenericosvsSubmodulos> GenericosvsSubModulos {get; set;}

    }
