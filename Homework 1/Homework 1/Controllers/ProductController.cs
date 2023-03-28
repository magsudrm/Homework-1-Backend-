using Microsoft.AspNetCore.Mvc;

namespace Homework_1.Controllers
{
	public class ProductController : Controller
	{
        public ActionResult Detail(int id, string brand, string category, decimal price)
        {
            ViewBag.Id = id;
            ViewBag.Brand = brand;
            ViewBag.Category = category;
            ViewBag.Price = price;
            return View();
        }

    }
}
