using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlDePersonal.Data.Migrations
{
    public partial class ControlDePersonalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    id_empleado = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fec_contratacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    salario = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.id_empleado);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    id_persona = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    txt_nombre = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    txt_apellido = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    fec_nac = table.Column<DateTime>(type: "TEXT", nullable: false),
                    cui = table.Column<double>(type: "REAL", nullable: false),
                    nit = table.Column<string>(type: "TEXT", nullable: false),
                    fk_empleado_persona = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.id_persona);
                    table.ForeignKey(
                        name: "FK_Persona_Empleado_fk_empleado_persona",
                        column: x => x.fk_empleado_persona,
                        principalTable: "Empleado",
                        principalColumn: "id_empleado");
                });

            migrationBuilder.CreateTable(
                name: "Puesto",
                columns: table => new
                {
                    id_puesto = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    txt_desc = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    fk_empleado_puesto = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puesto", x => x.id_puesto);
                    table.ForeignKey(
                        name: "FK_Puesto_Empleado_fk_empleado_puesto",
                        column: x => x.fk_empleado_puesto,
                        principalTable: "Empleado",
                        principalColumn: "id_empleado");
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    id_genero = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    txt_desc = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    fk_persona_genero = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.id_genero);
                    table.ForeignKey(
                        name: "FK_Genero_Persona_fk_persona_genero",
                        column: x => x.fk_persona_genero,
                        principalTable: "Persona",
                        principalColumn: "id_persona");
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    id_depto = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    txt_desc = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    fk_puesto_depto = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.id_depto);
                    table.ForeignKey(
                        name: "FK_Departamento_Puesto_fk_puesto_depto",
                        column: x => x.fk_puesto_depto,
                        principalTable: "Puesto",
                        principalColumn: "id_puesto");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_fk_puesto_depto",
                table: "Departamento",
                column: "fk_puesto_depto");

            migrationBuilder.CreateIndex(
                name: "IX_Genero_fk_persona_genero",
                table: "Genero",
                column: "fk_persona_genero");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_fk_empleado_persona",
                table: "Persona",
                column: "fk_empleado_persona");

            migrationBuilder.CreateIndex(
                name: "IX_Puesto_fk_empleado_puesto",
                table: "Puesto",
                column: "fk_empleado_puesto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Puesto");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Empleado");
        }
    }
}
