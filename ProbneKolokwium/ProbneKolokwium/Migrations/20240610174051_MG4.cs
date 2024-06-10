using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProbneKolokwium.Migrations
{
    /// <inheritdoc />
    public partial class MG4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Product_Order_OrderID",
                table: "Product_Order",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientID",
                table: "Order",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StatusID",
                table: "Order",
                column: "StatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Client_ClientID",
                table: "Order",
                column: "ClientID",
                principalTable: "Client",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Status_StatusID",
                table: "Order",
                column: "StatusID",
                principalTable: "Status",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Order_Order_OrderID",
                table: "Product_Order",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Order_Product_ProductID",
                table: "Product_Order",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Client_ClientID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Status_StatusID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Order_Order_OrderID",
                table: "Product_Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Order_Product_ProductID",
                table: "Product_Order");

            migrationBuilder.DropIndex(
                name: "IX_Product_Order_OrderID",
                table: "Product_Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_ClientID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_StatusID",
                table: "Order");
        }
    }
}
