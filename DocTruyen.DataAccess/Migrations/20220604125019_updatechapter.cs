using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocTruyen.DataAccess.Migrations
{
    public partial class updatechapter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1e4b83f4-5e17-462d-99d0-0dce3e022091");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d23cddbd-da8e-489f-915b-9020ea8b54d4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b170015-3642-4a4f-a93c-5d999f1e9033", "AQAAAAEAACcQAAAAEH0fPVXYLDu7Q8ge/tF/xqB7XLv4iUH0eS74jLVcIQVIAB1Gr5fvJt3nhQGlp/xivQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4351e59e-712c-4798-afce-c11f4cd9d783", "AQAAAAEAACcQAAAAEPqgGor1DtuPT/L22Cgdww2BmInwCU1VLDb1Tk3vgd5HjukZPaju+xBElGq+aGoc/Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d142382-f396-43f3-a81d-3743f61ba9e8", "AQAAAAEAACcQAAAAEAK+1zi9JcXgGs4yxUnK40h482h8+bBzqjM0irrZTF53upyLZRKdOdEZznOz0A+JVA==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 19, 50, 18, 672, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 19, 50, 18, 672, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 19, 50, 18, 672, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 19, 50, 18, 672, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 19, 50, 18, 672, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 19, 50, 18, 672, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 19, 50, 18, 672, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 19, 50, 18, 672, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 19, 50, 18, 672, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 19, 50, 18, 672, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Novels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 19, 50, 18, 672, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Novels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 19, 50, 18, 672, DateTimeKind.Local).AddTicks(4810));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
