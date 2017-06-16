using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AutohomeCralwer.Core.Models;
using Newtonsoft.Json;

namespace AutohomeCralwer.Core
{
    public class BrandCralwer : IBrandCralwer
    {
        public async Task<IEnumerable<Brand>> GetBrandsAsync(GetBrandType type)
        {
            var requestUri = BuildRequestUri(type);

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
            var res = await httpClient.GetAsync(requestUri);
            var result = await httpClient.GetStringAsync(requestUri);

            var dic = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);
            var brands = JsonConvert.DeserializeObject<IEnumerable<Brand>>(dic["result"].branditems.ToString());

            return brands;
        }


        private string BuildRequestUri(GetBrandType type)
        {
            return $"{Constant.BrandUri}?type={(int)type}";
        }
    }
}
