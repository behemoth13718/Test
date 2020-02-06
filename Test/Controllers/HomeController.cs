using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public ActionResult Index()
		{
			return View(new SampleViewModel());
		}


		[HttpGet]
		public JsonResult GetAnswer(string question)
		{
			int index = _rnd.Next(_db.Count);
			var answer = _db[index];
			return Json(answer);
		}

		private static Random _rnd = new Random();

		private static List<string> _db = new List<string> { "Yes", "No", "Definitely, yes", "I don't know", "Looks like, yes" };
	}
}
