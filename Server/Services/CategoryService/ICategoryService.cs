using System;
using BlazingShop.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazingShop.Server.Services.CategoryService
{
	public interface ICategoryService
	{
		Task<List<Category>> GetCategories();

		Task<Category> GetCategoryByUrl(string categoryUrl);
	}
}

