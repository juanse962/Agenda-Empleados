using Microsoft.EntityFrameworkCore.Migrations;

namespace EmpleadoController.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Empleado",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubArea",
                table: "Empleado",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "SubArea",
                table: "Empleado");
        }
    }
}
