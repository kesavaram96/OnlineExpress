using Microsoft.EntityFrameworkCore;
using OnlineExpress.Models;

namespace OnlineExpress.Data
{
    public class SeedData
    {
        public static void SeedDatabase(ApplicationDbContext context)
        {
            context.Database.Migrate();

            if (!context.Products.Any())
            {

                Category fruits = new Category { Name = "Fruits", Slug = "fruits" };
                Category shirt = new Category { Name = "Shirts", Slug = "shirts" };
                Category electronics = new Category { Name = "Electronics", Slug = "electronics" };


                context.Products.AddRange(
                    new Product
                    {
                        Name = "Apples",
                        Slug = "apples",
                        Price = 1.50M,
                        Description = "Red Apples",
                        Category = fruits,
                    },

                    new Product
                    {
                        Name = "Lemon",
                        Slug = "lemon",
                        Price = 2M,
                        Description = "Green Lemon",
                        Category = fruits,
                    },
                    new Product
                    {
                        Name = "Watermelon",
                        Slug = "watermelon",
                        Price = 0.50M,
                        Description = "Green watermelon",
                        Category = fruits,
                    },
                    new Product
                    {
                        Name = "Blue Shirt",
                        Slug = "blue shirt",
                        Price = 0.50M,
                        Description = "Green Lemon",
                        Category = fruits,
                    }


                    );

            }
        }
    }
}
