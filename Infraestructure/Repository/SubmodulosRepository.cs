using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infraestructure.Data;

namespace Infraestructure.Repository
{
    public class SubmodulosRepository : GenericRepository<SubModulos>,ISubModulo
    {
        private readonly ApiNotasContext _context;
        public SubmodulosRepository(ApiNotasContext context):base(context)
        {
            _context = context;
        }
    }
}