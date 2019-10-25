using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeMugTask.Models;

namespace CoffeeMugTask.Validators
{
	public class CreateNameCannotBeNullOrEmptyValidation : ValidationBase<ProductCreateInputModel>
	{
		public CreateNameCannotBeNullOrEmptyValidation(ProductCreateInputModel context)
			: base(context)
		{
		}

		public override bool IsValid {
			get { return string.IsNullOrEmpty(Context.Name); }
		}

		public override string Message {
			get {
				return "Name is null or empty";
			}
		}
	}
}
