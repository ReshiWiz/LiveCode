using LiveCode.Data;
using LiveCode.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LiveCode.Controllers
{
	public class FormController : Controller
	{
		private readonly ApplicationDbContext _context;
		public FormController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			ViewBag.countryList = _context.Country.ToList();

			return View();
		}
		public IActionResult CreateModel()
		{
			ViewBag.countryList = _context.Country.ToList();

			return PartialView("_user");
		}
		public IActionResult ListOfItems()
		{
			var listOfItems = _context.formLists
					   .Include(f => f.Country)
					   .Include(f => f.State)
					   .Include(f => f.City)
					   .Select(f => new
					   {
						   Id = f.Id,
						   Name = f.Name,
						   Country = f.Country != null ? new { Id = f.Country.Id, Name = f.Country.Name } : null,
						   State = f.State != null ? new { Id = f.State.Id, Name = f.State.state } : null,
						   City = f.City != null ? new { Id = f.City.Id, Name = f.City.name } : null
					   })
					   .ToList();

			return View(listOfItems);
		}
		[HttpGet]
		public IActionResult GetCountry(int id)
		{
			if (id <= 0) { return Json("id is invalid"); }
			var finder = _context.Country.Find(id);
			if (finder == null) { return Json("not found the Id"); }
			return Json(_context.Country.Where(x => x.Id == id).ToList());
		}
		[HttpGet]
		public IActionResult GetStates(int id)
		{
			return Json(_context.State.Where(x => x.countryId == id).ToList());
		}
		[HttpGet]
		public IActionResult GetCities(int id)
		{
			return Json(_context.City.Where(x => x.stateId == id));
		}
		[HttpPost]
		public IActionResult PostForm(FormList formList)
		{
			if (ModelState.IsValid)
			{
				var from = new FormList() { CityId = formList.CityId, State = formList.State, City = formList.City, Country = formList.Country, CountryId = formList.CountryId, Name = formList.Name, StateId = formList.StateId };
				_context.formLists.Add(from);
				_context.SaveChanges();
				return RedirectToAction("ListOfItems");
			}
			return View();
		}
		[HttpPut]
		public IActionResult EditForm(int id, FormList formList)
		{
			if (id <= 0) { return Json("unable to find the model"); }
			var currentModel = _context.formLists.Find(id);
			if (currentModel == null)
			{
				return Json("unable to find the id");
			}
			currentModel = new FormList() { City = formList.City, CityId = formList.CityId, Country = formList.Country, CountryId = formList.CountryId, Name = formList.Name, State = formList.State, StateId = formList.StateId };
			_context.formLists.Update(currentModel);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}


		public IActionResult FileUpload()
		{
			return Json("");
		}
	}
}
