using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class BooksController: Controller
    {

        private readonly BooksService booksService;
        private readonly AuthenticateService authenticateService;
        
        public BooksController(BooksService booksService, AuthenticateService authenticateService)
        {
            this.booksService = booksService;
            this.authenticateService = authenticateService;
        }
        
        public IActionResult Index()
        {

            if (authenticateService.IsAuthenticated())
            {
                return View(this.booksService.GetBooksListing().ToList());
            }

            return Redirect("login");
        }

        [HttpGet]
        public IActionResult AddBook(string id)
        {
            
            this.booksService.AddBookToUser(id);
            
            return Redirect("/books");
        }

        [HttpGet]
        public IActionResult CreateBook()
        {
            if (authenticateService.IsAuthenticated() && authenticateService.IsAdmin())
            {
                return View(new CreateBookViewModel() { Authors = this.booksService.GetAllAuthors() });
            }

            return Redirect("/");
        }

        [HttpPost]
        public IActionResult CreateBook(CreateBookViewModel model)
        {
            this.booksService.AddBook(model.AuthorId, model.BookTitle);

            return Redirect("/");
        }
        
    }
}