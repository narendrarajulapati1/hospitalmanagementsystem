using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AspHospitalMgmt.Models;
using System.Threading.Tasks;
using System;

namespace AspHospitalMgmt.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly DataContext _context;

        public DoctorsController(DataContext context)
        {
            _context = context;
        }

        // GET: Doctors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Doctors.ToListAsync());
        }

        // GET: Doctors/Book/{id}
        public async Task<IActionResult> Book(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null)
            {
                return NotFound();
            }

            return View(new RegUser { DoctorName = doctor.Name });
        }

        // POST: Doctors/Book
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Book(RegUser regUser)
        {
            if (ModelState.IsValid)
            {
                regUser.BookingDate = DateTime.Now;
                _context.Add(regUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(regUser);
        }
    }
}
