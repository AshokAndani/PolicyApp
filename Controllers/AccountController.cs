using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PolicyApp.Engines;
using PolicyApp.Models;

namespace PolicyApp.Controllers
{
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private List<LoginModel> logins;
        private readonly ILogger<AccountController> _logger;
        private readonly ISqlEngine engine;

        public AccountController(ILogger<AccountController> logger, ISqlEngine engine)
        {
            this.engine = engine;
            _logger = logger;
            logins = new List<LoginModel>(){
                new LoginModel{
                    UserName="ashok@gmail.com",
                },
                new LoginModel{
                    UserName="vishal@gmail.com"
                }
            };
        }

        [HttpGet,Route("login")]
        public IActionResult Login()
        {
            ViewBag.Validaiton = true;
            return View();
        }
        [HttpPost,Route("login")]
        [AllowAnonymous]

        public async  Task<IActionResult> Login([FromForm]LoginModel loginModel){
            var pair = new KeyValuePair<string, string>("PolicyApp",loginModel.UserName);
            //var flag =await this.engine.ValidateLogin(loginModel);
            var flag = logins.Any(x => x.UserName.Equals(loginModel.UserName));
            if (flag)
            {
                var options = new CookieOptions();
                options.Secure = false;
                options.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append("PolicyApp",loginModel.UserName,options);
                return RedirectToAction("index", "Home");
            }
            ViewBag.Validation = false;
            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("PolicyApp");
            return RedirectToAction("Login", "Account");
        }
    }
}