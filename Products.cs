using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerDSL
{
	[ApiController]
	[Route("products")]
	public class Products
	{
		[HttpGet("{productId}")]
		public Product Get(int productId) => null;

		[HttpGet]
		public IEnumerable<Product> Get(string description) => null;

		[HttpPost]
		public void Post(Product product) {}
	}

	public class Product
	{
		public int ProductId { get; set; }

		[Required]
		public string Description { get; set; }
	}
}