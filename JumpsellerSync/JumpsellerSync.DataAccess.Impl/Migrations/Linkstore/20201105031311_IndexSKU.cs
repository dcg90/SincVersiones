﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace JumpsellerSync.DataAccess.Impl.Migrations.Linkstore
{
    public partial class IndexSKU : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCode",
                table: "Products",
                column: "ProductCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_ProductCode",
                table: "Products");
        }
    }
}
