using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data
{
    public class AuthorBook
    {
        [Key]
        public string Id { get; set;  }
        public string AuthorId { get; set; }
        public Author Author { get; set; }
        public string BookId { get; set; }
        public Book Book { get; set; }
    }
}