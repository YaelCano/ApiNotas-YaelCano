using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infraestructure.Data;

namespace Infraestructure.Repository;

    public class AuditoriaRepository : GenericRepository<Auditoria>, IAuditoria
    {
        private readonly ApiNotasContext  _context;
        public AuditoriaRepository(ApiNotasContext context) : base(context)
        {
            _context = context;
        }
    }
