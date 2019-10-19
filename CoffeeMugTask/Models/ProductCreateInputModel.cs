using System.ComponentModel.DataAnnotations;

namespace CoffeeMugTask.Models
{
	public class ProductCreateInputModel
	{
		[StringLength(100)]
		public string Name { get; set; }
		public decimal Price { get; set; }
	}
}
