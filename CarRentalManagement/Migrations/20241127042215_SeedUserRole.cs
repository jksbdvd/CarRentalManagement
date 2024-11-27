using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "3208f1ec-9dae-4f3f-ad7f-2bc4052be468", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGvwafegmvbZfdX3jTtlc4cQABufWivUs6Ctv0lTqFmZRRuzJohivLz74HLx/Jtpfg==", null, false, "3f7ac65e-728a-48c2-82ef-263c694a5c7c", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 22, 13, 553, DateTimeKind.Local).AddTicks(3561), new DateTime(2024, 11, 27, 12, 22, 13, 553, DateTimeKind.Local).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 22, 13, 553, DateTimeKind.Local).AddTicks(3580), new DateTime(2024, 11, 27, 12, 22, 13, 553, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 22, 13, 553, DateTimeKind.Local).AddTicks(3843), new DateTime(2024, 11, 27, 12, 22, 13, 553, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 22, 13, 553, DateTimeKind.Local).AddTicks(3847), new DateTime(2024, 11, 27, 12, 22, 13, 553, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 22, 13, 553, DateTimeKind.Local).AddTicks(3958), new DateTime(2024, 11, 27, 12, 22, 13, 553, DateTimeKind.Local).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 22, 13, 553, DateTimeKind.Local).AddTicks(3962), new DateTime(2024, 11, 27, 12, 22, 13, 553, DateTimeKind.Local).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 22, 13, 553, DateTimeKind.Local).AddTicks(3965), new DateTime(2024, 11, 27, 12, 22, 13, 553, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 22, 13, 553, DateTimeKind.Local).AddTicks(3968), new DateTime(2024, 11, 27, 12, 22, 13, 553, DateTimeKind.Local).AddTicks(3969) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 14, 31, 516, DateTimeKind.Local).AddTicks(4934), new DateTime(2024, 11, 27, 12, 14, 31, 516, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 14, 31, 516, DateTimeKind.Local).AddTicks(4950), new DateTime(2024, 11, 27, 12, 14, 31, 516, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 14, 31, 516, DateTimeKind.Local).AddTicks(5165), new DateTime(2024, 11, 27, 12, 14, 31, 516, DateTimeKind.Local).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 14, 31, 516, DateTimeKind.Local).AddTicks(5168), new DateTime(2024, 11, 27, 12, 14, 31, 516, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 14, 31, 516, DateTimeKind.Local).AddTicks(5261), new DateTime(2024, 11, 27, 12, 14, 31, 516, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 14, 31, 516, DateTimeKind.Local).AddTicks(5264), new DateTime(2024, 11, 27, 12, 14, 31, 516, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 14, 31, 516, DateTimeKind.Local).AddTicks(5266), new DateTime(2024, 11, 27, 12, 14, 31, 516, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 14, 31, 516, DateTimeKind.Local).AddTicks(5269), new DateTime(2024, 11, 27, 12, 14, 31, 516, DateTimeKind.Local).AddTicks(5269) });
        }
    }
}
