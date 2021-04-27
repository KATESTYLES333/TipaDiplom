using DataModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtResourcesBlazor
{
	public class CVController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
