using System;
using BlazingShop.Server.Data;
using BlazingShop.Server.Services.CategoryService;
using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazingShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        private readonly ICategoryService _categoryService;


        public ProductService(ICategoryService categoryService, DataContext context)
        {
            _context = context;
            _categoryService = categoryService;
        }

        public List<Product> Products { get; set; }

        public ProductService()
        {
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.Include(p => p.Variants).ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = await _context.Products
                .Include(p => p.Variants)
                .ThenInclude(v => v.Edition)
                .FirstOrDefaultAsync(p => p.Id == id);

            product.Views++;

            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)

        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return await _context.Products.Include(p => p.Variants).Where(p => p.CategoryId == category.Id).ToListAsync();

        }


        public async Task<List<Product>> SearchProducts(string searchText)
        {
            return await _context.Products.Where(x => x.Title.Contains(searchText) || x.Description.Contains(searchText))
            .ToListAsync();
        }
    }
}

