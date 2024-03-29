﻿using System;
using BlazingShop.Shared;

namespace BlazingShop.Client.Services.CartService
{
    public interface ICartService
    {

        event Action OnChange;

        Task AddToCart(CartItem cartItem);
        Task<List<CartItem>> GetCartItems();
        Task DeleteItem(CartItem item);
        Task EmptyCart();
        Task<string> Checkout();
    }
}

