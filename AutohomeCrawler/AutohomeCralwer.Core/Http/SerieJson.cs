using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AutohomeCralwer.Core.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AutohomeCralwer.Core.Http
{
    public interface ISerieJson
    {
        Task<string> GetJsonAsync(int brandId, GetSerieType type);
    }

    public class SerieJson : ISerieJson
    {
        private readonly ILogger<SerieJson> _logger;

        public SerieJson(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<SerieJson>();
        }

        public async Task<string> GetJsonAsync(int brandId, GetSerieType type)
        {
            _logger.LogInformation($"开始获取品牌{brandId}的车系JSON。");

            var requestUri = BuildRequestUri(brandId, type);

            var httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync(requestUri);

            var dic = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);

            var returnCode = dic["returncode"].ToString();
            if (returnCode == "0")
            {
                var json = dic["result"].factoryitems.ToString();

                _logger.LogInformation($"获取品牌{brandId}的车系JSON结束。");

                return json;
            }
            else
            {
                _logger.LogError($"获取品牌{brandId}的车系JSON错误，错误码：{returnCode}，错误信息：{dic["message"].ToString()}.");
                return null;
            }

        }

        // 构造请求地址
        private string BuildRequestUri(int brandId, GetSerieType type)
        {
            return $"{Constant.AutohomeUrl}?type={(int)type}&value={brandId}";
        }
    }
}
