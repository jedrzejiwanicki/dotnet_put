using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserBooks_Books_BookId",
                table: "UserBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBooks_Users_UserId1",
                table: "UserBooks");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_UserBooks_Id",
                table: "UserBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserBooks",
                table: "UserBooks");

            migrationBuilder.DropIndex(
                name: "IX_UserBooks_UserId1",
                table: "UserBooks");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserBooks");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserBooks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "BookId",
                table: "UserBooks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserBooks",
                table: "UserBooks",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AuthorBooks",
                columns: new[] { "Id", "AuthorId", "BookId" },
                values: new object[] { "2", "1", "2" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "2", "Jack Black" },
                    { "3", "Jane White" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "2",
                column: "Name",
                value: "Book of Memes");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1", "Green Mile" },
                    { "3", "Red Dragon" },
                    { "4", "Catch 22" },
                    { "5", "Harry Potter" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Role", "Token", "Username" },
                values: new object[,]
                {
                    { "123", "admin@admin.com", "admin", 1, "0151ae4f-3d5d-435d-b188-ec59e083f089", "admin" },
                    { "321", "admin@admin.com", "user", 0, "285ef9d5-75a9-4467-8890-8b4c4df5d091", "user" }
                });

            migrationBuilder.UpdateData(
                table: "AuthorBooks",
                keyColumn: "Id",
                keyValue: "1",
                column: "BookId",
                value: "1");

            migrationBuilder.InsertData(
                table: "AuthorBooks",
                columns: new[] { "Id", "AuthorId", "BookId" },
                values: new object[,]
                {
                    { "3", "2", "3" },
                    { "4", "3", "3" },
                    { "5", "3", "4" },
                    { "6", "3", "5" }
                });

            migrationBuilder.InsertData(
                table: "UserBooks",
                columns: new[] { "Id", "BookId", "UserId" },
                values: new object[] { "1", "1", "123" });

            migrationBuilder.CreateIndex(
                name: "IX_UserBooks_BookId",
                table: "UserBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBooks_UserId",
                table: "UserBooks",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserBooks_Books_BookId",
                table: "UserBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBooks_Users_UserId",
                table: "UserBooks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserBooks_Books_BookId",
                table: "UserBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBooks_Users_UserId",
                table: "UserBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserBooks",
                table: "UserBooks");

            migrationBuilder.DropIndex(
                name: "IX_UserBooks_BookId",
                table: "UserBooks");

            migrationBuilder.DropIndex(
                name: "IX_UserBooks_UserId",
                table: "UserBooks");

            migrationBuilder.DeleteData(
                table: "AuthorBooks",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AuthorBooks",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AuthorBooks",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AuthorBooks",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AuthorBooks",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "UserBooks",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "321");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "123");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserBooks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BookId",
                table: "UserBooks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "UserBooks",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_UserBooks_Id",
                table: "UserBooks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserBooks",
                table: "UserBooks",
                columns: new[] { "BookId", "UserId" });

            migrationBuilder.UpdateData(
                table: "AuthorBooks",
                keyColumn: "Id",
                keyValue: "1",
                column: "BookId",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "2",
                column: "Name",
                value: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_UserBooks_UserId1",
                table: "UserBooks",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserBooks_Books_BookId",
                table: "UserBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBooks_Users_UserId1",
                table: "UserBooks",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
