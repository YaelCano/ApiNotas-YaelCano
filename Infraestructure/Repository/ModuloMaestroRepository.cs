using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraestructure.Data;

namespace Infraestructure.Repository
{
    public class ModuloMaestroRepository
    {
        private readonly ApiNotasContext _context;
        public ModuloMaestroRepository(ApiNotasContext context) : base(context)
        {
            _context = context;
        }

    }
}