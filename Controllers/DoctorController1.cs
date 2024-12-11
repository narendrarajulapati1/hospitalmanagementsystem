using AspHospitalMgmt.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AspHospitalMgmt.Controllers
{
    public class DoctorController : Controller
    {
        private readonly DataContext _context;

        public DoctorController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                _context.Doctors.Add(doctor);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(doctor);
        }
    }
}
