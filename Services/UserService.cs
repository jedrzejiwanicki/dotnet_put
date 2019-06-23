using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Services
{
    public class UserService
    {
        private readonly Context db;

        public UserService(Context db)
        {
            this.db = db;
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
    }
}