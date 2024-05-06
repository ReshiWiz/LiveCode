using LiveCode.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LiveCode.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Sum()
		{
			return View(0);
		}
		[HttpPost]
		public IActionResult Sum(int num1, int num2)
		{
			return View(num1 + num2);
		}

	}

}