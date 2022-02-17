using Microsoft.EntityFrameworkCore.Migrations;

namespace Vasutihalozatok.Migrations
{
    public partial class tablecreating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varos = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Jaratok",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kiidnulo_varosid = table.Column<int>(type: "int", nullable: true),
                    megerkezo_varosid = table.Column<int>(type: "int", nullable: true),
                    idotartalom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jaratok", x => x.id);
                    table.ForeignKey(
                        name: "FK_Jaratok_City_kiidnulo_varosid",
                        column: x => x.kiidnulo_varosid,
                        principalTable: "City",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jaratok_City_megerkezo_varosid",
                        column: x => x.megerkezo_varosid,
                        principalTable: "City",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jaratok_kiidnulo_varosid",
                table: "Jaratok",
                column: "kiidnulo_varosid");

            migrationBuilder.CreateIndex(
                name: "IX_Jaratok_megerkezo_varosid",
                table: "Jaratok",
                column: "megerkezo_varosid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jaratok");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
