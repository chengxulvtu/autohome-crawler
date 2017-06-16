using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AutohomeCralwer.Core.Models;
using Newtonsoft.Json;

namespace AutohomeCralwer.Core
{
    public class SerieCralwer : ISerieCralwer
    {
        // 获取厂商和车系
        public async Task<IEnumerable<Factory>> GetFactoriesAsync(int brandId, GetSerieType type)
        {
            var json = await GetSeriesJsonOfBrand(brandId, type);

            var dic = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(json);
            var factoryItems = dic["result"].factoryitems.ToString();

            var factories = JsonConvert.DeserializeObject<List<Factory>>(factoryItems);

            foreach (var factory in factories)
            {
                factory.BrandId = brandId;

                foreach (var series in factory.Series)
                {
                    series.FactoryId = factory.Id;
                    series.Factory = factory.Name;
                    series.BrandId = brandId;
                }
            }

            return factories;
        }


        // 获取品牌下的厂商和车系Json数据
        private async Task<string> GetSeriesJsonOfBrand(int brandId, GetSerieType type)
        {
            var requestUri = BuildRequestUri(brandId, type);

            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync(requestUri);
            return json;
        }


        // 构造请求地址
        private string BuildRequestUri(int brandId, GetSerieType type)
        {
            return $"{Constant.AutohomeUri}?type={(int)type}&value={brandId}";
        }
    }
}
