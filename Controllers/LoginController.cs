using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System;
using Microsoft.AspNetCore.Http;
using WebApplication1.Data;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class LoginController: Controller
    {

        private readonly UserService userService;
        private readonly AuthenticateService authenticateService;

        public LoginController(UserService userService, AuthenticateService authenticateService)
        {
            this.userService = userService;
            this.authenticateService = authenticateService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var _user = this.authenticateService.Authenticate(model.Username, model.Password);

                if (_user == null)
                {
                    ModelState.AddModelError("Password", "Incorrect credentials");
                }
                else
                {
                    var options = new CookieOptions() {IsEssential = true};
                    
                    Response.Cookies.Append("Token", _user.Token, options);
                    Console.WriteLine(_user.Token);
                    
                    return Redirect("/");
                }

            }
            
            return View(model);
        }

        [HttpGet]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("Token");

            return Redirect("/");
        }
    }
}