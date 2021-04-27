using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataModel;

namespace ExtResourcesBlazor
{
    public class ContactsController : Controller
    {
        private readonly PartnersContext _context;

        public ContactsController(PartnersContext context)
        {
            _context = context;
        }

        // GET: Contacts
        public async Task<IActionResult> Index()
        {
            var partnersContext = _context.Contact.Include(c => c.Partner).Include(c => c.PreferredWayOfCommunicationNavigation);
            return View(await partnersContext.ToListAsync());
        }

        // GET: Contacts/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .Include(c => c.Partner)
                .Include(c => c.PreferredWayOfCommunicationNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // GET: Contacts/Create
        public IActionResult Create()
        {
            ViewData["PartnerId"] = new SelectList(_context.Partner, "Id", "Name");
            ViewData["PreferredWayOfCommunication"] = new SelectList(_context.WayOfCommunication, "Id", "Name");
            return View();
        }

        // POST: Contacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Position,Skype,Telegram,Phone,Email,Notes,PartnerId,DateOfBirth,PreferredWayOfCommunication,Gender")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                contact.Id = Guid.NewGuid();
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PartnerId"] = new SelectList(_context.Partner, "Id", "Name", contact.PartnerId);
            ViewData["PreferredWayOfCommunication"] = new SelectList(_context.WayOfCommunication, "Id", "Name", contact.PreferredWayOfCommunication);
            return View(contact);
        }

        // GET: Contacts/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            ViewData["PartnerId"] = new SelectList(_context.Partner, "Id", "Name", contact.PartnerId);
            ViewData["PreferredWayOfCommunication"] = new SelectList(_context.WayOfCommunication, "Id", "Name", contact.PreferredWayOfCommunication);
            return View(contact);
        }

        // POST: Contacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,LastName,Position,Skype,Telegram,Phone,Email,Notes,PartnerId,DateOfBirth,PreferredWayOfCommunication,Gender")] Contact contact)
        {
            if (id != contact.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactExists(contact.Id))
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
            ViewData["PartnerId"] = new SelectList(_context.Partner, "Id", "Name", contact.PartnerId);
            ViewData["PreferredWayOfCommunication"] = new SelectList(_context.WayOfCommunication, "Id", "Name", contact.PreferredWayOfCommunication);
            return View(contact);
        }

        // GET: Contacts/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .Include(c => c.Partner)
                .Include(c => c.PreferredWayOfCommunicationNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // POST: Contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var contact = await _context.Contact.FindAsync(id);
            _context.Contact.Remove(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactExists(Guid id)
        {
            return _context.Contact.Any(e => e.Id == id);
        }
    }
}
