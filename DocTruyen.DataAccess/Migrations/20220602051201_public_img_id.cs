using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocTruyen.DataAccess.Migrations
{
    public partial class public_img_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PublicImgId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "6d6ac84e-f8d6-41f1-8c7f-7b048613e5e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "94e06366-73f6-4b82-bfe0-161ebbd0b711");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2361cfeb-585e-4785-a8b0-f05f3faaf379", "AQAAAAEAACcQAAAAED19RXuaSgRK0pTUNFQEwudXqLUQuclLH5mPujpjzc3KmsRxg6sfxjKfZykSv/dC1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aba7ffb0-dcdb-4b87-ae4d-93faf2f5e524", "AQAAAAEAACcQAAAAEN6t+UpjBjmCugcR8MKiIiNpff9Kbhtmn8RolnQLdkPqw/6mcSdiHTuRPNj5fQEUVg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "43d9d9e1-48aa-47e9-ab27-5d4b8476a50f", "AQAAAAEAACcQAAAAEOPpTAUlGNpgKgLNfaW4tZKERSHjeimw8dTI8TFGc6aaVO9nc7n3cQVu+vYC+IAEcw==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 2, 12, 12, 0, 433, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 2, 12, 12, 0, 433, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 2, 12, 12, 0, 433, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 2, 12, 12, 0, 433, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 2, 12, 12, 0, 433, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 2, 12, 12, 0, 433, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 2, 12, 12, 0, 433, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 2, 12, 12, 0, 433, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 2, 12, 12, 0, 433, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 2, 12, 12, 0, 433, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Novels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 2, 12, 12, 0, 433, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "Novels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 2, 12, 12, 0, 433, DateTimeKind.Local).AddTicks(382));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicImgId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "bd80f978-5fae-432e-b41d-ce521d9a4ae9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2a6d6213-bdf7-480c-816d-f6036d3517e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a7377cc-3cb8-4479-93ac-0d32bb311518", "AQAAAAEAACcQAAAAEFUTQTgtTNRVl+9oimxm2gFmIdedyTYkgIU4+QHh0pRvJuV0jhgQde4M+7pPH18A5A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9ca5542-9421-471a-9e3e-42da072bdbb4", "AQAAAAEAACcQAAAAEIOGwq37uIeKA1CW6ROOTBa1H2/j2TjpVPI0DbWL4rFfukRRZoE8Z6M7WqwLp7Ubpw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "832263a7-649c-43ce-b15e-0cda62727817", "AQAAAAEAACcQAAAAEP3V6oZtFsas7qzfsTRiXbRr7p7eoo5592VqWcb8u7O5P7ckBC6jRYApc8DETb5v1w==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 22, 39, 27, 211, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 22, 39, 27, 211, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 22, 39, 27, 211, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 22, 39, 27, 211, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 22, 39, 27, 211, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 22, 39, 27, 211, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 22, 39, 27, 211, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 22, 39, 27, 211, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 22, 39, 27, 211, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 22, 39, 27, 211, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "Novels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 22, 39, 27, 211, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Novels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 1, 22, 39, 27, 211, DateTimeKind.Local).AddTicks(5191));
        }
    }
}
