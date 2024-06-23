using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkPractice.Migrations
{
    /// <inheritdoc />
    public partial class initialIncrement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_Invoices_InvoiceId",
                table: "InvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Retailers_RetailerFK",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_RetailerFK",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceItems_InvoiceId",
                table: "InvoiceItems");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "RetailerFK",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "InvoiceItems");

            migrationBuilder.AddColumn<int>(
                name: "RetailerFK",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderFK",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_RetailerFK",
                table: "Orders",
                column: "RetailerFK");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderFK",
                table: "OrderItems",
                column: "OrderFK");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_InvoiceFK",
                table: "InvoiceItems",
                column: "InvoiceFK");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_Invoices_InvoiceFK",
                table: "InvoiceItems",
                column: "InvoiceFK",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderFK",
                table: "OrderItems",
                column: "OrderFK",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Retailers_RetailerFK",
                table: "Orders",
                column: "RetailerFK",
                principalTable: "Retailers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_Invoices_InvoiceFK",
                table: "InvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderFK",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Retailers_RetailerFK",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_RetailerFK",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderFK",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceItems_InvoiceFK",
                table: "InvoiceItems");

            migrationBuilder.DropColumn(
                name: "RetailerFK",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderFK",
                table: "OrderItems");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "OrderItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RetailerFK",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "InvoiceItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_RetailerFK",
                table: "Invoices",
                column: "RetailerFK");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_InvoiceId",
                table: "InvoiceItems",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_Invoices_InvoiceId",
                table: "InvoiceItems",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Retailers_RetailerFK",
                table: "Invoices",
                column: "RetailerFK",
                principalTable: "Retailers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
