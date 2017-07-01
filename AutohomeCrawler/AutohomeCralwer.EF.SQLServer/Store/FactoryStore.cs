using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutohomeCralwer.Core;
using AutohomeCralwer.Core.Models;
using System.Linq;

namespace AutohomeCralwer.EF.SQLServer.Store
{
    public class FactoryStore : IFactoryStore
    {
        private readonly AutohomeDbContext _context;

        public FactoryStore(AutohomeDbContext context)
        {
            _context = context;
        }
        public async Task PersistFactoriesAsync(IEnumerable<Factory> factories)
        {
            var factoryEntities = factories.Select(t => new Entities.Factory
            {
                Id = t.Id,
                Name = t.Name,
                FirstLetter = t.FirstLetter,
                BrandId = t.BrandId
            });

            _context.Factories.AddRange(factoryEntities);
            await _context.SaveChangesAsync();
        }
    }
}
