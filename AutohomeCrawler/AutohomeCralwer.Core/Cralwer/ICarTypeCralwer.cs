using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutohomeCralwer.Core.Models;

namespace AutohomeCralwer.Core
{
    public interface ICarTypeCralwer
    {
        Task<IEnumerable<Year>> GetYears(int serieId);
    }
}
