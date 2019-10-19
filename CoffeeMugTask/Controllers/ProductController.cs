using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CoffeeMugTask.Models;

namespace CoffeeMugTask.Controllers
{
	[Route("api/product")]
	[ApiController]
	public class ProductController : Controller
	{
		private ProductManagerModel productManager = new ProductManagerModel();

		// GET api/product
		[HttpGet]
		public ActionResult<List<ProductModel>> Get()
		{
			return productManager.Products;
		}

		// GET api/product/{guid}
		[HttpGet("{id}")]
		public ActionResult<ProductModel> Get(Guid id)
		{
			return productManager.GetProductById(id);
		}

		// POST api/product
		[HttpPost]
		public Guid Post([FromBody] ProductCreateInputModel model)
		{
			return productManager.AddProduct(model);
		}

		// PUT api/product
		[HttpPut]
		public void Put([FromBody] ProductUpdateInputModel model)
		{
			productManager.UpdateProduct(model);
		}

		// DELETE api/product/{guid}
		[HttpDelete("{id}")]
		public void Delete(Guid id)
		{
			productManager.DeleteProduct(id);
		}
	}
}
