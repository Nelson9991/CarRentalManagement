using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 7, 31, 17, 41, 28, 138, DateTimeKind.Local).AddTicks(7708), new DateTime(2021, 7, 31, 17, 41, 28, 139, DateTimeKind.Local).AddTicks(5021), "Black", "System" },
                    { 2, "System", new DateTime(2021, 7, 31, 17, 41, 28, 139, DateTimeKind.Local).AddTicks(5834), new DateTime(2021, 7, 31, 17, 41, 28, 139, DateTimeKind.Local).AddTicks(5840), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 7, 31, 17, 41, 28, 140, DateTimeKind.Local).AddTicks(7245), new DateTime(2021, 7, 31, 17, 41, 28, 140, DateTimeKind.Local).AddTicks(7239), "Toyota", "System" },
                    { 2, "System", new DateTime(2021, 7, 31, 17, 41, 28, 140, DateTimeKind.Local).AddTicks(7249), new DateTime(2021, 7, 31, 17, 41, 28, 140, DateTimeKind.Local).AddTicks(7248), "Renault", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 7, 31, 17, 41, 28, 141, DateTimeKind.Local).AddTicks(835), new DateTime(2021, 7, 31, 17, 41, 28, 141, DateTimeKind.Local).AddTicks(829), "Prius", "System" },
                    { 2, "System", new DateTime(2021, 7, 31, 17, 41, 28, 141, DateTimeKind.Local).AddTicks(839), new DateTime(2021, 7, 31, 17, 41, 28, 141, DateTimeKind.Local).AddTicks(838), "Vitz", "System" },
                    { 3, "System", new DateTime(2021, 7, 31, 17, 41, 28, 141, DateTimeKind.Local).AddTicks(841), new DateTime(2021, 7, 31, 17, 41, 28, 141, DateTimeKind.Local).AddTicks(840), "3 Series", "System" },
                    { 4, "System", new DateTime(2021, 7, 31, 17, 41, 28, 141, DateTimeKind.Local).AddTicks(843), new DateTime(2021, 7, 31, 17, 41, 28, 141, DateTimeKind.Local).AddTicks(842), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
