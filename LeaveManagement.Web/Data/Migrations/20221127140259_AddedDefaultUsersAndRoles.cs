using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LeaveTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d40a123d-ca01-4491-a093-c9ddd483595A", "0bc758de-15fa-4980-b0bb-596719f5007b", "Administrator", "ADMINISTRATOR" },
                    { "d40a123d-ca01-4491-a093-c9ddd483595B", "e712f997-b02e-4c9e-9e1b-cc5a12ead96a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d40a123d-ca01-4491-a093-c9ddd4835959", 0, "76494111-55c0-48ea-83d7-9356c06cd616", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jon@jonkr.dk", false, "Jon", "Kristensen", false, null, "JON@JONKR.DK", null, "AQAAAAEAACcQAAAAEG+g1DTUp3zAONxkWlNs/PWQ0EqCIX80EECreG4jgbYZiMTjGqpnV24gLW9UDYcmiw==", null, false, "9cffc30e-83df-41d3-adb3-e2dfb46c02ae", null, false, null },
                    { "d40a123d-ca01-4491-a093-c9ddd483595C", 0, "ac3e9a42-df00-4375-952b-5ef8f0ad9530", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEJZ6nq+2YDru6Jb1Mewzxz29W8Cec0vmmfgrSsIi1FOUfNONQQ1dV+n0CQaSnI43Jw==", null, false, "588a609d-55c1-49fe-a04a-f50310d28d87", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d40a123d-ca01-4491-a093-c9ddd483595A", "d40a123d-ca01-4491-a093-c9ddd4835959" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d40a123d-ca01-4491-a093-c9ddd483595B", "d40a123d-ca01-4491-a093-c9ddd483595C" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d40a123d-ca01-4491-a093-c9ddd483595A", "d40a123d-ca01-4491-a093-c9ddd4835959" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d40a123d-ca01-4491-a093-c9ddd483595B", "d40a123d-ca01-4491-a093-c9ddd483595C" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d40a123d-ca01-4491-a093-c9ddd483595A");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d40a123d-ca01-4491-a093-c9ddd483595B");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d40a123d-ca01-4491-a093-c9ddd4835959");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d40a123d-ca01-4491-a093-c9ddd483595C");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LeaveTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
