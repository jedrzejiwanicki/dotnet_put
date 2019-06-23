using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        private readonly AuthenticateService authenticateService;

        public HomeController(AuthenticateService authenticateService)
        {
            this.authenticateService = authenticateService;
        }
        public IActionResult Index()
        {

            if (this.authenticateService.IsAuthenticated())
            {
                return Redirect("books");
            }

            return Redirect("login");

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}