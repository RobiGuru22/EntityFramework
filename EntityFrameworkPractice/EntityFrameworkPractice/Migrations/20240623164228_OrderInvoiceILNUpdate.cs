using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkPractice.Migrations
{
    /// <inheritdoc />
    public partial class OrderInvoiceILNUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SupplierILN",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RetailerILN",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SupplierILN",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "RetailerILN",
                table: "Invoices");
        }
    }
}
