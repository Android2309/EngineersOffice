using Microsoft.EntityFrameworkCore.Migrations;

namespace EngineersOffice_WebApi.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beam_Guide",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Standart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    h = table.Column<float>(type: "real", nullable: false),
                    b = table.Column<float>(type: "real", nullable: false),
                    s = table.Column<float>(type: "real", nullable: false),
                    t = table.Column<float>(type: "real", nullable: false),
                    r = table.Column<float>(type: "real", nullable: false),
                    F = table.Column<float>(type: "real", nullable: false),
                    lineDensity = table.Column<float>(type: "real", nullable: false),
                    Ix = table.Column<float>(type: "real", nullable: false),
                    Iy = table.Column<float>(type: "real", nullable: false),
                    Wx = table.Column<float>(type: "real", nullable: false),
                    Wy = table.Column<float>(type: "real", nullable: false),
                    Sx = table.Column<float>(type: "real", nullable: false),
                    i_x = table.Column<float>(type: "real", nullable: false),
                    i_y = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beam_Guide", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BendingCoefficient_Guide",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flexibility = table.Column<int>(type: "int", nullable: false),
                    R_200 = table.Column<int>(type: "int", nullable: false),
                    R_220 = table.Column<int>(type: "int", nullable: false),
                    R_240 = table.Column<int>(type: "int", nullable: false),
                    R_260 = table.Column<int>(type: "int", nullable: false),
                    R_280 = table.Column<int>(type: "int", nullable: false),
                    R_300 = table.Column<int>(type: "int", nullable: false),
                    R_320 = table.Column<int>(type: "int", nullable: false),
                    R_340 = table.Column<int>(type: "int", nullable: false),
                    R_360 = table.Column<int>(type: "int", nullable: false),
                    R_380 = table.Column<int>(type: "int", nullable: false),
                    R_400 = table.Column<int>(type: "int", nullable: false),
                    R_440 = table.Column<int>(type: "int", nullable: false),
                    R_480 = table.Column<int>(type: "int", nullable: false),
                    R_520 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BendingCoefficient_Guide", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SteelGrade_Guide",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YieldStress = table.Column<int>(type: "int", nullable: false),
                    TensileStrength = table.Column<int>(type: "int", nullable: false),
                    Elongation = table.Column<int>(type: "int", nullable: false),
                    Contraction = table.Column<int>(type: "int", nullable: false),
                    HB = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SteelGrade_Guide", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beam_Guide");

            migrationBuilder.DropTable(
                name: "BendingCoefficient_Guide");

            migrationBuilder.DropTable(
                name: "SteelGrade_Guide");
        }
    }
}
