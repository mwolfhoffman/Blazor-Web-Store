using System;
using BlazingShop.Client.Services.ProductService;
using BlazingShop.Shared;
using Blazored.LocalStorage;
using Blazored.Toast.Services;

namespace BlazingShop.Client.Services.CartService
{
	public class CartService : ICartService
	{
        private readonly ILocalStorageService _localStorageService;

        private readonly IToastService _toastService;

        private readonly IProductService _productService;
            
        public CartService(ILocalStorageService localStorageService, IToastService toastService, IProductService productService)
		{
            _localStorageService = localStorageService;
            _productService = productService;
            _toastService = toastService;
        }

        public event Action OnChange;

        public async Task AddToCart(ProductVariant productVariant)
        {
            var cart = await _localStorageService.GetItemAsync<List<ProductVariant>>("cart");

            if(cart == null)
            {
                cart = new List<ProductVariant>();
            }
            cart.Add(productVariant);

            await _localStorageService.SetItemAsync("cart", cart);

            var product = await _productService.GetProduct(productVariant.ProductId);
            _toastService.ShowSuccess(product.Title + " added to cart.");

            OnChange.Invoke();
        }
    }
}

