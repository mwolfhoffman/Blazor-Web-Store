﻿using System;
using BlazingShop.Shared;

namespace BlazingShop.Client.Services.CartService
{
	public interface ICartService
	{

		event Action OnChange;

		Task AddToCart(ProductVariant productService);
		Task<List<CartItem>> GetCartItems();
		Task DeleteItem(CartItem item);
	}
}

