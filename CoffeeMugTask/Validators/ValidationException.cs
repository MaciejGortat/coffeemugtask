using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMugTask.Validators
{
	public class ValidationException : Exception
	{
		public ValidationException(string message, params object[] args)
			: base(string.Format(message, args))
		{
		}
	}
}
