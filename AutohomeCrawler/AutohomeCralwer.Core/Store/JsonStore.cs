using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AutohomeCralwer.Core
{
    public interface IJsonStore
    {
        // 从Store中获取已经获取过的品牌JSON数据
        Task<string> GetBrandJsonAsync();

        // 从Store中获取已经获取过的品牌的厂商、车系JSON数据
        Task<string> GetSeriesJsonOfBrandAsync(int brandId);

        // 从Store中获取已经获取的年限、车型JSON数据
        Task<string> GetCarTypesJsonOfSerieAsync(int serieId);

        /* 从Store中获取已经获取的车型JSON数据
        // 这个JSON和上一个不同，这个是详细的JSON数据且只包含同一个年限下的，
        // 上一个是包含车系下所有年限的车型信息且只包含简单的车型信息*/
        Task<string> GetCarTypesJsonOfSerieYearAsync(int serieId, int yearId);

        // 保存获取的JSON数据
        Task SaveBrandJsonAsync(string json);

        // 保存获取的品牌
        Task SaveSeriesJsonOfBrandAsync(int brandId, string json);

        // 保存获取的年限、车型JSON数据
        Task SaveCarTypesJsonOfSerieAsync(int serieId, string json);

        // 保存获取的详细车型数据
        Task SaveCarTypesJsonOfSerieYearAsync(int serieId, int yearId, string json);


    }

    public class FileJsonStore : IJsonStore
    {
        public Task<string> GetBrandJsonAsync()
        {
            var fileName = BuildBrandJsonFileName();
            return GetJsonAsync(fileName);
        }

        public Task<string> GetCarTypesJsonOfSerieAsync(int serieId)
        {
            var fileName = BuildCarTypesJsonOfSerie(serieId);
            return GetJsonAsync(fileName);
        }

        public Task<string> GetCarTypesJsonOfSerieYearAsync(int serieId, int yearId)
        {
            var fileName = BuildCarTypesJsonOfSerieYear(serieId, yearId);
            return GetJsonAsync(fileName);
        }

        public Task<string> GetSeriesJsonOfBrandAsync(int brandId)
        {
            var fileName = BuildSeriesJsonOfBrand(brandId);
            return GetJsonAsync(fileName);
        }

        public Task SaveBrandJsonAsync(string json)
        {
            var fileName = BuildBrandJsonFileName();
            return SaveJsonAsync(fileName, json);
        }

        public Task SaveCarTypesJsonOfSerieAsync(int serieId, string json)
        {
            var fileName = BuildCarTypesJsonOfSerie(serieId);
            return SaveJsonAsync(fileName, json);
        }

        public Task SaveCarTypesJsonOfSerieYearAsync(int serieId, int yearId, string json)
        {
            var fileName = BuildCarTypesJsonOfSerieYear(serieId, yearId);
            return SaveJsonAsync(fileName, json);
        }

        public Task SaveSeriesJsonOfBrandAsync(int brandId, string json)
        {
            var fileName = BuildSeriesJsonOfBrand(brandId);
            return SaveJsonAsync(fileName, json);
        }

        private async Task SaveJsonAsync(string fileName, string json)
        {
            using (var fileStream = new FileStream(fileName, FileMode.Create))
            {
                var bytes = Encoding.UTF8.GetBytes(json);
                await fileStream.WriteAsync(bytes, 0, bytes.Length);
                fileStream.Flush();
            }
        }

        private async Task<string> GetJsonAsync(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return string.Empty;
            }
            using (var fileStream = new FileStream(fileName, FileMode.Open))
            {
                var bytes = new byte[fileStream.Length];
                await fileStream.ReadAsync(bytes, 0, bytes.Length);
                return Encoding.UTF8.GetString(bytes);
            }
        }


        private string BuildBrandJsonFileName()
        {
            return Path.Combine(AppContext.BaseDirectory, "Brand.json");
        }

        private string BuildCarTypesJsonOfSerie(int serieId)
        {
            return Path.Combine(AppContext.BaseDirectory, $"CarTypesJsonOfSerie_{serieId}.json");
        }

        private string BuildCarTypesJsonOfSerieYear(int serieId, int yearId)
        {
            return Path.Combine(AppContext.BaseDirectory, $"CarTypesJsonOfSerie_{serieId}_Year_{yearId}.json");
        }

        private string BuildSeriesJsonOfBrand(int brandId)
        {
            return Path.Combine(AppContext.BaseDirectory, $"SeriesJsonOfBrand_{brandId}.json");
        }
    }
}
