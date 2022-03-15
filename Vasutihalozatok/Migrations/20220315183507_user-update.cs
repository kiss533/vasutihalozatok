using Microsoft.EntityFrameworkCore.Migrations;

namespace Vasutihalozatok.Migrations
{
    public partial class userupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Felhasznalok",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "felhasznalonev",
                table: "Felhasznalok",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "Felhasznalok");

            migrationBuilder.DropColumn(
                name: "felhasznalonev",
                table: "Felhasznalok");
        }
    }
}
