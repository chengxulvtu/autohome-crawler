using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace AutohomeCralwer.Core
{
    public interface ICralwer
    {
        Task CralwerAsync();
    }


    public class Cralwer : ICralwer
    {
        private readonly IBrandCralwer _brandCralwer;
        private readonly ISerieCralwer _serieCralwer;
        private readonly ICarTypeCralwer _carTypeCralwer;

        private readonly IBrandStore _brandStore;
        private readonly IFactoryStore _factoryStore;

        public Cralwer(IBrandCralwer brandCralwer,
                               ISerieCralwer serieCralwer,
                               ICarTypeCralwer carTypeCralwer,
                               IBrandStore brandStore,
                               IFactoryStore factoryStore)
        {
            _brandCralwer = brandCralwer;
            _serieCralwer = serieCralwer;
            _carTypeCralwer = carTypeCralwer;

            _brandStore = brandStore;
            _factoryStore = factoryStore;
        }

        public async Task CralwerAsync()
        {
            IEnumerable<Models.Brand> persistedBrands = new List<Models.Brand>();
            var toBePersistBrands = new List<Models.Brand>();
            var brands = await _brandCralwer.GetBrandsAsync(Models.GetBrandType.Normal);
            if (brands.Any())
            {
                persistedBrands = await _brandStore.GetBrandsAsync();

                foreach (var b in brands)
                {
                    if (!persistedBrands.Any(t => t.Id == b.Id))
                    {
                        toBePersistBrands.Add(b);
                    }
                }

                //brands集合包含元素说明本次与上次发生了变化
                await _brandStore.PersistBrandsAsync(toBePersistBrands);
            }

            persistedBrands = persistedBrands.Concat(toBePersistBrands);

            var allFactories = new List<Models.Factory>();

            foreach (var brand in persistedBrands)
            {
                var factories = await _serieCralwer.GetFactoriesAsync(brand.Id, Models.GetSerieType.All);
                allFactories.AddRange(factories);
            }

            await _factoryStore.PersistFactoriesAsync(allFactories);


        }
    }
}
