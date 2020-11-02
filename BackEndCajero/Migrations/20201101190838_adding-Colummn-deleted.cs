using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndCajero.Migrations
{
    public partial class addingColummndeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Client",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Account",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Account");
        }
    }
}
