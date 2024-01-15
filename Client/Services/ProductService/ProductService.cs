using System;
using System.Net.Http.Json;
using BlazingShop.Shared;

namespace BlazingShop.Client.Services.ProductService
{
	public class ProductService : IProductService
	{
        private readonly HttpClient _http;

        public List<Product> Products { get; set; } = new List<Product>();

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadProducts()
        {
            await _http.GetFromJsonAsync<List<Product>>("api/Product");  
        }
    }
}

