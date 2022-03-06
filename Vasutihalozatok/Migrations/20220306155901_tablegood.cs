using Microsoft.EntityFrameworkCore.Migrations;

namespace Vasutihalozatok.Migrations
{
    public partial class tablegood : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jaratok_City_kiidnulo_varosid",
                table: "Jaratok");

            migrationBuilder.DropForeignKey(
                name: "FK_Jaratok_City_megerkezo_varosid",
                table: "Jaratok");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DropColumn(
                name: "idotartalom",
                table: "Jaratok");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Varosok");

            migrationBuilder.AddColumn<int>(
                name: "Tavolsag",
                table: "Jaratok",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Varosok",
                table: "Varosok",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Felhasznalok",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jelszo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Felhasznalok", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Jaratok_Varosok_kiidnulo_varosid",
                table: "Jaratok",
                column: "kiidnulo_varosid",
                principalTable: "Varosok",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jaratok_Varosok_megerkezo_varosid",
                table: "Jaratok",
                column: "megerkezo_varosid",
                principalTable: "Varosok",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jaratok_Varosok_kiidnulo_varosid",
                table: "Jaratok");

            migrationBuilder.DropForeignKey(
                name: "FK_Jaratok_Varosok_megerkezo_varosid",
                table: "Jaratok");

            migrationBuilder.DropTable(
                name: "Felhasznalok");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Varosok",
                table: "Varosok");

            migrationBuilder.DropColumn(
                name: "Tavolsag",
                table: "Jaratok");

            migrationBuilder.RenameTable(
                name: "Varosok",
                newName: "City");

            migrationBuilder.AddColumn<string>(
                name: "idotartalom",
                table: "Jaratok",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jaratok_City_kiidnulo_varosid",
                table: "Jaratok",
                column: "kiidnulo_varosid",
                principalTable: "City",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jaratok_City_megerkezo_varosid",
                table: "Jaratok",
                column: "megerkezo_varosid",
                principalTable: "City",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
