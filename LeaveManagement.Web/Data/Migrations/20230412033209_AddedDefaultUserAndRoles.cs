using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUserAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b2528219-1771-48fg-96f3-87281bef9740", "1a5875dd-f07c-4cb9-8472-6d455cb22c63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a2528219-1771-48ef-96f3-87281bda9740", "408aa945-3d84-4421-8342-7269ec64d949" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2528219-1771-48ef-96f3-87281bda9740");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2528219-1771-48ef-96f3-87281bda9740");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2528219-1771-48fg-96f3-87281bef9740");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a5875dd-f07c-4cb9-8472-6d455cb22c63");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9d8c837c-6c34-446f-905c-d34ae1e1e901", "Administrator", "ADMINISTRATOR" },
                    { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "c6faa0f3-8a40-4369-b6a0-9173af46d0cb", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3f4631bd-f907-4409-b416-ba356312e659", 0, "53020678-f42d-460f-a28c-e908782b8593", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEBKDdJuSb8DuBkvnZSdHGbQvtVM+7tJGwaH8J2cQILMwT9Bb6OmaZAxXNUNk2lV0cg==", null, false, "a44300e9-4fd2-4935-a77a-cda9e1870e1f", null, false, "user@localhost.com" },
                    { "408aa945-3d84-4421-8342-7269ec64d949", 0, "b724b67b-4aae-4c01-883d-d1b34c779d52", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAED+8BoH+dSnTZROawTAIxLJ7Al31JuWp+ID4w2TrxRHoTKTWbp4GRJha39W2rosg0g==", null, false, "7ace82ec-81cc-4131-96ae-db87e2cdfb5c", null, false, "admin@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "3f4631bd-f907-4409-b416-ba356312e659" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "408aa945-3d84-4421-8342-7269ec64d949" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "3f4631bd-f907-4409-b416-ba356312e659" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "408aa945-3d84-4421-8342-7269ec64d949" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a2528219-1771-48ef-96f3-87281bda9740", "51180518-e872-4b13-b890-6b3ae1ce378e", "Administrator", "ADMINISTRATOR" },
                    { "b2528219-1771-48fg-96f3-87281bef9740", "7936510d-0763-4f5d-b815-c82e669cb184", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1a5875dd-f07c-4cb9-8472-6d455cb22c63", 0, "fbf2da8d-8edc-4c9c-8f30-950a52493bbe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@test.ca", false, "System", "User", false, null, "ADMIN@TEST.CA", null, "AQAAAAEAACcQAAAAEGvNltE90f8JYEyMXLN2NqWD8x+BxJ6JV1dpCxl0NklqFJUEhCNWjVgus1Hv7NvHqA==", null, false, "312103a5-f032-4e5c-8b73-3bdf3802de34", null, false, null },
                    { "a2528219-1771-48ef-96f3-87281bda9740", 0, "81b7e38e-0c30-43d2-8fc6-64f6c46fe4a1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kaartik.servansingh@gmail.com", false, "System", "User", false, null, "KAARTIK.SERVANSINGH@GMAIL.COM", null, "AQAAAAEAACcQAAAAEOOWskT3cF63IXpKT03xNeftWU7uSATuH/zN79voMo3zyLk2cg46R8/gFrx+BErsJw==", null, false, "3c78e1ae-4c07-4463-9af2-517fe5e796cd", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b2528219-1771-48fg-96f3-87281bef9740", "1a5875dd-f07c-4cb9-8472-6d455cb22c63" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a2528219-1771-48ef-96f3-87281bda9740", "408aa945-3d84-4421-8342-7269ec64d949" });
        }
    }
}
