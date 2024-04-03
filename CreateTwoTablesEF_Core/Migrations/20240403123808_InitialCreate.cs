using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CreateTwoTablesEF_Core.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entity01",
                columns: table => new
                {
                    Entity01_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity01", x => x.Entity01_Id);
                });

            migrationBuilder.CreateTable(
                name: "Entity02",
                columns: table => new
                {
                    Entity02_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity02", x => x.Entity02_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entity01");

            migrationBuilder.DropTable(
                name: "Entity02");
        }
    }
}
