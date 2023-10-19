using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class GenericosvsSubmodulos : BaseEntity
    {
        public PermisosGenericos PermisosGenericos { get; set; }
        public int IdPermisosFk { get; set; }
        public Rol Roles { get; set; }
        public int IdRolFk { get; set; }
        public MaestrosvsSubmodulos MaestrosvsSubmodulos { get; set; }
        public int IdSubModulos { get; set; }

    }
