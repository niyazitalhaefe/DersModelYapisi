﻿using Microsoft.AspNetCore.Mvc;

namespace DersModelYapisi.Controllers
{
	public class CartController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}