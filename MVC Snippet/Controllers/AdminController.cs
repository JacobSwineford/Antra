using Microsoft.AspNetCore.Mvc;

namespace MVC_Project.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
