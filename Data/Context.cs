using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApplication1.Data
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options): base(options) {}
        
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }
        public DbSet<AuthorBook> AuthorBooks { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
/*            modelBuilder.Entity<UserBook>()
                .HasKey(userBook => new
                {
                    userBook.UserId,
                    userBook.BookId,
                });
            
            modelBuilder.Entity<AuthorBook>()
                .HasKey(authorBook => new
                {
                    authorBook.BookId,
                    authorBook.AuthorId,
                });*/
            
            modelBuilder.Entity<AuthorBook>()
                .HasOne<Author>(sc => sc.Author)
                .WithMany(s => s.AuthorBooks)
                .HasForeignKey(sc => sc.AuthorId);
            
            modelBuilder.Entity<AuthorBook>()
                .HasOne<Book>(sc => sc.Book)
                .WithMany(s => s.AuthorBooks)
                .HasForeignKey(sc => sc.BookId);


            modelBuilder.Entity<UserBook>()
                .HasOne<User>(u => u.User)
                .WithMany(u => u.UserBooks)
                .HasForeignKey(u => u.UserId);
            
            modelBuilder.Entity<UserBook>()
                .HasOne<Book>(u => u.Book)
                .WithMany(u => u.UserBooks)
                .HasForeignKey(u => u.BookId);
                
            // Seed
            
            var user_1 = new User() { Username = "admin", Id = "123", Role = UserRole.Admin, Password = "admin", Email = "admin@admin.com", Token = Guid.NewGuid().ToString()};
            var user_2 = new User() { Username = "user", Id = "321", Role = UserRole.Default, Password = "user", Email = "admin@admin.com", Token = Guid.NewGuid().ToString()};
            
            var author_1 = new Author() {Name = "John Doe", Id = "1"};
            var author_2 = new Author() {Name = "Jack Black", Id = "2"};
            var author_3 = new Author() {Name = "Jane White", Id = "3"};
            
            var book_1 = new Book() {Name = "Green Mile", Id = "1"};
            var book_2 = new Book() {Name = "Book of Memes", Id = "2"};
            var book_3 = new Book() {Name = "Red Dragon", Id = "3"};
            var book_4 = new Book() {Name = "Catch 22", Id = "4"};
            var book_5 = new Book() {Name = "Harry Potter", Id = "5"};

            modelBuilder.Entity<User>().HasData(user_1);
            modelBuilder.Entity<User>().HasData(user_2);
            
            modelBuilder.Entity<Author>().HasData(author_1);
            modelBuilder.Entity<Author>().HasData(author_2);
            modelBuilder.Entity<Author>().HasData(author_3);
            
            
            modelBuilder.Entity<Book>().HasData(book_1);
            modelBuilder.Entity<Book>().HasData(book_2);
            modelBuilder.Entity<Book>().HasData(book_3);
            modelBuilder.Entity<Book>().HasData(book_4);
            modelBuilder.Entity<Book>().HasData(book_5);

            modelBuilder.Entity<AuthorBook>().HasData(new AuthorBook() {Id = "1", AuthorId = author_1.Id, BookId = book_1.Id});
            modelBuilder.Entity<AuthorBook>().HasData(new AuthorBook() {Id = "2", AuthorId = author_1.Id, BookId = book_2.Id});
            modelBuilder.Entity<AuthorBook>().HasData(new AuthorBook() {Id = "3", AuthorId = author_2.Id, BookId = book_3.Id});
            modelBuilder.Entity<AuthorBook>().HasData(new AuthorBook() {Id = "4", AuthorId = author_3.Id, BookId = book_3.Id});
            modelBuilder.Entity<AuthorBook>().HasData(new AuthorBook() {Id = "5", AuthorId = author_3.Id, BookId = book_4.Id});
            modelBuilder.Entity<AuthorBook>().HasData(new AuthorBook() {Id = "6", AuthorId = author_3.Id, BookId = book_5.Id});
            
            modelBuilder.Entity<UserBook>().HasData(new UserBook() {Id = "1", UserId = user_1.Id, BookId = book_1.Id});

        }
    }
}