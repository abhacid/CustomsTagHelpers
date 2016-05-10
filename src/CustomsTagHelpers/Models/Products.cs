using System.Collections.Generic;

namespace CustomsTagHelpers.Models
{
    public class Products : List<Product>
        {
            public Products()
            {
                Add(new Product() { ProductId = 1, ProductName = "P1", Price = 3000 });
                Add(new Product() { ProductId = 2, ProductName = "P2", Price = 3100 });
                Add(new Product() { ProductId = 3, ProductName = "P3", Price = 3400 });
                Add(new Product() { ProductId = 4, ProductName = "P4", Price = 3700 });
                Add(new Product() { ProductId = 5, ProductName = "P5", Price = 4000 });
                Add(new Product() { ProductId = 6, ProductName = "P6", Price = 3200 });
            }
        }
}
