﻿using System;
using System.Text.Json.Serialization;

namespace BlazingShop.Shared.Models
{
	public class Edition
	{
		public int Id { get; set; }
		public string Name { get; set; }

		[JsonIgnore]
		public List<Product> Products { get; set; }
	}
}

