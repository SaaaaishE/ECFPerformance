﻿using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels;
using ECFPerformance.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private EcfDbContext dbContext;

        public CategoryService(EcfDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<AllProductsViewModel>> GetAllProductsAsync()
        {
            var turbos = await dbContext.Turbos
               //.Include(c => c.Category)
               .Select(t => new AllProductsViewModel
               {
                   Id = t.Id,
                   Name = t.Name,
                   MainImage = t.MainImage,
                   CategoryName = t.Category.CategoryName
               })
               .ToArrayAsync();

            var rods = await dbContext.ConnectingRods
                .Select(r => new AllProductsViewModel
                {
                    Id = r.Id,
                    Name = r.Name,
                    MainImage = r.MainImage,
                    CategoryName = r.Category.CategoryName
                })
                .ToArrayAsync();

            List<AllProductsViewModel> products = new List<AllProductsViewModel>();
            products.AddRange(turbos);
            products.AddRange(rods);

            return products;
        }

        public async Task<IEnumerable<CategoryNamesViewModel>> GetCategoriesNamesAsync()
        {
            return await dbContext.Categories
                .Select(x => new CategoryNamesViewModel()
                {
                    Id = x.Id,
                    Name = x.CategoryName
                })
                .ToArrayAsync();
        }


    }
}
