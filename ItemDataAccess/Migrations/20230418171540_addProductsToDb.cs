using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Item.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", "A novel by F. Scott Fitzgerald", "978-0743273565", 15.99, 10.99, 7.9900000000000002, 8.9900000000000002, "The Great Gatsby" },
                    { 2, "Harper Lee", "A novel by Harper Lee", "978-0446310789", 12.99, 8.9900000000000002, 5.9900000000000002, 6.9900000000000002, "To Kill a Mockingbird" },
                    { 3, "George Orwell", "A dystopian novel by George Orwell", "978-0451524935", 14.99, 9.9900000000000002, 6.9900000000000002, 7.9900000000000002, "1984" },
                    { 4, "Jane Austen", "A novel by Jane Austen", "978-0486284736", 11.99, 7.9900000000000002, 4.9900000000000002, 5.9900000000000002, "Pride and Prejudice" },
                    { 5, "J.D. Salinger", "A novel by J.D. Salinger", "978-0316769488", 13.99, 9.9900000000000002, 6.9900000000000002, 7.9900000000000002, "The Catcher in the Rye" },
                    { 6, "J.R.R. Tolkien", "A novel by J.R.R. Tolkien", "978-0547928227", 18.989999999999998, 12.99, 0.0, 10.99, "The Hobbit" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
