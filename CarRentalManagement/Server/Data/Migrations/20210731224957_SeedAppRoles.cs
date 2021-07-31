using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedAppRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4773b382-f111-40d9-a7fa-97a1d4e6f56b", "d5f17cdd-3fdf-419c-b639-8a7e47add806", "User", "USER" },
                    { "8edcf877-982c-4624-b79a-527beb428f8e", "88e87bb8-44ee-440b-a0b7-a7c3d3638aff", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 17, 49, 57, 78, DateTimeKind.Local).AddTicks(9580), new DateTime(2021, 7, 31, 17, 49, 57, 79, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 17, 49, 57, 79, DateTimeKind.Local).AddTicks(7395), new DateTime(2021, 7, 31, 17, 49, 57, 79, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 17, 49, 57, 80, DateTimeKind.Local).AddTicks(7355), new DateTime(2021, 7, 31, 17, 49, 57, 80, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 17, 49, 57, 80, DateTimeKind.Local).AddTicks(7359), new DateTime(2021, 7, 31, 17, 49, 57, 80, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 17, 49, 57, 81, DateTimeKind.Local).AddTicks(263), new DateTime(2021, 7, 31, 17, 49, 57, 81, DateTimeKind.Local).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 17, 49, 57, 81, DateTimeKind.Local).AddTicks(266), new DateTime(2021, 7, 31, 17, 49, 57, 81, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 17, 49, 57, 81, DateTimeKind.Local).AddTicks(268), new DateTime(2021, 7, 31, 17, 49, 57, 81, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 17, 49, 57, 81, DateTimeKind.Local).AddTicks(270), new DateTime(2021, 7, 31, 17, 49, 57, 81, DateTimeKind.Local).AddTicks(270) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4773b382-f111-40d9-a7fa-97a1d4e6f56b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8edcf877-982c-4624-b79a-527beb428f8e");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 17, 41, 28, 138, DateTimeKind.Local).AddTicks(7708), new DateTime(2021, 7, 31, 17, 41, 28, 139, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 17, 41, 28, 139, DateTimeKind.Local).AddTicks(5834), new DateTime(2021, 7, 31, 17, 41, 28, 139, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 17, 41, 28, 140, DateTimeKind.Local).AddTicks(7245), new DateTime(2021, 7, 31, 17, 41, 28, 140, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 17, 41, 28, 140, DateTimeKind.Local).AddTicks(7249), new DateTime(2021, 7, 31, 17, 41, 28, 140, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 17, 41, 28, 141, DateTimeKind.Local).AddTicks(835), new DateTime(2021, 7, 31, 17, 41, 28, 141, DateTimeKind.Local).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 17, 41, 28, 141, DateTimeKind.Local).AddTicks(839), new DateTime(2021, 7, 31, 17, 41, 28, 141, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 17, 41, 28, 141, DateTimeKind.Local).AddTicks(841), new DateTime(2021, 7, 31, 17, 41, 28, 141, DateTimeKind.Local).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 17, 41, 28, 141, DateTimeKind.Local).AddTicks(843), new DateTime(2021, 7, 31, 17, 41, 28, 141, DateTimeKind.Local).AddTicks(842) });
        }
    }
}
