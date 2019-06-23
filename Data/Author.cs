using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data
{
    public class Author
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public ICollection<AuthorBook> AuthorBooks { get; set; }
    }
}