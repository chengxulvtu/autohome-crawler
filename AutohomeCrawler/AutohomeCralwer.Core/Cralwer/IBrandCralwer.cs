using System;
using AutohomeCralwer.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutohomeCralwer.Core
{
    public interface IBrandCralwer
    {
        Task<IEnumerable<Brand>> GetBrandsAsync(GetBrandType type);
    }
}
