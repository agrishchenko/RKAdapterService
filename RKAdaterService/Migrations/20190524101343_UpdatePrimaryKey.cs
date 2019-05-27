using Microsoft.EntityFrameworkCore.Migrations;

namespace RKAdapterService.Migrations
{
    public partial class UpdatePrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentItems",
                table: "PaymentItems");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "PaymentItems",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentItems",
                table: "PaymentItems",
                columns: new[] { "ExternalId", "UserId" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_PaymentItems_ExternalId_Id_UserId",
                table: "PaymentItems",
                columns: new[] { "ExternalId", "Id", "UserId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentItems",
                table: "PaymentItems");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_PaymentItems_ExternalId_Id_UserId",
                table: "PaymentItems");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "PaymentItems",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentItems",
                table: "PaymentItems",
                column: "Id");
        }
    }
}
