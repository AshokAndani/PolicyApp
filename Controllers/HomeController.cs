using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PolicyApp.Models;
using System.Diagnostics;

namespace PolicyApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        { 
            var cookie = Request.Cookies["PolicyApp"];
            if(cookie == null)
            {
              return RedirectToAction("login","Account");
            }
            ViewData["LoggedIn"] = true;
           // var customerModel = JsonConvert.DeserializeObject<CustomerModel>(cookie);
            var list = new List<PolicyModel>() { new PolicyModel
            {
                PolicyId = 1,
                PolicyTerm = DateTime.Now.AddDays(4),
                PolicyTitle="FHL",
                PolicyType=PolicyType.General.ToString(),
                PremiumAmount=45000,
                SumAssured=205400,
            }, 
            new PolicyModel
                        {
                PolicyId = 2,
                PolicyTerm = DateTime.Now.AddDays(3),
                PolicyTitle="DHL",
                PolicyType=PolicyType.General.ToString(),
                PremiumAmount=56234,
                SumAssured=8758345,
            }, 
            new PolicyModel
                        {
                PolicyId = 3,
                PolicyTerm = DateTime.Now.AddDays(7),
                PolicyTitle="reliance",
                PolicyType=PolicyType.Motorbike.ToString(),
                PremiumAmount=6734,
                SumAssured=647563,
            }, 
            new PolicyModel
                        {
                PolicyId = 4,
                PolicyTerm = DateTime.Today,
                PolicyTitle="tata",
                PolicyType=PolicyType.Medical.ToString(),
                PremiumAmount=10000,
                SumAssured=20000,
            }, 
            };
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}