using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutohomeCralwer.Core
{
    public interface ICralwer
    {
        Task<IEnumerable<T>> Get<T>() where T : class;
    }
}
