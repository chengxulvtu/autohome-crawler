using System;
using System.Collections.Generic;
using AutohomeCralwer.Core.Models;
using System.Threading.Tasks;

namespace AutohomeCralwer.Core
{
    public interface ISerieStore
    {
        Task PersistSeriesAsync(IEnumerable<Serie> series);
    }

    public class SerieStore : ISerieStore
    {
        public Task PersistSeriesAsync(IEnumerable<Serie> series)
        {
            return Task.CompletedTask;
        }
    }
}
