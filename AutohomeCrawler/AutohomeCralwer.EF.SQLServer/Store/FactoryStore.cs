using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutohomeCralwer.Core;
using AutohomeCralwer.Core.Models;

namespace AutohomeCralwer.EF.SQLServer.Store
{
    public class FactoryStore : IFactoryStore
    {
        private readonly AutohomeDbContext _context;

        public FactoryStore(AutohomeDbContext context)
        {
            _context = context;
        }
        public Task PersistFactoriesAsync(IEnumerable<Factory> factories)
        {
            throw new NotImplementedException();
        }
    }
}
