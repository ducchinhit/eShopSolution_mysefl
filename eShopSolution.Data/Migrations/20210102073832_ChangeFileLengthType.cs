using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9a6c9ca3-bf89-4506-9dcd-99970e0019f5");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9e8d9268-f7d5-4d1e-9f23-7f9be494d6a4", "AQAAAAEAACcQAAAAEF+eYLCfOvKDgcyN4irJ/FaN0dJmlvZqwOXe8FD4ZPGu0fRdchGFmGAOPlRi6gJDww==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 1, 2, 14, 38, 31, 655, DateTimeKind.Local).AddTicks(8110));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "52f16ff8-42ef-425b-82fe-c48ac5f934fd");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cae6c2b8-25a1-4e3f-ad67-53df47db52ad", "AQAAAAEAACcQAAAAEIq9Qi/0ZJgQlt9D8MJlw0CQfT8qocOuOXqMI+leIetsR/x2UkGq3d+wIahCja7+eg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 31, 21, 23, 6, 902, DateTimeKind.Local).AddTicks(7705));
        }
    }
}
