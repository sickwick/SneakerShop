using System;
using System.Collections.Generic;
using System.Linq;
using Shop.Database;
using Shop.Database.Interfaces;
using Shop.Database.Models;
using Shop.WebAPI.Interfaces;

namespace Shop.WebAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductDataProvider _productDataProvider;

        public ProductService(IProductDataProvider productDataProvider)
        {
            _productDataProvider = productDataProvider;
        }

        public List<Product> GetAllProducts()
        {
            if (!_productDataProvider.GetProducts().IsNullOrEmpty())
            {
                return _productDataProvider.GetProducts();
            }
            
            throw new NullReferenceException();
        }

        public Product GetProduct(long article)
        {
            if (CheckParameter(article) && _productDataProvider.GetProducts().Any(p=>p.Article == article))
            {
                return _productDataProvider.GetProducts().FirstOrDefault(p => p.Article == article);
            }
            
            throw new ArgumentException();
        }

        public List<Sizes> GetSizes(long article)
        {
            if (CheckParameter(article))
            {
                return GetProduct(article).SizesAvailable.ToList();
            }

            throw new ArgumentNullException();
        }

        public bool AddNewProduct(Product product)
        {
            // if (CheckParameter(product))
            // {
            //     try
            //     {
            //         if (_mongoDatabase.GetDatabaseList<Product>().Result.All(p => p.Article != product.Article))
            //         {
            //             _mongoDatabase.AddInDatabase(product);
            //             return _mongoDatabase.GetDatabaseList<Product>().Result.Any(p => p.Article == product.Article);
            //         }
            //         
            //         throw new InvalidEnumArgumentException();
            //     }
            //     catch
            //     {
            //         var db = new MainDatabase();
            //         db.AddInDatabase(product);
            //         return db.GetDatabaseList<Product>().Result.Any(p=>p.Article == product.Article);
            // }
        // }
            
            throw new NotImplementedException();
        }

        private bool CheckParameter(long param)
        {
            return param > 0 && param != default && param < long.MaxValue;
        }

        private bool CheckParameter(Product product)
        {
            return string.IsNullOrEmpty(product.Title) && product.SizesAvailable.IsNullOrEmpty() &&
                   string.IsNullOrEmpty(product.Label) && CheckParameter(product.Article);
        }
    }
}