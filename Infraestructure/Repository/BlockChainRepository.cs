using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infraestructure.Data;

namespace Infraestructure.Repository
{
    public class BlockChainRepository : GenericRepository<BlockChain>, IBlockChain
    {
        private readonly ApiNotasContext _context;
        public BlockChainRepository(ApiNotasContext context) : base(context)
        {
            _context = context;
        }
    }
}