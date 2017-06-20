using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutohomeCralwer.Core.Models;

namespace AutohomeCralwer.Core
{
    public interface IBrandStore
    {
        Task SaveBrandsAsync(IEnumerable<Brand> brands);
    }

    public class BrandStore : IBrandStore
    {
        public Task SaveBrandsAsync(IEnumerable<Brand> brands)
        {
            return Task.CompletedTask;
        }
    }
}
