using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MODELO.Migrations
{
    /// <inheritdoc />
    public partial class prime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tipo_usuario",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tipo_usuario",
                table: "Usuarios",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
