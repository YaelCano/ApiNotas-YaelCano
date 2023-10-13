using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infraestructure.Data;

namespace Infraestructure.Repository
{
    public class FormatoRepository : GenericRepository<Formatos>, IFormato
    {
        private readonly ApiNotasContext _context;
        public FormatoRepository(ApiNotasContext context) : base(context)
        {
            _context = context;
        }
    }
}