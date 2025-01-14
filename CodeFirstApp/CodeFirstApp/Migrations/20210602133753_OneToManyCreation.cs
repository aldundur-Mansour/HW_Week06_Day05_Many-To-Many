﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApp.Migrations
{
    public partial class OneToManyCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchID",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_BranchID",
                table: "Products",
                column: "BranchID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Branches_BranchID",
                table: "Products",
                column: "BranchID",
                principalTable: "Branches",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Branches_BranchID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_BranchID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BranchID",
                table: "Products");
        }
    }
}
