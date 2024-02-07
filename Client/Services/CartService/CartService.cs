using System;
using BlazingShop.Client.Services.ProductService;
using BlazingShop.Shared;
using Blazored.LocalStorage;
using Blazored.Toast.Services;
using System.Net.Http.Json;

namespace BlazingShop.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorageService;

        private readonly IToastService _toastService;

        private readonly IProductService _productService;

        private readonly HttpClient _http;

        public CartService(ILocalStorageService localStorageService, IToastService toastService, IProductService productService, HttpClient http)
        {
            _localStorageService = localStorageService;
            _productService = productService;
            _toastService = toastService;
            _http = http;
        }

        public event Action OnChange;

        public async Task AddToCart(CartItem item)
        {
            var cart = await _localStorageService.GetItemAsync<List<CartItem>>("cart");

            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            var sameItem = cart.Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId);

            if (sameItem == null)
            {

                cart.Add(item);
            }
            else
            {
                sameItem.Quantity += item.Quantity;
            }

            await _localStorageService.SetItemAsync("cart", cart);

            var product = await _productService.GetProduct(item.ProductId);
            _toastService.ShowSuccess(product.Title + " added to cart.");

            OnChange.Invoke();
        }

        public async Task DeleteItem(CartItem item)
        {
            var cart = await _localStorageService.GetItemAsync<List<CartItem>>("cart");

            if (cart == null)
            {
                return;
            }

            var cartItem = cart.Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId);

            cart.Remove(cartItem);

            await _localStorageService.SetItemAsync("cart", cart);

            OnChange.Invoke();

        }

        public async Task<List<CartItem>> GetCartItems()
        {

            var cart = await _localStorageService.GetItemAsync<List<CartItem>>("cart");

            if (cart == null)
            {
                return new List<CartItem>(); ;
            }

            return cart;
        }

        public async Task EmptyCart()
        {
            await _localStorageService.RemoveItemAsync("cart");
            OnChange.Invoke();
        }

        public async Task<string> Checkout()
        {
            var cartItems = await GetCartItems();
            var result = await _http.PostAsJsonAsync("api/payment/checkout", cartItems);
            var url = await result.Content.ReadAsStringAsync();
            return url;
        }
    }
}

