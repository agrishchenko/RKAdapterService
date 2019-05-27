using Microsoft.EntityFrameworkCore.Migrations;

namespace RKAdapterService.Migrations
{
    public partial class addTypeBonusRenameColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OpId",
                table: "PaymentItems",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "PaymentItems",
                newName: "UserId");

            migrationBuilder.AddColumn<decimal>(
                name: "Bonus",
                table: "PaymentItems",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ExternalId",
                table: "PaymentItems",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bonus",
                table: "PaymentItems");

            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "PaymentItems");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "PaymentItems",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "PaymentItems",
                newName: "OpId");
        }
    }
}
