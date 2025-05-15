using CentralizedDatabaseManagementSystem.Data;
using CentralizedDatabaseManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CentralizedDatabaseManagementSystem.Controllers
{
    public class DistributorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DistributorsController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Email, string Password)
        {

            if (Email == "rohan@gmail.com" && Password == "password")
            {
                return RedirectToAction("Create", "Distributors");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid login details!";
                return View(); // Returns the login view with error
            }

        }

        public IActionResult Logout()
        {
            // Clear session or authentication cookie here if used
            // HttpContext.Session.Clear();  // if using session
            // SignOut();                   // if using cookie-based auth

            return RedirectToAction("Login", "Account");
        }

        //
        // GET: Distributors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Distributors.ToListAsync());
        }

        // GET: Distributors/Create
        public IActionResult Create()
        {
            return View(new Distributor());
        }

        // POST: Distributors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Distributor distributor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(distributor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(distributor);
        }

        // Other methods like Details, Edit, Delete (if needed)...

        // GET: Distributors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var distributor = await _context.Distributors.FindAsync(id);

            if (distributor == null)
                return NotFound();

            return View(distributor);
        }

        // POST: Distributors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Distributor distributor)
        {
            if (id != distributor.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(distributor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DistributorExists(distributor.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(distributor);
        }

        // GET: Distributors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var distributor = await _context.Distributors
                .FirstOrDefaultAsync(m => m.Id == id);

            if (distributor == null)
                return NotFound();

            return View(distributor);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var distributor = await _context.Distributors.FindAsync(id);
            if (distributor != null)
            {
                _context.Distributors.Remove(distributor);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool DistributorExists(int id)
        {
            return _context.Distributors.Any(e => e.Id == id);
        }

        // GET: Distributors/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var distributor = _context.Distributors
                .FirstOrDefault(m => m.Id == id);

            if (distributor == null)
            {
                return NotFound();
            }

            return View(distributor);
        }
    }

}
