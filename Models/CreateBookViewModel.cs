using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Models
{
    public class CreateBookViewModel
    {
        public Author[] Authors;

        [BindProperty]
        public string AuthorId { get; set; }
        
        [BindProperty]
        public string BookTitle { get; set; }
    }
}