using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VotacionesAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCedulaToVoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cedula",
                table: "Votos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cedula",
                table: "Votos");
        }
    }
}
