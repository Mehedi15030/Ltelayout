using adminlayout.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace adminlayout.Controllers
{
   
    public class OrderController : Controller
    {
        private readonly VendingmachineapiContext _context;

        public OrderController(VendingmachineapiContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Index3()
        {
            var categories = _context.Categories.ToList(); // Use your actual DbContext and DbSet
            return View(categories);
        }
        public IActionResult Show()
        {
            return View();
        }
    }
}
