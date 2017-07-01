using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutohomeCralwer.Core.Models;

namespace AutohomeCralwer.Core
{
    public interface IBrandStore
    {
        /// <summary>
        /// 持久化品牌到Store中
        /// </summary>
        Task PersistBrandsAsync(IEnumerable<Brand> brands);

        /// <summary>
        /// 获取已经持久化的品牌集合
        /// </summary>
        /// <returns>品牌集合</returns>
        Task<IEnumerable<Brand>> GetBrandsAsync();
    }

    public class BrandStore : IBrandStore
    {
        public Task PersistBrandsAsync(IEnumerable<Brand> brands)
        {
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Brand>> GetBrandsAsync()
        {
            IEnumerable<Brand> brands = new List<Brand>();
            return Task.FromResult(brands);
        }

    }
}
