using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocTruyen.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfileImgURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Novels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    TotalChapter = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: true),
                    PublisherId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Novels_AspNetUsers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Novels_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Novels_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Index = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublisherId = table.Column<int>(type: "int", nullable: false),
                    NovelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chapters_AspNetUsers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chapters_Novels_NovelId",
                        column: x => x.NovelId,
                        principalTable: "Novels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    NovelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Novels_NovelId",
                        column: x => x.NovelId,
                        principalTable: "Novels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileSize = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NovelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Novels_NovelId",
                        column: x => x.NovelId,
                        principalTable: "Novels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserReadingLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChapterIndex = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    NovelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReadingLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserReadingLogs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserReadingLogs_Novels_NovelId",
                        column: x => x.NovelId,
                        principalTable: "Novels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ViewCounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayCount = table.Column<int>(type: "int", nullable: false),
                    WeekCount = table.Column<int>(type: "int", nullable: false),
                    MonthCount = table.Column<int>(type: "int", nullable: false),
                    YearCount = table.Column<int>(type: "int", nullable: false),
                    OverallCount = table.Column<int>(type: "int", nullable: false),
                    NovelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewCounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ViewCounts_Novels_NovelId",
                        column: x => x.NovelId,
                        principalTable: "Novels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Replies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Replies_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Replies_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "ffb53ccc-9787-40a8-a066-e9964294cc30", "Administrator role", "admin", "admin" },
                    { 2, "d19fedc1-c0e6-4ebb-b9d5-3419ba016671", "user role", "user", "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImgURL", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "5d328840-8947-4401-b57d-43e64afa0194", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "masterchienboy@gmail.com", true, "Chien", "Hoang Van", false, null, "masterchienboy@gmail.com", "admin", "AQAAAAEAACcQAAAAEHzkqevVUdNGmjwc3mGobvDj8lQTNXWY/QB/RamglVH7yY8SvYWLE/Yt2t2giFwoNA==", null, false, null, "", false, "admin" },
                    { 2, 0, "cee6a158-92a0-4210-afcb-9e678e61203e", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@gmail.com", true, "Chien", "Hoang Van", false, null, "user1@gmail.com", "user1", "AQAAAAEAACcQAAAAECoNLzOZmNS7GEvbZwXNxwXlAJdWtB2V2V5hZ7yCOtWXFhHlUs/Xr7zasF4CsyyFPQ==", null, false, null, "", false, "user1" },
                    { 3, 0, "83879450-53c6-49d3-8417-a75223543611", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@gmail.com", true, "Chien", "Hoang Van", false, null, "user2@gmail.com", "user2", "AQAAAAEAACcQAAAAECM/8NyhrTaJdEcfCI7h997sQedhVLDPgC4rOAdy84TUCaLNjZN/GXi23sJVR/sy+Q==", null, false, null, "", false, "user2" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Description", "Name", "ProfileImgUrl", "PublicId" },
                values: new object[,]
                {
                    { 1, "Đây là tác giả cấp Đại thần", "Ta la Lão Ngũ", "https://nae.vn/ttv/ttv/public/images_user/10a1c6c931075aba32b7d7bfc986288037785186fce122f2c18a26a9d1c10ff6.jpg", null },
                    { 2, "Đây là tác giả cấp Đại thần", "Thần Đông", "https://nae.vn/ttv/ttv/public/images_user/10a1c6c931075aba32b7d7bfc986288037785186fce122f2c18a26a9d1c10ff6.jpg", null },
                    { 3, "Đây là tác giả cấp Đại thần", "Ngã Cật Tây Hồng Thị", "https://nae.vn/ttv/ttv/public/images_user/10a1c6c931075aba32b7d7bfc986288037785186fce122f2c18a26a9d1c10ff6.jpg", null }
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
                values: new object[] { 1, 1, 1, new DateTime(2022, 5, 27, 14, 55, 3, 11, DateTimeKind.Local).AddTicks(5760), "- Từ Địa Cầu xuyên việt tới Dị giới đã thấy nhiều, nhưng Diệp Mặc của chúng ta lại từ Dị giới xuyên tới Địa Cầu.Điều này còn chưa phải là buồn bực nhất, để cho Diệp Mặc phát điên chính là cậu nhỏ của hắn bị liệt.", "Thiếu gia bị bỏ rơi", 2, 4.5, 1, 0 });

            migrationBuilder.InsertData(
                table: "Novels",
                columns: new[] { "Id", "AuthorId", "CategoryId", "CreatedDate", "Description", "Name", "PublisherId", "Rating", "Status", "TotalChapter" },
                values: new object[] { 2, 2, 2, new DateTime(2022, 5, 27, 14, 55, 3, 11, DateTimeKind.Local).AddTicks(5771), "Trong vũ trụ bao la, một mảnh tinh hệ sinh diệt, cũng bất quá là sát na pha tạp lưu quang.Ngắm nhìn bầu trời, luôn có loại thương cảm kết cục đã nhất định,trăm ngàn năm sau ngươi ta ở đâu ? Gia quốc, ánh lửa văn minh,Địa Cầu, đều chẳng qua là trong thâm không một hạt bụi.", "Già Thiên", 3, 4.5, 2, 0 });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "ContentPath", "CreatedDate", "Index", "NovelId", "PublisherId", "Title" },
                values: new object[,]
                {
                    { 1, "Đây là nội dung chương 1", new DateTime(2022, 5, 27, 14, 55, 3, 11, DateTimeKind.Local).AddTicks(5802), 1, 1, 2, "Mở đầu" },
                    { 2, "Đây là nội dung chương 2", new DateTime(2022, 5, 27, 14, 55, 3, 11, DateTimeKind.Local).AddTicks(5805), 2, 1, 2, "Bắt đầu mới" },
                    { 3, "Đây là nội dung chương 3", new DateTime(2022, 5, 27, 14, 55, 3, 11, DateTimeKind.Local).AddTicks(5806), 3, 1, 2, "Tu luyện" },
                    { 4, "Đây là nội dung chương 1 truyện Già Thiên", new DateTime(2022, 5, 27, 14, 55, 3, 11, DateTimeKind.Local).AddTicks(5808), 1, 2, 3, "Mở đầu" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedDate", "NovelId", "Text", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 27, 14, 55, 3, 11, DateTimeKind.Local).AddTicks(5830), 1, "Truyện rất hay", 2 },
                    { 2, new DateTime(2022, 5, 27, 14, 55, 3, 11, DateTimeKind.Local).AddTicks(5834), 1, "Truyện rất hay", 3 },
                    { 3, new DateTime(2022, 5, 27, 14, 55, 3, 11, DateTimeKind.Local).AddTicks(5835), 2, "Truyện như lone", 3 }
                });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "Id", "CommentId", "CreatedDate", "Text", "UserId" },
                values: new object[] { 1, 1, new DateTime(2022, 5, 27, 14, 55, 3, 11, DateTimeKind.Local).AddTicks(5870), "Đồng quan điểm", 3 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "Id", "CommentId", "CreatedDate", "Text", "UserId" },
                values: new object[] { 2, 1, new DateTime(2022, 5, 27, 14, 55, 3, 11, DateTimeKind.Local).AddTicks(5872), "Bạc quan điểm", 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "Id", "CommentId", "CreatedDate", "Text", "UserId" },
                values: new object[] { 3, 3, new DateTime(2022, 5, 27, 14, 55, 3, 11, DateTimeKind.Local).AddTicks(5874), "Truyện như lone", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_NovelId",
                table: "Chapters",
                column: "NovelId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_PublisherId",
                table: "Chapters",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_NovelId",
                table: "Comments",
                column: "NovelId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_NovelId",
                table: "Images",
                column: "NovelId");

            migrationBuilder.CreateIndex(
                name: "IX_Novels_AuthorId",
                table: "Novels",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Novels_CategoryId",
                table: "Novels",
                column: "CategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Novels_PublisherId",
                table: "Novels",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Replies_CommentId",
                table: "Replies",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Replies_UserId",
                table: "Replies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReadingLogs_NovelId",
                table: "UserReadingLogs",
                column: "NovelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReadingLogs_UserId",
                table: "UserReadingLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ViewCounts_NovelId",
                table: "ViewCounts",
                column: "NovelId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Chapters");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Replies");

            migrationBuilder.DropTable(
                name: "UserReadingLogs");

            migrationBuilder.DropTable(
                name: "ViewCounts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Novels");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
