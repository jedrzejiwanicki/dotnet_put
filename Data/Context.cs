using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApplication1.Data
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options): base(options) {}
        
        public DbSet<User> Users { get; set; }
    }
}