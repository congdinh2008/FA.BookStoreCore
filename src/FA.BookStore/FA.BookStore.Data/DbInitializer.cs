using FA.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FA.BookStore.Data
{
    public class DbInitializer
    {
        public static void Seed(BookStoreDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Categories.Any())
            {
                return;
            }

            var categories = new List<Category>
            {
                new Category
                {
                    Id =  Guid.NewGuid(),
                    Name = "Comic",
                    UrlSlug = "comic",
                    Description = "comic",
                    IsDeleted = false,
                },
                new Category
                {
                    Id =  Guid.NewGuid(),
                    Name = "Literature",
                    UrlSlug = "literature",
                    Description = "literature",
                    IsDeleted = false,
                },
                new Category
                {
                    Id =  Guid.NewGuid(),
                    Name = "Self Help",
                    UrlSlug = "self-help",
                    Description = "Self Help",
                    IsDeleted = false,
                }
            };

            context.AddRange(categories);
            context.SaveChanges();
        }
    }
}
