using System.Collections.Generic;
using Shop.Storage.Models;

namespace Shop.Tests.Stubs
{
    public class ProductsStub
    {
        internal readonly List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = "e23e23e23rf2f2f232xx3rc2xz",
                Article = 12345, Category = "Limited", Label = "Nike",
                Title = "Air force 1 'Cactus Jack'",
                Photo =new List<string>()
                    {
                        "https://c.static-nike.com/a/images/t_prod_ss/w_480,c_limit,q_auto,f_auto/yhx8mbkb2yfqkcuqg8lc/air-force-1-cactus-jack-release-date.jpg",
                    },
                SizesAvailable = new List<Sizes>
                {
                    new Sizes(){
                        Size = 13.5,
                        Availability = new Availability {IsAvailable = true, QuantityInStock = 4}
                        
                    }
                }
            },
            new Product
            {
                Id = "e23e23e23rf2f2f232xxew3123",
                Article = 12454, Category = "Classic", Label = "Nike",
                Title = "Air force 1",
                Photo =
                    {
                        "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5,q_80/ga0g0giyocrvslw07rhc/кроссовки-air-force-1-07-6jXPDp.jpg",
                    },
                SizesAvailable = new List<Sizes>()
                {
                    new Sizes()
                    {
                        Size = 11,
                        Availability = new Availability {IsAvailable = true, QuantityInStock = 28}
                    },
                    new Sizes()
                    {
                        Size = 12,
                        Availability = new Availability {IsAvailable = false, QuantityInStock = 0}
                    },
                    new Sizes()
                    {
                        Size = 13,
                        Availability = new Availability {IsAvailable = true, QuantityInStock = 2}
                    },
                }
            },
            new Product
            {
                Id = "e23e23e23rf2f2f232xx3rc2xz",
                Article = 12345, Category = "Limited", Label = "Nike",
                Title = "Air force 1 'Cactus Jack'",
                Photo =
                    {
                        "https://c.static-nike.com/a/images/t_prod_ss/w_480,c_limit,q_auto,f_auto/yhx8mbkb2yfqkcuqg8lc/air-force-1-cactus-jack-release-date.jpg"
                    },
                SizesAvailable = new List<Sizes>()
                {
                    new Sizes()
                    {
                        Size = 14,
                        Availability = new Availability {IsAvailable = true, QuantityInStock = 4}
                    }
                }
            },
            new Product
            {
                Id = "e23e23e23rf2f2f232xxew3123",
                Article = 12454, Category = "Classic", Label = "Nike",
                Title = "Air force 1",
                Photo =
                    {
                        "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5,q_80/ga0g0giyocrvslw07rhc/кроссовки-air-force-1-07-6jXPDp.jpg"
                    },
                SizesAvailable = new List<Sizes>()
                {
                    new Sizes()
                    {
                        Size = 11,
                        Availability = new Availability {IsAvailable = true, QuantityInStock = 28}
                    },
                    new Sizes()
                    {
                        Size = 12,
                        Availability = new Availability {IsAvailable = false, QuantityInStock = 0}
                    },
                    new Sizes()
                    {
                        Size = 13,
                        Availability = new Availability {IsAvailable = true, QuantityInStock = 2}
                    },
                }
            }
        };
    }
}