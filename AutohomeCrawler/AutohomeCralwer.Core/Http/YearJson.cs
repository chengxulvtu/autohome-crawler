using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AutohomeCralwer.Core.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AutohomeCralwer.Core.Http
{
    public interface IYearJson
    {
        Task<string> GetJsonAsync(int serieId, GetCarTypeType type);
    }

    public class YearJson : IYearJson
    {
        private readonly ILogger<YearJson> _logger;

        public YearJson(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<YearJson>();
        }

        public async Task<string> GetJsonAsync(int serieId, GetCarTypeType type)
        {
            _logger.LogInformation($"开始获取车系{serieId}的年限JSON。");

            var requestUri = BuildRequestUri(serieId, type);

            var httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync(requestUri);

            var dic = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);

            var returnCode = dic["returncode"].ToString();
            if (returnCode == "0")
            {
                var json = dic["result"].factoryitems.ToString();

                _logger.LogInformation($"获取车系{serieId}的年限JSON结束。");

                return json;
            }
            else
            {
                _logger.LogError($"获取车系{serieId}的年限JSON错误，错误码：{returnCode}，错误信息：{dic["message"].ToString()}.");
                return null;
            }
        }


        // 构造请求地址
        private string BuildRequestUri(int serieId, GetCarTypeType type)
        {
            return $"{Constant.AutohomeUrl}?type={(int)type}&value={serieId}";
        }
    }
}
