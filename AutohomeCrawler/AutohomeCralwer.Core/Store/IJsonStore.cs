using System;
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
}
