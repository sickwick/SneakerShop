using System.Collections.Generic;
using System.Threading.Tasks;
using Shop.Database.Stubs;
using Newtonsoft.Json;

namespace Shop.Database
{
    public class MainDatabase : DatabaseBase
    {
        private readonly ProductsStub _productsStub;

        public MainDatabase()
        {
            _productsStub = new ProductsStub();
        }

        public override Task<List<TModel>> GetDatabaseList<TModel>()
        {
            return Task.FromResult(
                JsonConvert.DeserializeObject<List<TModel>>(JsonConvert.SerializeObject(_productsStub.Products)));
        }

        public override void AddInDatabase<TModel>(TModel model)
        {
            throw new System.NotImplementedException();
        }

        public override void ChangeModelInDatabase<TModel>(TModel model, TModel newModel)
        {
            throw new System.NotImplementedException();
        }

        public override void DeleteModelFromDatabase<TModel>(TModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}