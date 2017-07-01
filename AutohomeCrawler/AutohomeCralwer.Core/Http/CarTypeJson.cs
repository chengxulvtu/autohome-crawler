using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace AutohomeCralwer.Core.Http
{
    public interface ICarTypeJson
    {
        Task<string> GetJsonAsync(int serieId, int yearId);
    }

    public class CarTypeJson : ICarTypeJson
    {
        private readonly ILogger<CarTypeJson> _logger;

        public CarTypeJson(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<CarTypeJson>();
        }


        public async Task<string> GetJsonAsync(int serieId, int yearId)
        {
            _logger.LogInformation($"【开始】开始获取车系{serieId}年限{yearId}的车型JSON。");

            var requestUri = BuildRequestUri(serieId, yearId);

            var httpClient = new HttpClient();
            httpClient.Timeout = new TimeSpan(0, 2, 0);
            var html = await httpClient.GetStringAsync(requestUri);

            var startIndex = html.IndexOf("var config = {", StringComparison.CurrentCulture);
            var endIndex = html.IndexOf("var dealerPrices", StringComparison.CurrentCulture);

            if (startIndex != -1)
            {
                var json = html.Substring(startIndex, endIndex - startIndex).Trim();

                _logger.LogInformation($"【结束】获取车系{serieId}年限{yearId}的车型JSON。");

                return json;
            }
            return null;
        }


        private string BuildRequestUri(int serieId, int yearId)
        {
            return $"{Constant.AutohomeConfigUrl}/series/{serieId}-{yearId}.html";
        }

    }
}
