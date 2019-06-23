using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Data;

namespace WebApplication1.Models
{
    public class LoginViewModel
    {
        public string Password { get; set;  }
        public string Username { get; set;  }
        
    }
}