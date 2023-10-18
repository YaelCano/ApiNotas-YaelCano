using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace ApiNotas.Dtos
{
    public class TipoNotificacionDto
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificion { get; set; }
        public string NombreTipo { get; set; }
        public ICollection<BlockChain> BlockChains { get; set; }
        public ICollection<ModuloNotificaciones> ModuloNotificaciones { get; set; }
    }
}