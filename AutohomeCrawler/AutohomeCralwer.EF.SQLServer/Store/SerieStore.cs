using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutohomeCralwer.Core;
using AutohomeCralwer.Core.Models;
using System.Linq;

namespace AutohomeCralwer.EF.SQLServer.Store
{
    public class SerieStore : ISerieStore
    {
        private readonly AutohomeDbContext _context;

        public SerieStore(AutohomeDbContext context)
        {
            _context = context;
        }

        public async Task PersistSeriesAsync(IEnumerable<Serie> series)
        {
            var serieEntities = series.Select(t => new Entities.Serie
            {
                Id = t.Id,
                Name = t.Name,
                FirstLetter = t.FirstLetter,
                FactoryId = t.FactoryId,
                Order = t.Order,
                State = t.State
            });

            _context.Series.AddRange(serieEntities);
            await _context.SaveChangesAsync();
        }
    }
}
