﻿using Microsoft.AspNetCore.Mvc;

namespace Homework_1.Controllers
{
	public class HomeController:Controller
	{
		public ActionResult Index()
		{
			return View();
		}
		public ActionResult Contact()
		{
			return View();
		}
		public ActionResult About()
		{
			return View();
		}
	}
}
