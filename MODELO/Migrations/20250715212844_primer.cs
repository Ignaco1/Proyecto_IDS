using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MODELO.Migrations
{
    /// <inheritdoc />
    public partial class primer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permisos_Grupos_GrupoId",
                table: "Permisos");

            migrationBuilder.DropIndex(
                name: "IX_Permisos_GrupoId",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "GrupoId",
                table: "Permisos");

            migrationBuilder.CreateTable(
                name: "GrupoPermisos",
                columns: table => new
                {
                    GruposGrupoId = table.Column<int>(type: "int", nullable: false),
                    PermisosPermisoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoPermisos", x => new { x.GruposGrupoId, x.PermisosPermisoId });
                    table.ForeignKey(
                        name: "FK_GrupoPermisos_Grupos_GruposGrupoId",
                        column: x => x.GruposGrupoId,
                        principalTable: "Grupos",
                        principalColumn: "GrupoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrupoPermisos_Permisos_PermisosPermisoId",
                        column: x => x.PermisosPermisoId,
                        principalTable: "Permisos",
                        principalColumn: "PermisoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GrupoPermisos_PermisosPermisoId",
                table: "GrupoPermisos",
                column: "PermisosPermisoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrupoPermisos");

            migrationBuilder.AddColumn<int>(
                name: "GrupoId",
                table: "Permisos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_GrupoId",
                table: "Permisos",
                column: "GrupoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Permisos_Grupos_GrupoId",
                table: "Permisos",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "GrupoId");
        }
    }
}
