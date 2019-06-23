using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Data
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        public string Username { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }

        public string Token { get; set; }

    }
}