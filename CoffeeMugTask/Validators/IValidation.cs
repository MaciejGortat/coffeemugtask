﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMugTask.Validators
{
	public interface IValidation
	{
		bool IsValid { get; } // True when valid
		void Validate(); // Throws an exception when not valid
		string Message { get; } // The message when object is not valid
	}
}
