using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkPractice.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateRightKeyCombination : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Retailers_RetailerFK",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Suppliers_SupplierFK",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_RetailerFK",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "RetailerFK",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "SupplierFK",
                table: "Invoices",
                newName: "SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_SupplierFK",
                table: "Invoices",
                newName: "IX_Invoices_SupplierId");

            migrationBuilder.AddColumn<int>(
                name: "RetailerFK",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_RetailerFK",
                table: "Orders",
                column: "RetailerFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Suppliers_SupplierId",
                table: "Invoices",
                column: "SupplierId",
                principalTable: "Suppliers",
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
                name: "FK_Invoices_Suppliers_SupplierId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Retailers_RetailerFK",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_RetailerFK",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "RetailerFK",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "Invoices",
                newName: "SupplierFK");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_SupplierId",
                table: "Invoices",
                newName: "IX_Invoices_SupplierFK");

            migrationBuilder.AddColumn<int>(
                name: "RetailerFK",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_RetailerFK",
                table: "Invoices",
                column: "RetailerFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Retailers_RetailerFK",
                table: "Invoices",
                column: "RetailerFK",
                principalTable: "Retailers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Suppliers_SupplierFK",
                table: "Invoices",
                column: "SupplierFK",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
