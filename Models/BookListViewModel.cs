using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class BookListViewModel
    {
        public string Id;
        public string Name { get; set; }
        public IEnumerable<string> Authors { get; set; }
        public bool IsUserOwner { get; set; }
    }
}
