using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infraestructure.Data;
using Infrastructure.Repository;

namespace Infraestructure.Repository
{
    public class TipoRequerimientosRepository : GenericRepository<TipoRequerimiento>,ITipoRequerimiento
    {
        private readonly ApiNotasContext _context;
        public TipoRequerimientosRepository(ApiNotasContext context):base(context)
        {
            _context = context;
        }
    }
}