using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocTruyen.DataAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Novels_Categories_CategoryId",
                table: "Novels");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Novels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Dob",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "864a0858-9a21-4053-8ba5-d08c3209e1a1", "Administrator role", "admin", "admin" },
                    { 2, "8da955f5-252a-4f6d-a681-ebcca8ef8f57", "user role", "user", "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImgURL", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "cfcdc763-fb2d-4c1c-b24e-007636ac5936", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "masterchienboy@gmail.com", true, "Chien", "Hoang Van", false, null, "masterchienboy@gmail.com", "admin", "AQAAAAEAACcQAAAAEGZj2iXkOd/ntRoZAxstpyly6tfmPAGouGY+h0pV50q0VSWtkpp7iEGhzx7QoEdJ+Q==", null, false, null, "", false, "admin" },
                    { 2, 0, "cf456a2b-40db-43a0-9817-e257cb05d771", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@gmail.com", true, "Chien", "Hoang Van", false, null, "user1@gmail.com", "user1", "AQAAAAEAACcQAAAAEHVHr6VsSI6khpNl4IjBVip2BIEdFAzYZhEbvzKoGj2B2VvHVArTmMJc1M5mbujkEg==", null, false, null, "", false, "user1" },
                    { 3, 0, "6e17d472-8f8e-4541-8dc0-2f2bd456a648", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@gmail.com", true, "Chien", "Hoang Van", false, null, "user2@gmail.com", "user2", "AQAAAAEAACcQAAAAENLv3FiI+CcSqf39lqMgczK4DwU+fmoNONMENjRpH2inntRlG/ndlSz+K5TdFdTDOA==", null, false, null, "", false, "user2" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Description", "Name", "ProfileImgUrl" },
                values: new object[,]
                {
                    { 1, "Đây là tác giả cấp Đại thần", "Ta la Lão Ngũ", "https://nae.vn/ttv/ttv/public/images_user/10a1c6c931075aba32b7d7bfc986288037785186fce122f2c18a26a9d1c10ff6.jpg" },
                    { 2, "Đây là tác giả cấp Đại thần", "Thần Đông", "https://nae.vn/ttv/ttv/public/images_user/10a1c6c931075aba32b7d7bfc986288037785186fce122f2c18a26a9d1c10ff6.jpg" },
                    { 3, "Đây là tác giả cấp Đại thần", "Ngã Cật Tây Hồng Thị", "https://nae.vn/ttv/ttv/public/images_user/10a1c6c931075aba32b7d7bfc986288037785186fce122f2c18a26a9d1c10ff6.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "thể loại có bối cảnh tại đô thị hiện đại", "Đô thị" },
                    { 2, "Thể loại tu tiên", "Tiên hiệp" }
                });

            migrationBuilder.InsertData(
                table: "Novels",
                columns: new[] { "Id", "AuthorId", "CategoryId", "CreatedDate", "Description", "Name", "PublisherId", "Rating", "Status", "TotalChapter" },
                values: new object[] { 1, 1, 1, new DateTime(2022, 5, 22, 12, 12, 43, 825, DateTimeKind.Local).AddTicks(2379), "- Từ Địa Cầu xuyên việt tới Dị giới đã thấy nhiều, nhưng Diệp Mặc của chúng ta lại từ Dị giới xuyên tới Địa Cầu.Điều này còn chưa phải là buồn bực nhất, để cho Diệp Mặc phát điên chính là cậu nhỏ của hắn bị liệt.", "Thiếu gia bị bỏ rơi", 2, 4.5, 1, 0 });

            migrationBuilder.InsertData(
                table: "Novels",
                columns: new[] { "Id", "AuthorId", "CategoryId", "CreatedDate", "Description", "Name", "PublisherId", "Rating", "Status", "TotalChapter" },
                values: new object[] { 2, 2, 2, new DateTime(2022, 5, 22, 12, 12, 43, 825, DateTimeKind.Local).AddTicks(2394), "Trong vũ trụ bao la, một mảnh tinh hệ sinh diệt, cũng bất quá là sát na pha tạp lưu quang.Ngắm nhìn bầu trời, luôn có loại thương cảm kết cục đã nhất định,trăm ngàn năm sau ngươi ta ở đâu ? Gia quốc, ánh lửa văn minh,Địa Cầu, đều chẳng qua là trong thâm không một hạt bụi.", "Già Thiên", 3, 4.5, 2, 0 });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "ContentPath", "CreatedDate", "Index", "NovelId", "PublisherId", "Title" },
                values: new object[,]
                {
                    { 1, "Đây là nội dung chương 1", new DateTime(2022, 5, 22, 12, 12, 43, 825, DateTimeKind.Local).AddTicks(2426), 1, 1, 2, "Mở đầu" },
                    { 2, "Đây là nội dung chương 2", new DateTime(2022, 5, 22, 12, 12, 43, 825, DateTimeKind.Local).AddTicks(2429), 2, 1, 2, "Bắt đầu mới" },
                    { 3, "Đây là nội dung chương 3", new DateTime(2022, 5, 22, 12, 12, 43, 825, DateTimeKind.Local).AddTicks(2430), 3, 1, 2, "Tu luyện" },
                    { 4, "Đây là nội dung chương 1 truyện Già Thiên", new DateTime(2022, 5, 22, 12, 12, 43, 825, DateTimeKind.Local).AddTicks(2432), 1, 2, 3, "Mở đầu" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedDate", "NovelId", "Text", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 22, 12, 12, 43, 825, DateTimeKind.Local).AddTicks(2454), 1, "Truyện rất hay", 2 },
                    { 2, new DateTime(2022, 5, 22, 12, 12, 43, 825, DateTimeKind.Local).AddTicks(2456), 1, "Truyện rất hay", 3 },
                    { 3, new DateTime(2022, 5, 22, 12, 12, 43, 825, DateTimeKind.Local).AddTicks(2458), 2, "Truyện như lone", 3 }
                });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "Id", "CommentId", "CreatedDate", "Text", "UserId" },
                values: new object[] { 1, 1, new DateTime(2022, 5, 22, 12, 12, 43, 825, DateTimeKind.Local).AddTicks(2485), "Đồng quan điểm", 3 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "Id", "CommentId", "CreatedDate", "Text", "UserId" },
                values: new object[] { 2, 1, new DateTime(2022, 5, 22, 12, 12, 43, 825, DateTimeKind.Local).AddTicks(2487), "Bạc quan điểm", 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "Id", "CommentId", "CreatedDate", "Text", "UserId" },
                values: new object[] { 3, 3, new DateTime(2022, 5, 22, 12, 12, 43, 825, DateTimeKind.Local).AddTicks(2488), "Truyện như lone", 3 });

            migrationBuilder.AddForeignKey(
                name: "FK_Novels_Categories_CategoryId",
                table: "Novels",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Novels_Categories_CategoryId",
                table: "Novels");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Novels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Novels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Dob",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Novels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Novels_Categories_CategoryId",
                table: "Novels",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
