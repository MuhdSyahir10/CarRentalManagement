using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "ad3254fd-63c7-46ac-a1a9-51abfa9c149b", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "e15610b6-57dd-4374-8d5c-dc4f6ac5a210", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "fb11521c-a9a9-4c6b-857e-995586a215ed", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEAO/sowO/0rLFOql/HfwIBJkThMhEVAecWJsyo58Sdcn/Soxw4FRFuYiinaJqilNDA==", null, false, "e06adea1-9d44-4551-9468-c5e0ea109eef", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 21, 11, 51, 3, 595, DateTimeKind.Local).AddTicks(7372), new DateTime(2022, 11, 21, 11, 51, 3, 597, DateTimeKind.Local).AddTicks(1695), "Black", "System" },
                    { 2, "System", new DateTime(2022, 11, 21, 11, 51, 3, 597, DateTimeKind.Local).AddTicks(3804), new DateTime(2022, 11, 21, 11, 51, 3, 597, DateTimeKind.Local).AddTicks(3822), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 21, 11, 51, 3, 599, DateTimeKind.Local).AddTicks(9581), new DateTime(2022, 11, 21, 11, 51, 3, 599, DateTimeKind.Local).AddTicks(9607), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 21, 11, 51, 3, 599, DateTimeKind.Local).AddTicks(9612), new DateTime(2022, 11, 21, 11, 51, 3, 599, DateTimeKind.Local).AddTicks(9613), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 21, 11, 51, 3, 600, DateTimeKind.Local).AddTicks(4711), new DateTime(2022, 11, 21, 11, 51, 3, 600, DateTimeKind.Local).AddTicks(4721), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 21, 11, 51, 3, 600, DateTimeKind.Local).AddTicks(4724), new DateTime(2022, 11, 21, 11, 51, 3, 600, DateTimeKind.Local).AddTicks(4726), "X5", "System" },
                    { 3, "System", new DateTime(2022, 11, 21, 11, 51, 3, 600, DateTimeKind.Local).AddTicks(4728), new DateTime(2022, 11, 21, 11, 51, 3, 600, DateTimeKind.Local).AddTicks(4729), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 11, 21, 11, 51, 3, 600, DateTimeKind.Local).AddTicks(4731), new DateTime(2022, 11, 21, 11, 51, 3, 600, DateTimeKind.Local).AddTicks(4732), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
