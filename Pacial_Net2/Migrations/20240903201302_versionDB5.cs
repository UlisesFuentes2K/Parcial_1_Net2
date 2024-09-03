using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pacial_Net2.Migrations
{
    /// <inheritdoc />
    public partial class versionDB5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "anio",
                table: "vehiculo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "anio",
                table: "vehiculo");
        }
    }
}
