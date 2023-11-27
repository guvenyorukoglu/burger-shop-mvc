using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerShop.Infrastructure.Migrations
{
    public partial class mig_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OrdersMenus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "OrdersMenus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "OrdersMenus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "OrdersMenus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OrdersExtras",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "OrdersExtras",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "OrdersExtras",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "OrdersExtras",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OrdersMenus");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "OrdersMenus");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "OrdersMenus");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "OrdersMenus");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OrdersExtras");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "OrdersExtras");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "OrdersExtras");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "OrdersExtras");
        }
    }
}
