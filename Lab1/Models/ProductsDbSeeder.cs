using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class ProductsDbSeeder
    {

        public static void Initialize(ProductsDbContext context)
        {
            context.Database.EnsureCreated();
 
            // Look for any products.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            context.Products.AddRange(
                new Product
                {
                    Name = "iPhone",
                    Description = "XS",
                    Cathegory = "Phone",
                    Price = 500
                },
                new Product
                {
                    Name = "Samsung",
                    Description = "Galaxy",
                    Cathegory = "Phone",
                    Price = 400
                }
            );
            context.SaveChanges();
        }
    }
}
