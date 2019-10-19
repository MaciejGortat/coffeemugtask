using System;
using System.ComponentModel.DataAnnotations;

namespace CoffeeMugTask.Models
{
	public class ProductModel
	{
		public Guid Id { get; set; }
		[StringLength(100)]
		public string Name { get; set; }
		public decimal Price { get; set; }
	}
}
