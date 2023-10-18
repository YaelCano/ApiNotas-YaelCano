using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace ApiNotas.Dtos
{
    public class HiloRespuestaDto
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string NombreHilo { get; set; }
        public ICollection<BlockChain> BlockChains { get; set; }
        public ICollection<ModuloNotificaciones> ModuloNoficaciones { get; set; }
    }
}