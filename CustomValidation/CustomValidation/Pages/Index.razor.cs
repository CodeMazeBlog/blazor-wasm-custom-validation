using Microsoft.AspNetCore.Components.Forms;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomValidation.Pages
{
	public partial class Index : IDisposable
	{
		private Product _product = new Product();
		private EditContext _editContext;

		protected override void OnInitialized()
		{
			_editContext = new EditContext(_product);
			_editContext.SetFieldCssClassProvider(new ValidationFieldClassProvider("validField", "invalidField"));
			_editContext.OnFieldChanged += HandleFieldChanged;
		}

		private void HandleFieldChanged(object sender, FieldChangedEventArgs e)
		{
			_editContext.Validate();
			StateHasChanged();
		}

		public void Submit() =>
			Console.WriteLine($"{_product.Name}, {_product.Supplier}");

		public void Dispose()
		{
			_editContext.OnFieldChanged -= HandleFieldChanged;
		}
	}
}
