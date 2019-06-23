using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data
{
    public class Book
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<AuthorBook> AuthorBooks { get; set; }
        public ICollection<UserBook> UserBooks { get; set; }
    }
}