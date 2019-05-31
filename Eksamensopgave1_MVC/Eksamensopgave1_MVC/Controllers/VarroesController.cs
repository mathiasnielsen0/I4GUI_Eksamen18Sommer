using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Eksamensopgave1_MVC.Data;
using Eksamensopgave1_MVC.Models;
using Microsoft.AspNetCore.Identity;

namespace Eksamensopgave1_MVC.Controllers
{
    public class VarroesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;

        public VarroesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Varroes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Varros.Include(v => v.ApplicationUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Varroes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var varro = await _context.Varros
                .Include(v => v.ApplicationUser)
                .FirstOrDefaultAsync(m => m.VarroId == id);
            if (varro == null)
            {
                return NotFound();
            }

            return View(varro);
        }

        public async Task<IActionResult> PersonalVarros()
        {
            var user = await _userManager.GetUserAsync(User);

            var Varros = _context.Varros.Where(v => v.ApplicationUser.Id == user.Id);

            return View(await Varros.ToListAsync());
        }

        // GET: Varroes/Create
        public IActionResult Create()
        {
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUser, "Id", "Id");
            return View();
        }

        // POST: Varroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VarroId,Bistade,DatoRegistreret,AntalMider,ObservationsVarighed,Notater,ApplicationUserId")] Varro varro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(varro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUser, "Id", "Id", varro.ApplicationUserId);
            return View(varro);
        }

        // GET: Varroes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var varro = await _context.Varros.FindAsync(id);
            if (varro == null)
            {
                return NotFound();
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUser, "Id", "Id", varro.ApplicationUserId);
            return View(varro);
        }

        // POST: Varroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("VarroId,Bistade,DatoRegistreret,AntalMider,ObservationsVarighed,Notater,ApplicationUserId")] Varro varro)
        {
            if (id != varro.VarroId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(varro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VarroExists(varro.VarroId))
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
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUser, "Id", "Id", varro.ApplicationUserId);
            return View(varro);
        }

        // GET: Varroes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var varro = await _context.Varros
                .Include(v => v.ApplicationUser)
                .FirstOrDefaultAsync(m => m.VarroId == id);
            if (varro == null)
            {
                return NotFound();
            }

            return View(varro);
        }

        // POST: Varroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var varro = await _context.Varros.FindAsync(id);
            _context.Varros.Remove(varro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VarroExists(string id)
        {
            return _context.Varros.Any(e => e.VarroId == id);
        }
    }
}
