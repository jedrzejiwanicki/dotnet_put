using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;


namespace WebApplication1.Services
{

    
    public class BooksService
    {
        private readonly Context db;
        private readonly UserService userService;
        
        public BooksService(Context db, UserService userService)
        {
            this.db = db;
            this.userService = userService;
        }

        public IEnumerable<BookListViewModel> GetBooksListing()
        {
            var books = this.db.Books
                .Include(x => x.AuthorBooks)
                .ThenInclude(x => x.Author)
                .Include(x => x.UserBooks)
                .ThenInclude(x => x.User)
                .ToList();

            return books.Select(x => new BookListViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Authors = x.AuthorBooks.Select(y => y.Author.Name),
                IsUserOwner = x.UserBooks.FirstOrDefault(y => y.BookId == x.Id) != null,
            });
            
        }

        public void AddBookToUser(string id)
        {
            User user = this.userService.GetUserFromCookieToken();
            Book book = this.db.Books.Where(x => x.Id == id).FirstOrDefault();

            Console.WriteLine(user.Id);
            
            this.db.UserBooks.Add(new UserBook() { BookId = book.Id, UserId = user.Id });
            this.db.SaveChanges();
        }

        public Author[] GetAllAuthors()
        {
            return this.db.Authors.ToArray();
        }

        public void AddBook(string authorId, string bookTitle)
        {

            var book = this.db.Books.Add(new Book() {Name = bookTitle});
            
            AuthorBook authorBook = new AuthorBook() {BookId = book.Entity.Id, AuthorId = authorId};

            this.db.AuthorBooks.Add(authorBook);
            this.db.SaveChanges();
        }
    }
}