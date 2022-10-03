using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlDePersonal.Data.Migrations
{
    public partial class ControlDePersonalMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamento_Puesto_fk_puesto_depto",
                table: "Departamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Empleado_fk_empleado_persona",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Puesto_Empleado_fk_empleado_puesto",
                table: "Puesto");

            migrationBuilder.DropIndex(
                name: "IX_Persona_fk_empleado_persona",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Departamento_fk_puesto_depto",
                table: "Departamento");

            migrationBuilder.DropColumn(
                name: "fk_empleado_persona",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "fk_puesto_depto",
                table: "Departamento");

            migrationBuilder.RenameColumn(
                name: "fk_empleado_puesto",
                table: "Puesto",
                newName: "Puesto");

            migrationBuilder.RenameIndex(
                name: "IX_Puesto_fk_empleado_puesto",
                table: "Puesto",
                newName: "IX_Puesto_Puesto");

            migrationBuilder.AddColumn<int>(
                name: "id_depto",
                table: "Puesto",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_persona",
                table: "Empleado",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Puesto_Empleado_Puesto",
                table: "Puesto",
                column: "Puesto",
                principalTable: "Empleado",
                principalColumn: "id_empleado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Puesto_Empleado_Puesto",
                table: "Puesto");

            migrationBuilder.DropColumn(
                name: "id_depto",
                table: "Puesto");

            migrationBuilder.DropColumn(
                name: "id_persona",
                table: "Empleado");

            migrationBuilder.RenameColumn(
                name: "Puesto",
                table: "Puesto",
                newName: "fk_empleado_puesto");

            migrationBuilder.RenameIndex(
                name: "IX_Puesto_Puesto",
                table: "Puesto",
                newName: "IX_Puesto_fk_empleado_puesto");

            migrationBuilder.AddColumn<int>(
                name: "fk_empleado_persona",
                table: "Persona",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "fk_puesto_depto",
                table: "Departamento",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persona_fk_empleado_persona",
                table: "Persona",
                column: "fk_empleado_persona");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_fk_puesto_depto",
                table: "Departamento",
                column: "fk_puesto_depto");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamento_Puesto_fk_puesto_depto",
                table: "Departamento",
                column: "fk_puesto_depto",
                principalTable: "Puesto",
                principalColumn: "id_puesto");

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Empleado_fk_empleado_persona",
                table: "Persona",
                column: "fk_empleado_persona",
                principalTable: "Empleado",
                principalColumn: "id_empleado");

            migrationBuilder.AddForeignKey(
                name: "FK_Puesto_Empleado_fk_empleado_puesto",
                table: "Puesto",
                column: "fk_empleado_puesto",
                principalTable: "Empleado",
                principalColumn: "id_empleado");
        }
    }
}
