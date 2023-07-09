using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRİPTİON = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TITLE = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AUTHOR = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    CONTEXT = table.Column<string>(type: "nvarchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "ID", "AUTHOR", "CONTEXT", "DESCRİPTİON", "Name", "TITLE" },
                values: new object[] { 1, "Hasan", "Selam dünya ben hasan", "Her şeyin temeline temel bir bakış", "Eleştirel Düşünme", "Eleştirel düşünmeye bir bakış" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
