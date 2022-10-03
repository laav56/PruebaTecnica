using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlDePersonal.Data.Migrations
{
    public partial class ControlDePersonalMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Puesto_Empleado_Puesto",
                table: "Puesto");

            migrationBuilder.DropIndex(
                name: "IX_Puesto_Puesto",
                table: "Puesto");

            migrationBuilder.DropColumn(
                name: "Puesto",
                table: "Puesto");

            migrationBuilder.AddColumn<int>(
                name: "id_puesto",
                table: "Empleado",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_puesto",
                table: "Empleado");

            migrationBuilder.AddColumn<int>(
                name: "Puesto",
                table: "Puesto",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Puesto_Puesto",
                table: "Puesto",
                column: "Puesto");

            migrationBuilder.AddForeignKey(
                name: "FK_Puesto_Empleado_Puesto",
                table: "Puesto",
                column: "Puesto",
                principalTable: "Empleado",
                principalColumn: "id_empleado");
        }
    }
}
