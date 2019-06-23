using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Data
{
    public enum UserRole
    {
        Default,
        Admin,
    }
    
    public class User
    {
        [Key]
        public string Id { get; set; }
        
        public string Username { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }

        public string Token { get; set; }
        
        public UserRole Role { get; set; }
        
        public ICollection<UserBook> UserBooks { get; set; }

    }
}