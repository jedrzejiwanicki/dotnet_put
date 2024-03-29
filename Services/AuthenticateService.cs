using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using WebApplication1.Data;

namespace WebApplication1.Services
{
    public class AuthenticateService
    {
        private readonly Context db;
        private readonly HttpContextAccessor contextAccessor;

        public AuthenticateService(Context db, HttpContextAccessor contextAccessor)
        {
            this.db = db;
            this.contextAccessor = contextAccessor;
        }

        public User Authenticate(string username, string password)
        {
            var _user = this.db.Users
                .Where(user => user.Username == username && user.Password == password)
                .FirstOrDefault();

            return _user;

        }
            
        public bool IsAuthenticated()
        {

            string token = this.contextAccessor.HttpContext.Request.Cookies["Token"];
            
            if (token == null)
            {
                return false;
            }
            
            var _user = this.db.Users
                .Where(user => user.Token == token)
                .FirstOrDefault();
            
            return _user != null;
        }

        public bool IsAdmin()
        {
            return this.db.Users
                       .Where(user => user.Token == this.contextAccessor.HttpContext.Request.Cookies["Token"])
                       .Where(user => user.Role == UserRole.Admin)
                       .FirstOrDefault() != null;
        }
    }
}