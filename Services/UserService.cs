using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Services
{
    public class UserService
    {
        private readonly Context db;
        private readonly HttpContextAccessor contextAccessor;

        public UserService(Context db, HttpContextAccessor contextAccessor)
        {
            this.db = db;
            this.contextAccessor = contextAccessor;
        }

        public bool UserAlreadyExists(string username)
        {
            return this.db.Users
                       .Where((User user) => user.Username == username)
                       .FirstOrDefault() != null;
            
        }

        public void AddUser(User model)
        {
            this.db.Users.Add(model);
            this.db.SaveChanges();
        }

        public User GetUserFromCookieToken()
        {
            return this.db.Users
                .Where(x => x.Token == this.contextAccessor.HttpContext.Request.Cookies["Token"])
                .FirstOrDefault();
        }

        public bool UserIsAdmin()
        {
            return this.db.Users
                       .Where(x => x.Token == this.contextAccessor.HttpContext.Request.Cookies["Token"])
                       .Where(x => x.Role == UserRole.Admin)
                       .FirstOrDefault() != null;
        }
    }
}