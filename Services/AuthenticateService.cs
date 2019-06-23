using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using WebApplication1.Data;

namespace WebApplication1.Services
{
    public class AuthenticateService
    {
        private readonly Context db;
        private bool _IsAuthenticated;
        
        public AuthenticateService(Context db)
        {
            this.db = db;
        }

        public User Authenticate(string username, string password)
        {
            var _user = this.db.Users
                .Where(user => user.Username == username && user.Password == password)
                .FirstOrDefault();

            return _user;

        }
            
        public bool IsAuthenticated(string token)
        {


            if (token == null)
            {
                return false;
            }
            
            var _user = this.db.Users
                .Where(user => user.Token == token)
                .FirstOrDefault();
            
            return _user != null;
        }
    }
}