using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using EndToEnd.Data;
using DataModel.Models;

namespace ExtResourcesBlazor.Controllers
{
	public class HomeController : Controller
	{
		ApplicationDbContext _context;
		IWebHostEnvironment _appEnvironment;

		public HomeController(ApplicationDbContext context, IWebHostEnvironment appEnvironment)
		{
			_context = context;
			_appEnvironment = appEnvironment;
		}

		public IActionResult Index()
		{
			return View(_context.Files.ToList());
		}
	}
}

