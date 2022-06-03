using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocTruyen.DataAccess.Migrations
{
    public partial class addUserPublicImgId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "bc00f3d4-740d-48be-bc83-8c0e1d93d7fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d90daee0-4361-4919-8da0-c0d4ae1f6d8f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b31f972b-9f81-4212-a903-0dfc5b6f5875", "AQAAAAEAACcQAAAAEIDXZO5ooipDUUm7PUg/vsKygBT607TGuU0K7yE03P82DLH4yTsPvPrA5DjsFwhSxQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dfed52be-2411-4218-88c7-2b84135c19d0", "AQAAAAEAACcQAAAAEOTvbnD7uzyzvyDkHbxOXJHe3lDKdLSWCm3tIaXA1anjpcgT87b1nBattUHHRHViOQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5869745f-ea38-4909-8286-686e7f04bc1d", "AQAAAAEAACcQAAAAEMwio2hQOrXh6S5V+OR9hKMdYjz6MO12G/Xgt33wdwE4T/W0c3grzFiCtl7UiM4VGw==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 31, 13, 4, 21, 308, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 31, 13, 4, 21, 308, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 31, 13, 4, 21, 308, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 31, 13, 4, 21, 308, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 31, 13, 4, 21, 308, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 31, 13, 4, 21, 308, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 31, 13, 4, 21, 308, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 31, 13, 4, 21, 308, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 31, 13, 4, 21, 308, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 31, 13, 4, 21, 308, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Novels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 31, 13, 4, 21, 308, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Novels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 31, 13, 4, 21, 308, DateTimeKind.Local).AddTicks(5023));
        }
    }
}
