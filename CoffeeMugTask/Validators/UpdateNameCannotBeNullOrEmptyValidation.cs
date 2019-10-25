using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeMugTask.Models;

namespace CoffeeMugTask.Validators
{
	public class UpdateNameCannotBeNullOrEmptyValidation : ValidationBase<ProductUpdateInputModel>
	{
		public UpdateNameCannotBeNullOrEmptyValidation(ProductUpdateInputModel context)
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
