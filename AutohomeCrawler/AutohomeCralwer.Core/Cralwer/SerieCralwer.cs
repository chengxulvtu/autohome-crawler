using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AutohomeCralwer.Core.Models;
using Newtonsoft.Json;
using AutohomeCralwer.Core.Http;
using AutohomeCralwer.Core.Parser;

namespace AutohomeCralwer.Core
{
    public interface ISerieCralwer
    {
        Task<IEnumerable<Factory>> GetFactoriesAsync(int brandId, GetSerieType type);
    }

    public class SerieCralwer : ISerieCralwer
    {
        private readonly ISerieJson _serieJson;
        private readonly ISerieParser _serieParser;

        public SerieCralwer(ISerieJson serieJson, ISerieParser serieParser)
        {
            _serieJson = serieJson;
            _serieParser = serieParser;
        }

        // 获取厂商和车系
        public async Task<IEnumerable<Factory>> GetFactoriesAsync(int brandId, GetSerieType type)
        {
            var json = await _serieJson.GetJsonAsync(brandId, type);

            var factories = _serieParser.Parse(brandId, json);
            return factories;
        }
    }
}
