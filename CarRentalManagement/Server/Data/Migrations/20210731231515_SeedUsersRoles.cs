using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedUsersRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4773b382-f111-40d9-a7fa-97a1d4e6f56b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8edcf877-982c-4624-b79a-527beb428f8e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "574359ee-f5dc-488a-a3ae-32fb9bbb7aa6", "c4be7d83-e363-4c83-9334-8fe32fa189fa", "User", "USER" },
                    { "356d96b5-dfa6-4ed5-a7b3-be95f68541a2", "08d9bf67-1c39-4d9a-b201-74b73894595e", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5c72668c-fac6-45dc-b5c7-9d8aef14a321", 0, "2c4f991c-fa2a-40e1-91b5-4740a59a71d7", "admin@gmail.com", false, "Admin", "User", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEG/RWyPii+6FV4a6xnqGUL0Hv+U/ha0JjVyNaOh+mSHBQiPD6l1Hx9OVA92AGatF1Q==", null, false, "862e3151-7759-4425-a635-45c6d912b810", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 18, 15, 15, 479, DateTimeKind.Local).AddTicks(1872), new DateTime(2021, 7, 31, 18, 15, 15, 479, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 18, 15, 15, 479, DateTimeKind.Local).AddTicks(9685), new DateTime(2021, 7, 31, 18, 15, 15, 479, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 18, 15, 15, 481, DateTimeKind.Local).AddTicks(403), new DateTime(2021, 7, 31, 18, 15, 15, 481, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 18, 15, 15, 481, DateTimeKind.Local).AddTicks(408), new DateTime(2021, 7, 31, 18, 15, 15, 481, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 18, 15, 15, 481, DateTimeKind.Local).AddTicks(3516), new DateTime(2021, 7, 31, 18, 15, 15, 481, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 18, 15, 15, 481, DateTimeKind.Local).AddTicks(3519), new DateTime(2021, 7, 31, 18, 15, 15, 481, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 18, 15, 15, 481, DateTimeKind.Local).AddTicks(3522), new DateTime(2021, 7, 31, 18, 15, 15, 481, DateTimeKind.Local).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 31, 18, 15, 15, 481, DateTimeKind.Local).AddTicks(3524), new DateTime(2021, 7, 31, 18, 15, 15, 481, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "356d96b5-dfa6-4ed5-a7b3-be95f68541a2", "5c72668c-fac6-45dc-b5c7-9d8aef14a321" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "574359ee-f5dc-488a-a3ae-32fb9bbb7aa6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "356d96b5-dfa6-4ed5-a7b3-be95f68541a2", "5c72668c-fac6-45dc-b5c7-9d8aef14a321" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "356d96b5-dfa6-4ed5-a7b3-be95f68541a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c72668c-fac6-45dc-b5c7-9d8aef14a321");

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
    }
}
