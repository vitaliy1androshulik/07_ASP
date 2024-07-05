using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _03_SecondHomeWorkViewModel.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BrandOfCars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandOfCars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mercedes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandOfCarId = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Volume = table.Column<double>(type: "float", nullable: false),
                    HorsePower = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mercedes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mercedes_BrandOfCars_BrandOfCarId",
                        column: x => x.BrandOfCarId,
                        principalTable: "BrandOfCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BrandOfCars",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mercedes-Benz" },
                    { 2, "Mercedes-AMG" }
                });

            migrationBuilder.InsertData(
                table: "Mercedes",
                columns: new[] { "Id", "BrandOfCarId", "Class", "Discount", "HorsePower", "Model", "Price", "Volume", "Year" },
                values: new object[,]
                {
                    { 1, 1, "E-Class", 2, 375, "E450 4MATIC", 3735256, 3.0, 2024 },
                    { 2, 1, "E-Class", 5, 194, "E 220 d", 2823744, 2.0, 2024 },
                    { 3, 1, "A-Class", 2, 136, "A 180", 1998166, 1.95, 2024 },
                    { 4, 2, "A-Class", 0, 306, "A 35 AMG 4MATIC", 2794320, 2.0, 2024 },
                    { 5, 1, "C-Class", 15, 168, "C 180", 2148646, 1.5, 2024 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mercedes_BrandOfCarId",
                table: "Mercedes",
                column: "BrandOfCarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mercedes");

            migrationBuilder.DropTable(
                name: "BrandOfCars");
        }
    }
}
