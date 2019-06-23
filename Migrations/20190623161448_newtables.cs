using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class newtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuthorBooks",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AuthorId = table.Column<string>(nullable: true),
                    BookId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorBooks_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuthorBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserBooks",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    BookId = table.Column<string>(nullable: false),
                    Id = table.Column<string>(nullable: false),
                    UserId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBooks", x => new { x.BookId, x.UserId });
                    table.UniqueConstraint("AK_UserBooks_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBooks_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[] { "1", "John Doe" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Name" },
                values: new object[] { "2", "Title" });

            migrationBuilder.InsertData(
                table: "AuthorBooks",
                columns: new[] { "Id", "AuthorId", "BookId" },
                values: new object[] { "1", "1", "2" });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBooks_AuthorId",
                table: "AuthorBooks",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBooks_BookId",
                table: "AuthorBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBooks_UserId1",
                table: "UserBooks",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBooks");

            migrationBuilder.DropTable(
                name: "UserBooks");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
