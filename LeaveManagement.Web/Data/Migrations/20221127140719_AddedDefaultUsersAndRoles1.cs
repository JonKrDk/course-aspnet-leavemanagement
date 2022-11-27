using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d40a123d-ca01-4491-a093-c9ddd483595A",
                column: "ConcurrencyStamp",
                value: "a25c0753-8a5e-45fd-a162-72943431b014");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d40a123d-ca01-4491-a093-c9ddd483595B",
                column: "ConcurrencyStamp",
                value: "594c9fa0-1a50-4136-9810-6c9c8f8f9b91");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d40a123d-ca01-4491-a093-c9ddd4835959",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "63c5627a-2bab-4775-8c18-dd1ff99cb664", true, "JON@JONKR.DK", "AQAAAAEAACcQAAAAEOD7Lg7c0tph1cTFpeEDmmxCuquPiG3br66z5Iv5P44E7CmLjiwz/dWuwzgDJ2fr+g==", "504b34e7-197a-4bb0-a233-244078f66248", "jon@jonkr.dk" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d40a123d-ca01-4491-a093-c9ddd483595C",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "710d92f2-60a5-445e-acd1-e1c0f97b47e2", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEOKPKRZuxt6rcCeCClMXoaAktXROm/++st8IMKw8G/pvY71S6u3CjodFb1N104UPNg==", "f1d1e0dc-e7c1-43a4-bf18-f2eddb96a15c", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d40a123d-ca01-4491-a093-c9ddd483595A",
                column: "ConcurrencyStamp",
                value: "0bc758de-15fa-4980-b0bb-596719f5007b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d40a123d-ca01-4491-a093-c9ddd483595B",
                column: "ConcurrencyStamp",
                value: "e712f997-b02e-4c9e-9e1b-cc5a12ead96a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d40a123d-ca01-4491-a093-c9ddd4835959",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "76494111-55c0-48ea-83d7-9356c06cd616", false, null, "AQAAAAEAACcQAAAAEG+g1DTUp3zAONxkWlNs/PWQ0EqCIX80EECreG4jgbYZiMTjGqpnV24gLW9UDYcmiw==", "9cffc30e-83df-41d3-adb3-e2dfb46c02ae", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d40a123d-ca01-4491-a093-c9ddd483595C",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ac3e9a42-df00-4375-952b-5ef8f0ad9530", false, null, "AQAAAAEAACcQAAAAEJZ6nq+2YDru6Jb1Mewzxz29W8Cec0vmmfgrSsIi1FOUfNONQQ1dV+n0CQaSnI43Jw==", "588a609d-55c1-49fe-a04a-f50310d28d87", null });
        }
    }
}
