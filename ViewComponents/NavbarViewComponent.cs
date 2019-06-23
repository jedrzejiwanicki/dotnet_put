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
        private readonly UserService userService;
        
        public NavbarViewComponent(AuthenticateService authenticateService, UserService userService)
        {
            this.authenticateService = authenticateService;
            this.userService = userService;
        }
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            NavbarViewModel model = new NavbarViewModel()
            {
                IsAuthenticated = this.authenticateService.IsAuthenticated(),
                IsAdminPrivileged = this.userService.UserIsAdmin(),
            };
            
            
            return await Task.Run(() => View("Default", model));
        }
    }
}