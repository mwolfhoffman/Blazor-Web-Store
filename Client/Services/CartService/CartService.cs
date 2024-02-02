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
    }
}

