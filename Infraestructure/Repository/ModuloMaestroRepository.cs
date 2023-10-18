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
    public class ModuloMaestroRepository : GenericRepository<ModulosMaestros> ,IModuloMaestros
    {
        private readonly ApiNotasContext _context;
        public ModuloMaestroRepository(ApiNotasContext context) : base(context)
        {
            _context = context;
        }

    }
}