using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AutohomeCralwer.Core
{
    public class FileJsonStore : IJsonStore
    {
        public Task<string> GetBrandJsonAsync()
        {
            var fileName = BuildBrandJsonFileName();

        }

        public Task<string> GetCarTypesJsonOfSerieAsync(int serieId, int yearId)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetCarTypesJsonOfSerieAsync(int serieId)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetCarTypesJsonOfSerieYearAsync(int serieId, int yearId)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetSeriesJsonOfBrandAsync(int brandId)
        {
            throw new NotImplementedException();
        }

        public Task SaveBrandJsonAsync(string json)
        {
            var fileName = BuildBrandJsonFileName();
            return SaveJsonAsync(fileName, json);
        }

        public Task SaveCarTypesJsonOfSerieAsync(int serieId, string json)
        {
            var fileName = BuildCarTypesJsonOfSerieAsync(serieId);
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

        private async Task GetJsonAsync(string fileName)
        {
            using (var fileStream = new FileStream(fileName, FileMode.Open))
            {

            }
        }


        private string BuildBrandJsonFileName()
        {
            return Path.Combine(AppContext.BaseDirectory, "Brand.json");
        }

        private string BuildCarTypesJsonOfSerieAsync(int serieId)
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
