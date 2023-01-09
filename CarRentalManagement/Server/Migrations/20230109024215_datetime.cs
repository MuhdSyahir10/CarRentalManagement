using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class datetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "38704abf-98ec-4129-84b9-aa0e6b48edd8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "3ce99a30-8bee-46ba-ac7e-e4295f153c17");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d4994ab-f884-438e-968e-9093a2338362", "AQAAAAEAACcQAAAAELX9d5sfV0V+pghizMwcgAXK/himdO/GdOL93A2jAel/s21VCROea0G5kWlOlir7dA==", "a537add2-5fa5-4b73-9c70-31302af57e9f" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 42, 13, 913, DateTimeKind.Local).AddTicks(7367), new DateTime(2023, 1, 9, 10, 42, 13, 915, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 42, 13, 915, DateTimeKind.Local).AddTicks(4325), new DateTime(2023, 1, 9, 10, 42, 13, 915, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 42, 13, 917, DateTimeKind.Local).AddTicks(524), new DateTime(2023, 1, 9, 10, 42, 13, 917, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 42, 13, 917, DateTimeKind.Local).AddTicks(543), new DateTime(2023, 1, 9, 10, 42, 13, 917, DateTimeKind.Local).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 42, 13, 917, DateTimeKind.Local).AddTicks(5235), new DateTime(2023, 1, 9, 10, 42, 13, 917, DateTimeKind.Local).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 42, 13, 917, DateTimeKind.Local).AddTicks(5248), new DateTime(2023, 1, 9, 10, 42, 13, 917, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 42, 13, 917, DateTimeKind.Local).AddTicks(5252), new DateTime(2023, 1, 9, 10, 42, 13, 917, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 42, 13, 917, DateTimeKind.Local).AddTicks(5255), new DateTime(2023, 1, 9, 10, 42, 13, 917, DateTimeKind.Local).AddTicks(5257) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "8d495ffd-7269-4fb2-9d78-74776d1738e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "3311a639-85de-4737-bf4b-2f548dae80bb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a76240d3-ce06-47da-b9d5-c45b165b16ce", "AQAAAAEAACcQAAAAEKjoZftrq7yfBvWiUDPsCbSsEhJ65WB1cQ5Gv+/zsvdUYREqKrtHasg0CxQMvPOIPg==", "4b29e37c-2a64-4756-a5a1-01ff27be4480" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 23, 16, 16, 532, DateTimeKind.Local).AddTicks(4278), new DateTime(2023, 1, 8, 23, 16, 16, 533, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 23, 16, 16, 533, DateTimeKind.Local).AddTicks(6950), new DateTime(2023, 1, 8, 23, 16, 16, 533, DateTimeKind.Local).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 23, 16, 16, 535, DateTimeKind.Local).AddTicks(6515), new DateTime(2023, 1, 8, 23, 16, 16, 535, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 23, 16, 16, 535, DateTimeKind.Local).AddTicks(6536), new DateTime(2023, 1, 8, 23, 16, 16, 535, DateTimeKind.Local).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 23, 16, 16, 536, DateTimeKind.Local).AddTicks(1059), new DateTime(2023, 1, 8, 23, 16, 16, 536, DateTimeKind.Local).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 23, 16, 16, 536, DateTimeKind.Local).AddTicks(1072), new DateTime(2023, 1, 8, 23, 16, 16, 536, DateTimeKind.Local).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 23, 16, 16, 536, DateTimeKind.Local).AddTicks(1076), new DateTime(2023, 1, 8, 23, 16, 16, 536, DateTimeKind.Local).AddTicks(1077) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 23, 16, 16, 536, DateTimeKind.Local).AddTicks(1079), new DateTime(2023, 1, 8, 23, 16, 16, 536, DateTimeKind.Local).AddTicks(1081) });
        }
    }
}
