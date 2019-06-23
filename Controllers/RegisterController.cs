using System;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserService userService;
        
        public RegisterController(UserService userService)
        {
            this.userService = userService;
        } 
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                this.userService.AddUser(new User()
                {
                    Username = model.Username,
                    Password = model.Password,
                    Email = model.Email,
                    Token = Guid.NewGuid().ToString(),
                });
                
                return Redirect("/");
            }

            return View(model);
        }
    }
}