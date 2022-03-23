using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShop.EntityFrameWork.Migrations
{
    public partial class Test_full : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Transactions_TransactionID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_ProductID",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_TransactionLines_TransactionLineID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_ProductCategories_ProductID",
                table: "ProductCategories");

            migrationBuilder.DropIndex(
                name: "IX_Employees_TransactionID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "TransactionID",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "TransactionLineID",
                table: "Products",
                newName: "ProductCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_TransactionLineID",
                table: "Products",
                newName: "IX_Products_ProductCategoryID");

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeID",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProductID",
                table: "TransactionLines",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_EmployeeID",
                table: "Transactions",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLines_ProductID",
                table: "TransactionLines",
                column: "ProductID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryID",
                table: "Products",
                column: "ProductCategoryID",
                principalTable: "ProductCategories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLines_Products_ProductID",
                table: "TransactionLines",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Employees_EmployeeID",
                table: "Transactions",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLines_Products_ProductID",
                table: "TransactionLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Employees_EmployeeID",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_EmployeeID",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLines_ProductID",
                table: "TransactionLines");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "TransactionLines");

            migrationBuilder.RenameColumn(
                name: "ProductCategoryID",
                table: "Products",
                newName: "TransactionLineID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductCategoryID",
                table: "Products",
                newName: "IX_Products_TransactionLineID");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductID",
                table: "ProductCategories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TransactionID",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ProductID",
                table: "ProductCategories",
                column: "ProductID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TransactionID",
                table: "Employees",
                column: "TransactionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Transactions_TransactionID",
                table: "Employees",
                column: "TransactionID",
                principalTable: "Transactions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Products_ProductID",
                table: "ProductCategories",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TransactionLines_TransactionLineID",
                table: "Products",
                column: "TransactionLineID",
                principalTable: "TransactionLines",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
