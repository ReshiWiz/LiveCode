using LiveCode.Models.FormUploads;
using Microsoft.AspNetCore.Mvc;

namespace LiveCode.Controllers
{
	public class FileController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult uploadFile(UserViewModel model)
		{
			return Json(model);
		}

		[HttpGet]
		public IActionResult GetFillUploadForm()
		{
			return PartialView("_uploadFile");
		}
	}
}
