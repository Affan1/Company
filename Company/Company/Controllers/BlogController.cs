using Microsoft.AspNetCore.Mvc;

namespace Company.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
