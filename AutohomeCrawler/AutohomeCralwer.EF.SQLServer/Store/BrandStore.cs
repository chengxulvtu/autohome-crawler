using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutohomeCralwer.Core;
using AutohomeCralwer.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace AutohomeCralwer.EF.SQLServer.Store
{
    public class BrandStore : IBrandStore
    {
        private readonly AutohomeDbContext _context;

        public BrandStore(AutohomeDbContext context)
        {
            _context = context;
        }

        public async Task PersistBrandsAsync(IEnumerable<Brand> brands)
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

        public async Task<IEnumerable<Brand>> GetBrandsAsync()
        {
            var brandEntities = await _context.Brands.ToListAsync();

            return brandEntities.Select(t => new Brand
            {
                Id = t.Id,
                Name = t.Name,
                BFirstLetter = t.FirstLetter,
                PinYin = t.PinYin
            });
        }

    }
}
