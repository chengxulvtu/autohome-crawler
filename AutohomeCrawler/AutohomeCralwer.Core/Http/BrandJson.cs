using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AutohomeCralwer.Core.Models;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;

namespace AutohomeCralwer.Core.Http
{
    public interface IBrandJson
    {
        Task<string> GetJsonAsync(GetBrandType type);
    }


    public class BrandJson : IBrandJson
    {
        private readonly ILogger<BrandJson> _logger;

        public BrandJson(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<BrandJson>();
        }

        // 从汽车之家获取品牌的JSON数据
        public async Task<string> GetJsonAsync(GetBrandType type)
        {
            _logger.LogInformation("开始获取品牌的JSON");

            var requestUri = BuildRequestUri(type);

            var httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync(requestUri);

            var dic = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);

            var returnCode = dic["returncode"].ToString();
            if (returnCode == "0")
            {
                var json = dic["result"].branditems.ToString();

                _logger.LogInformation("获取品牌的JSON结束");

                return json;
            }
            else
            {
                _logger.LogError($"获取品牌的JSON错误，错误码：{returnCode}，错误信息：{dic["message"].ToString()}.");
                return null;
            }
        }


        private string BuildRequestUri(GetBrandType type)
        {
            return $"{Constant.AutohomeUrl}?type={(int)type}";
        }
    }
}
