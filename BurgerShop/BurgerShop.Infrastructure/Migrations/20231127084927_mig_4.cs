using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerShop.Infrastructure.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "48ecb20a-48e8-4ba4-b2b4-cbbbf52cdc73");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "521d4574-e728-4e6e-9dc9-19221a1b9c4b");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6783f946-d434-437b-bb1c-485a61eafe7c", "fec9644e-dbeb-4e0a-89f5-f75ae59a49fa", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9e31b318-a285-413f-8981-9aee6588eabd", "19cb602b-80c1-48f3-a909-0663fe4b3e21", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6783f946-d434-437b-bb1c-485a61eafe7c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9e31b318-a285-413f-8981-9aee6588eabd");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "48ecb20a-48e8-4ba4-b2b4-cbbbf52cdc73", "ead2a296-7cfa-4c4a-a902-26c417d4f2c8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "521d4574-e728-4e6e-9dc9-19221a1b9c4b", "eac04a31-fc71-48ed-baa9-4d3443936077", "Admin", "ADMIN" });
        }
    }
}
