using Microsoft.EntityFrameworkCore.Migrations;

namespace RKAdapterService.Migrations
{
    public partial class addProcessedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Processed",
                table: "PaymentItems",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Processed",
                table: "PaymentItems");
        }
    }
}
