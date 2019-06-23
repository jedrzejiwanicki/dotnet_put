using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.ViewComponents
{
    public class NavbarViewComponent: ViewComponent
    {
        private readonly AuthenticateService authenticateService;
        
        public NavbarViewComponent(AuthenticateService authenticateService)
        {
            this.authenticateService = authenticateService;
        }
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string token = HttpContext.Request.Cookies["Token"];
            
            bool isAuthenticated = this.authenticateService.IsAuthenticated(token);
            NavbarViewModel model = new NavbarViewModel() { IsAuthenticated = isAuthenticated};
            
            Console.WriteLine(model.IsAuthenticated);
            Console.WriteLine(token);
            
            return await Task.Run(() => View("Default", model));
        }
    }
}