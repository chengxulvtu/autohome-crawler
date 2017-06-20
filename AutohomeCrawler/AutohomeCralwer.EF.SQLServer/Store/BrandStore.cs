using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutohomeCralwer.Core;
using AutohomeCralwer.Core.Models;

namespace AutohomeCralwer.EF.SQLServer.Store
{
    public class BrandStore : IBrandStore
    {
        private readonly AutohomeDbContext _context;

        public BrandStore(AutohomeDbContext context)
        {
            _context = context;
        }

        public async Task SaveBrandsAsync(IEnumerable<Brand> brands)
        {
            var brandEntities = brands.Select(t => new Entities.Brand
            {
                Id = t.Id,
                Name = t.Name,
                PinYin = t.PinYin,
                FirstLetter = t.BFirstLetter
            });

            _context.Brands.AddRange(brandEntities);

            await _context.SaveChangesAsync();
        }
    }
}
