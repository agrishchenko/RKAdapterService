using Microsoft.EntityFrameworkCore.Migrations;

namespace RKAdapterService.Migrations
{
    public partial class UpdateUniqueKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_PaymentItems_ExternalId_Id_UserId",
                table: "PaymentItems");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_PaymentItems_Id",
                table: "PaymentItems",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_PaymentItems_Id",
                table: "PaymentItems");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_PaymentItems_ExternalId_Id_UserId",
                table: "PaymentItems",
                columns: new[] { "ExternalId", "Id", "UserId" });
        }
    }
}
