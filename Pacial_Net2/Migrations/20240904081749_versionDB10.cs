using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pacial_Net2.Migrations
{
    /// <inheritdoc />
    public partial class versionDB10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isActivo",
                table: "vehiculo",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "precio",
                table: "vehiculo",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActivo",
                table: "vehiculo");

            migrationBuilder.DropColumn(
                name: "precio",
                table: "vehiculo");
        }
    }
}
