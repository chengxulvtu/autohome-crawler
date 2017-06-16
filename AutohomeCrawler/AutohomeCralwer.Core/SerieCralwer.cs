using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutohomeCralwer.Core.Models;

namespace AutohomeCralwer.Core
{
    public class SerieCralwer : ISerieCralwer
    {
        public async Task<IEnumerable<Serie>> GetSeriesAsync(GetBrandType type)
        {
            throw new NotImplementedException();
        }
    }
}
