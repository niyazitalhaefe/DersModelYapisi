using DersModelYapisi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DersModelYapisi.Controllers
{
	public class CartController : Controller
	{
		public IActionResult Index()
		{
			var product1 = new ProductViewModel
			{
				Id = 1,
				Name = "Nescafe",
				Price = 9
			};

			var product2 = new ProductViewModel
			{
				Id = 2,
				Name = "Starbucks",
				Price = 19
			};

			var product3 = new ProductViewModel
			{
				Id = 3,
				Name = "FO",
				Price = 29
			};

			var cartProduct1 = new CartProductViewModel
			{
				Id = product1.Id,
				Product = product1,
				Quantity = 5,
				Price = 5 * product1.Price
			};

			var cartProduct2 = new CartProductViewModel
			{
				Id = product2.Id,
				Product = product2,
				Quantity = 3,
				Price = 3 * product2.Price
			};

			var cartProduct3 = new CartProductViewModel
			{
				Id = product3.Id,
				Product = product3,
				Quantity = 1,
				Price = 1* product3.Price
			};

			var cartProducts = new List<CartProductViewModel> { cartProduct1, cartProduct2, cartProduct3 };

			return View(cartProducts);
		}
	}
}
