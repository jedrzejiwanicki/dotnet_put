using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models
{
    public class RegisterViewModel
    {
        [BindProperty] public string Username { get; set; }
        [BindProperty] public string Email { get; set; }
        [BindProperty] public string Password { get; set; }
    }
}