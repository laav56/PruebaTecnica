using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlDePersonal.Data.Migrations
{
    public partial class ControlDePersonalMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genero_Persona_fk_persona_genero",
                table: "Genero");

            migrationBuilder.DropIndex(
                name: "IX_Genero_fk_persona_genero",
                table: "Genero");

            migrationBuilder.DropColumn(
                name: "fk_persona_genero",
                table: "Genero");

            migrationBuilder.AddColumn<int>(
                name: "id_genero",
                table: "Persona",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_genero",
                table: "Persona");

            migrationBuilder.AddColumn<int>(
                name: "fk_persona_genero",
                table: "Genero",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genero_fk_persona_genero",
                table: "Genero",
                column: "fk_persona_genero");

            migrationBuilder.AddForeignKey(
                name: "FK_Genero_Persona_fk_persona_genero",
                table: "Genero",
                column: "fk_persona_genero",
                principalTable: "Persona",
                principalColumn: "id_persona");
        }
    }
}
