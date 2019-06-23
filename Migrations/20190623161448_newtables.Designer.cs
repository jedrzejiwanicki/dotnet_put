﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190623161448_newtables")]
    partial class newtables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplication1.Data.Author", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "John Doe"
                        });
                });

            modelBuilder.Entity("WebApplication1.Data.AuthorBook", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorId");

                    b.Property<string>("BookId");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("AuthorBooks");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AuthorId = "1",
                            BookId = "2"
                        });
                });

            modelBuilder.Entity("WebApplication1.Data.Book", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = "2",
                            Name = "Title"
                        });
                });

            modelBuilder.Entity("WebApplication1.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("Token");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApplication1.Data.UserBook", b =>
                {
                    b.Property<string>("BookId");

                    b.Property<string>("UserId");

                    b.Property<string>("Id")
                        .IsRequired();

                    b.Property<int?>("UserId1");

                    b.HasKey("BookId", "UserId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("UserId1");

                    b.ToTable("UserBooks");
                });

            modelBuilder.Entity("WebApplication1.Data.AuthorBook", b =>
                {
                    b.HasOne("WebApplication1.Data.Author", "Author")
                        .WithMany("AuthorBooks")
                        .HasForeignKey("AuthorId");

                    b.HasOne("WebApplication1.Data.Book", "Book")
                        .WithMany("AuthorBooks")
                        .HasForeignKey("BookId");
                });

            modelBuilder.Entity("WebApplication1.Data.UserBook", b =>
                {
                    b.HasOne("WebApplication1.Data.Book", "Book")
                        .WithMany("UserBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Data.User", "User")
                        .WithMany("UserBooks")
                        .HasForeignKey("UserId1");
                });
#pragma warning restore 612, 618
        }
    }
}