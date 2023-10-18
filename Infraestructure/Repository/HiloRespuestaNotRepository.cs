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
    public class HiloRespuestaNotRepository : GenericRepository<HiloRespuestaNotificaciones>, IHiloRespuestaNot
    {
        private readonly ApiNotasContext _context;

        public HiloRespuestaNotRepository(ApiNotasContext context) : base(context)
        {
            _context = context;
        }
    }
}