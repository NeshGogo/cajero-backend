using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndCajero.Migrations
{
    public partial class addingtransationDestination : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransactionDestination",
                table: "Transaction",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionDestination",
                table: "Transaction");
        }
    }
}
