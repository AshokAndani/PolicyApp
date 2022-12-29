using Microsoft.AspNetCore.Mvc;

namespace PolicyApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
