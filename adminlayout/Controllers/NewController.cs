using Microsoft.AspNetCore.Mvc;

namespace adminlayout.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
