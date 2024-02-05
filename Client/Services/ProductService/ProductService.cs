using System;
using System.Net.Http.Json;
using BlazingShop.Shared;

namespace BlazingShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public event Action OnChange;

        public List<Product> Products { get; set; }

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadProducts(string? categoryUrl)
        {
            if (categoryUrl == null)
            {
                Products = Products = await _http.GetFromJsonAsync<List<Product>>($"api/Product");

            }
            else
            {
                Products = await _http.GetFromJsonAsync<List<Product>>($"api/Product/Category/{categoryUrl}");
            }

            OnChange.Invoke();
        }

        public async Task<Product> GetProduct(int id)
        {

            return await _http.GetFromJsonAsync<Product>($"api/Product/{id}");
        }

        public async Task<List<Product>> SearchProducts(string searchText)
        {
            return await _http.GetFromJsonAsync<List<Product>>($"api/Product/Search/{searchText}");
        }

    }
}

