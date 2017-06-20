using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AutohomeCralwer.Core.Http;
using AutohomeCralwer.Core.Models;
using AutohomeCralwer.Core.Parser;
using Newtonsoft.Json;

namespace AutohomeCralwer.Core
{
    // 爬取品牌
    public class BrandCralwer : IBrandCralwer
    {
        private readonly IJsonStore _jsonStore;
        private readonly IBrandJson _brandJson;
        private readonly IBrandParser _brandParser;
        private readonly IBrandStore _brandStore;

        public BrandCralwer(IJsonStore jsonStore, IBrandJson brandJson, IBrandParser brandParser, IBrandStore brandStore)
        {
            _jsonStore = jsonStore;
            _brandJson = brandJson;
            _brandParser = brandParser;
            _brandStore = brandStore;
        }

        public async Task<IEnumerable<Brand>> GetBrandsAsync(GetBrandType type)
        {
            var brandJson = await _brandJson.GetJsonAsync(type);
            if (!string.IsNullOrWhiteSpace(brandJson))
            {
                await _jsonStore.SaveBrandJsonAsync(brandJson);
            }
            var brands = _brandParser.Parse(brandJson);

            await _brandStore.PersistBrandsAsync(brands);

            return brands;
        }
    }
}
