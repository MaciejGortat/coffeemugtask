using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace CoffeeMugTask.Models
{
	public class ProductManagerModel
	{
		public List<ProductModel> Products { get; private set; } = new List<ProductModel>();

		public ProductManagerModel()
		{
			LoadFile();
		}

		private void LoadFile()
		{
			using (StreamReader sr = new StreamReader("Products.json"))
			{
				string file = sr.ReadToEnd();
				Products = JsonConvert.DeserializeObject<List<ProductModel>>(file);
				sr.Close();
			}
		}

		private void SafeFile()
		{
			using (StreamWriter sw = new StreamWriter("Products.json"))
			{
				sw.Write(JsonConvert.SerializeObject(Products, Formatting.Indented));
				sw.Close();
			}
		}
		public ProductModel GetProductById(Guid id)
		{
			return Products.Find(product => product.Id == id);
		}

		public Guid AddProduct(ProductCreateInputModel model)
		{
			if (string.IsNullOrEmpty(model.Name) || model.Name.Length > 100 || model.Price == 0)
			{
				return Guid.Empty;
			}

			ProductModel newModel = new ProductModel();
			newModel.Id = Guid.NewGuid();
			newModel.Name = model.Name;
			newModel.Price = model.Price;
			Products.Add(newModel);
			SafeFile();
			return newModel.Id;
		}

		public void UpdateProduct(ProductUpdateInputModel model)
		{
			if (string.IsNullOrEmpty(model.Name) || model.Name.Length > 100 || model.Price == 0)
			{
				return;
			}

			ProductModel tempProduct = Products.Find(product => product.Id == model.Id);
			if (tempProduct == null)
			{
				return;
			}

			tempProduct.Name = model.Name;
			tempProduct.Price = model.Price;
			SafeFile();
		}

		public void DeleteProduct(Guid id)
		{
			Products.Remove(Products.Find(product => product.Id == id));
			SafeFile();
		}
	}
}
