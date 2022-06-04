using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocTruyen.DataAccess.Migrations
{
    public partial class EditFieldContentPath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "69961b11-5bad-43f3-8a4c-d489a831b874");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c93d1a14-6bb8-4583-93ba-755f57807579");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "532b5f2f-4d3f-4009-a6ec-5c23202d3e84", "AQAAAAEAACcQAAAAEMCGJ95gvRThsp0hPQZYbY4VUDJLxCpdiPef04nB3gQuunbyUjoCUVXvQtjT0b5uww==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b579f32-4191-4734-a427-a6de81ccab57", "AQAAAAEAACcQAAAAEM7dpTrFdv8Y16ILgT+ZojSsqTOXzn7mxbWQHYVMWXel4uS7jniJJEJFdr/o9kGCfA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a06886ac-5da5-419e-997f-a8b9aca14213", "AQAAAAEAACcQAAAAEAmSPk7udPYK49UnbH16+6Ub58+3ltT9R98w2lBLAoODb7A5H79PFpMzZ01BJla+vw==" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 20, 23, 9, 282, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 20, 23, 9, 282, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 20, 23, 9, 282, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 20, 23, 9, 282, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 20, 23, 9, 282, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 20, 23, 9, 282, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 20, 23, 9, 282, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 20, 23, 9, 282, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 20, 23, 9, 282, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 20, 23, 9, 282, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Novels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 20, 23, 9, 282, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Novels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 4, 20, 23, 9, 282, DateTimeKind.Local).AddTicks(7357));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
