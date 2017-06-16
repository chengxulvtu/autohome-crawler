using System;
using System.IO;
using System.Text;

namespace AutohomeCralwer.Core
{
    public class FileJsonStore : IJsonStore
    {
        public string GetBrandJson()
        {
            throw new NotImplementedException();
        }

        public string GetCarTypesJsonOfSerie(int serieId, int yearId)
        {
            throw new NotImplementedException();
        }

        public string GetCarTypesJsonOfSerie(int serieId)
        {
            throw new NotImplementedException();
        }

        public string GetCarTypesJsonOfSerieYear(int serieId, int yearId)
        {
            throw new NotImplementedException();
        }

        public string GetSeriesJsonOfBrand(int brandId)
        {
            throw new NotImplementedException();
        }

        public void SaveBrandJson(string json)
        {
            var fileName = Path.Combine(AppContext.BaseDirectory, "brand.json");
            using (var fileStream = new FileStream(fileName, FileMode.Create))
            {
                var bytes = Encoding.UTF8.GetBytes(json);
                fileStream.WriteAsync(bytes, 0, bytes.Length);
                fileStream.Flush();
            }
        }

        public void SaveCarTypesJsonOfSerie(int serieId, string json)
        {
            throw new NotImplementedException();
        }

        public void SaveCarTypesJsonOfSerieYear(int serieId, int yearId)
        {
            throw new NotImplementedException();
        }

        public void SaveSeriesJsonOfBrand(int brandId, string json)
        {
            throw new NotImplementedException();
        }
    }
}
