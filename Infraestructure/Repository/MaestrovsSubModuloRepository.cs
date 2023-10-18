using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infraestructure.Data;

namespace Infraestructure.Repository;

public class MaestrovsSubModuloRepository : GenericRepository<IMaestrovsSubModulos>, IMaestrovsSubModulos
{
    private readonly ApiNotasContext _context;
    public MaestrovsSubModuloRepository(ApiNotasContext context) : base(context)
    {
        _context = context;
    }

}
