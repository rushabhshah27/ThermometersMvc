using Microsoft.EntityFrameworkCore.Migrations;

namespace ThermometersMvc.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Thermometers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfThermometer = table.Column<string>(nullable: true),
                    TemperatureRange = table.Column<decimal>(nullable: false),
                    ProbeType = table.Column<string>(nullable: true),
                    Accuracy = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Display = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thermometers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Thermometers");
        }
    }
}
