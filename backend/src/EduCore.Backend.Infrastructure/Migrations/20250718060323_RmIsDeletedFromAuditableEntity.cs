using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduCore.BackEnd.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RmIsDeletedFromAuditableEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "user",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "review",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "payment",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "user",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "enrollment",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "course",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "review",
                table: "Comments");

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 636, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 636, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 636, DateTimeKind.Utc).AddTicks(6265));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 636, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 636, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 636, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 636, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 636, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 636, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 636, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(726));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(750));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(752));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(772));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(779));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(782));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(791));

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(9104));

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(9111));

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(9123));

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(9125));

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(9127));

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 638, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Instructors",
                keyColumn: "UserProfileId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 641, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Instructors",
                keyColumn: "UserProfileId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 641, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Instructors",
                keyColumn: "UserProfileId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 641, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Instructors",
                keyColumn: "UserProfileId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 641, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 648, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 648, DateTimeKind.Utc).AddTicks(548));

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 648, DateTimeKind.Utc).AddTicks(552));

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 648, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 649, DateTimeKind.Utc).AddTicks(3743));

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 649, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 649, DateTimeKind.Utc).AddTicks(3752));

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 649, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Reviews",
                keyColumn: "EnrollmentId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 643, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Reviews",
                keyColumn: "EnrollmentId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 643, DateTimeKind.Utc).AddTicks(7737));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Reviews",
                keyColumn: "EnrollmentId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 643, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Reviews",
                keyColumn: "EnrollmentId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 643, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Reviews",
                keyColumn: "EnrollmentId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 643, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Students",
                keyColumn: "UserProfileId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 646, DateTimeKind.Utc).AddTicks(8254));

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Students",
                keyColumn: "UserProfileId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 646, DateTimeKind.Utc).AddTicks(8258));

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Students",
                keyColumn: "UserProfileId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 646, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Students",
                keyColumn: "UserProfileId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 646, DateTimeKind.Utc).AddTicks(8261));

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Students",
                keyColumn: "UserProfileId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 6, 3, 22, 646, DateTimeKind.Utc).AddTicks(8262));

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7f8a938f-127a-4a5a-8825-95bde9007552");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "bf322575-8525-4358-8074-5ca81994b3c6");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "b23c27b2-77f9-4f29-9648-86682952e762");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "bbda844c-07d3-47cc-9354-fe525143a3f4");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "e2d609a4-b3ea-4419-893f-d22c8260140e");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "61869790-3384-430a-af7b-6b791b7730f7");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "971dd570-c8d8-4101-a7ec-2a4b0553e88a");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "51b4d73d-be7f-4dcf-9f13-70d309dd637d");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "1080859b-0d61-49e6-9dfb-32d741050152");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "ff4ea24e-ea52-4f0c-af3e-3e54329ab2ea");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "user",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "review",
                table: "Reviews",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "payment",
                table: "Payments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "user",
                table: "Instructors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "enrollment",
                table: "Enrollments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "course",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "review",
                table: "Comments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7629), false });

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7633), false });

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7635), false });

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7637), false });

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7641), false });

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7643), false });

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7638), false });

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7639), false });

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7644), false });

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7646), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3300), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3312), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3315), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3361), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3363), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3367), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3370), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3374), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3376), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3379), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3381), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3384), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3387), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3389), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3392), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3397), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3400), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3402), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3405), false });

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3408), false });

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 80, DateTimeKind.Utc).AddTicks(1913), false });

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 80, DateTimeKind.Utc).AddTicks(1924), false });

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 80, DateTimeKind.Utc).AddTicks(1950), false });

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 80, DateTimeKind.Utc).AddTicks(1951), false });

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 80, DateTimeKind.Utc).AddTicks(1952), false });

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 80, DateTimeKind.Utc).AddTicks(1956), false });

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 80, DateTimeKind.Utc).AddTicks(1958), false });

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 80, DateTimeKind.Utc).AddTicks(1960), false });

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 80, DateTimeKind.Utc).AddTicks(1961), false });

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Instructors",
                keyColumn: "UserProfileId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 82, DateTimeKind.Utc).AddTicks(7561), false });

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Instructors",
                keyColumn: "UserProfileId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 82, DateTimeKind.Utc).AddTicks(7566), false });

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Instructors",
                keyColumn: "UserProfileId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 82, DateTimeKind.Utc).AddTicks(7568), false });

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Instructors",
                keyColumn: "UserProfileId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 82, DateTimeKind.Utc).AddTicks(7570), false });

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 91, DateTimeKind.Utc).AddTicks(6431), false });

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 91, DateTimeKind.Utc).AddTicks(6445), false });

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 91, DateTimeKind.Utc).AddTicks(6449), false });

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 91, DateTimeKind.Utc).AddTicks(6451), false });

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 94, DateTimeKind.Utc).AddTicks(8910), false });

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 94, DateTimeKind.Utc).AddTicks(8920), false });

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 94, DateTimeKind.Utc).AddTicks(8923), false });

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 94, DateTimeKind.Utc).AddTicks(8926), false });

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Reviews",
                keyColumn: "EnrollmentId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 85, DateTimeKind.Utc).AddTicks(2940), false });

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Reviews",
                keyColumn: "EnrollmentId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 85, DateTimeKind.Utc).AddTicks(2946), false });

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Reviews",
                keyColumn: "EnrollmentId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 85, DateTimeKind.Utc).AddTicks(2948), false });

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Reviews",
                keyColumn: "EnrollmentId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 85, DateTimeKind.Utc).AddTicks(2949), false });

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Reviews",
                keyColumn: "EnrollmentId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 85, DateTimeKind.Utc).AddTicks(2950), false });

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Students",
                keyColumn: "UserProfileId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 89, DateTimeKind.Utc).AddTicks(812), false });

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Students",
                keyColumn: "UserProfileId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 89, DateTimeKind.Utc).AddTicks(815), false });

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Students",
                keyColumn: "UserProfileId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 89, DateTimeKind.Utc).AddTicks(816), false });

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Students",
                keyColumn: "UserProfileId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 89, DateTimeKind.Utc).AddTicks(817), false });

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Students",
                keyColumn: "UserProfileId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IsDeleted" },
                values: new object[] { new DateTime(2025, 7, 18, 4, 26, 39, 89, DateTimeKind.Utc).AddTicks(819), false });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ce57a99c-7e20-4c7c-9a1e-329ccb7c814a");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "0ff61962-2b0f-4dc3-9421-60f9735c78ce");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a3cafbc4-2404-46e9-ac60-483456f76d42");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "06d87006-7882-483e-b426-43e5646d8505");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "e9c7d78f-d234-4373-88ec-891550d7a543");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "3a5bee4e-ea5e-4cf9-9c17-2dea66756a12");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "66c69d5a-9ac5-4363-8d10-7570a32e76b0");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "7d68c499-acc0-4703-a004-a71e0d12d13a");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "19f02f90-a8d5-4af7-a42c-5b976c30b09a");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "62d6b3f5-4e0b-4a8a-9cda-a80a5e7bed36");
        }
    }
}
