using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infraestructure.Data;

namespace Infraestructure.Repository
{
    public class GenericovsModulosRepository : GenericRepository<GenericosvsSubmodulos>,  IGenericosvsSubModulos
    {
        private readonly ApiNotasContext _context;
        public GenericovsModulosRepository(ApiNotasContext context): base(context)
        {
            _context = context;
        }
    }
}