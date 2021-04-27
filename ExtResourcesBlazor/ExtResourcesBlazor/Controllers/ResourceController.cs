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
	public class ResourceController : Controller
	{
		private readonly PartnersContext _context;

		public ResourceController(PartnersContext context)
		{
			_context = context;
		}

		// GET: Resources
		public async Task<IActionResult> Index()
		{
			var resourcesContext = _context.Resource.Include(c => c.Partner).Include(c => c.LevelDeclaredNavigation);
			return View(await resourcesContext.ToListAsync());
		}

		// GET: Resources/Details/5
		public async Task<IActionResult> Details(Guid? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var resource = await _context.Resource
				.Include(c => c.Partner)
				.Include(c => c.LevelDeclaredNavigation)
				.FirstOrDefaultAsync(m => m.Id == id);
			if (resource == null)
			{
				return NotFound();
			}

			return View(resource);
		}

		// GET: Resources/Create
		public IActionResult Create()
		{
			ViewData["PartnerId"] = new SelectList(_context.Partner, "Id", "Name");
			ViewData["LevelDeclared"] = new SelectList(_context.ResourceLevel, "Id", "Name");
			return View();
		}

		// POST: Resource/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,PartnerId,Title,About,Technologies,LevelDeclared,EnglishSpoken,EnglishFeedback,Available,CVToolLinkMaster,Added,Updated")] Resource resource)
		{
			if (ModelState.IsValid)
			{
				resource.Id = Guid.NewGuid();
				_context.Add(resource);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			ViewData["PartnerId"] = new SelectList(_context.Partner, "Id", "Name", resource.PartnerId);
			ViewData["LevelDeclared"] = new SelectList(_context.WayOfCommunication, "Id", "Name", resource.LevelDeclared);
			return View(resource);
		}

		// GET: Resources/Edit/5
		public async Task<IActionResult> Edit(Guid? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var resource = await _context.Resource.FindAsync(id);
			if (resource == null)
			{
				return NotFound();
			}
			ViewData["PartnerId"] = new SelectList(_context.Partner, "Id", "Name", resource.PartnerId);
			ViewData["LevelDeclared"] = new SelectList(_context.WayOfCommunication, "Id", "Name", resource.LevelDeclared);
			return View(resource);
		}

		// POST: Resousrces/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(Guid id, [Bind("Id, FirstName, LastName, PartnerId, Title, About, Technologies, LevelDeclared, EnglishSpoken, EnglishFeedback, Available, CVToolLinkMaster, Added, Updated")] Resource resource)
		{
			if (id != resource.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(resource);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!ResourceExists(resource.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			ViewData["PartnerId"] = new SelectList(_context.Partner, "Id", "Name", resource.PartnerId);
			ViewData["LevelDeclared"] = new SelectList(_context.WayOfCommunication, "Id", "Name", resource.LevelDeclared);
			return View(resource);
		}

		// GET: Resources/Delete/5
		public async Task<IActionResult> Delete(Guid? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var res = await _context.Resource
				.Include(c => c.Partner)
				.Include(c => c.LevelDeclaredNavigation)
				.FirstOrDefaultAsync(m => m.Id == id);
			if (res == null)
			{
				return NotFound();
			}

			return View(res);
		}

		// POST: Resource/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(Guid id)
		{
			var res = await _context.Resource.FindAsync(id);
			_context.Resource.Remove(res);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool ResourceExists(Guid id)
		{
			return _context.Resource.Any(e => e.Id == id);
		}
	}

}
