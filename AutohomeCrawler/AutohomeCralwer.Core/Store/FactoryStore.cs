using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutohomeCralwer.Core.Models;


namespace AutohomeCralwer.Core
{
    public interface IFactoryStore
    {
        Task PersistFactoriesAsync(IEnumerable<Factory> factories);
    }


    public class FactoryStore : IFactoryStore
    {
        public Task PersistFactoriesAsync(IEnumerable<Factory> factories)
        {
            return Task.CompletedTask;
        }
    }
}
