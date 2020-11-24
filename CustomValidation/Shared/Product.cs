using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shared
{
	public class Product
	{
		[Required]
		public string Name { get; set; }
		[Required]
		[SupplierValidation(ErrorMessage = "Wrong value entered", ValidSupplierValue = "Code-Maze")]
		public string Supplier { get; set; }
	}
}
