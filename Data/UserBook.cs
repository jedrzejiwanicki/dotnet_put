using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data
{
    public class UserBook
    {
        [Key]
        public string Id { get; set; }
        
        public string UserId { get; set; }
        public User User { get; set; }
        
        public string BookId { get; set; }
        public Book Book { get; set; }
    }
    
    
}