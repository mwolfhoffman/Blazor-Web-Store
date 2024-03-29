﻿using System;
using BlazingShop.Server.Data;
using BlazingShop.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingShop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
	{

        private readonly DataContext _context;
        public List<Category> Categories { get; set; }


        public CategoryService(DataContext context)
		{
            _context = context;
		}

        public async Task<List<Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
          
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}

