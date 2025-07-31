using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduCore.BackEnd.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RmDescriptionFromInstructor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "user",
                table: "Instructors");

            migrationBuilder.RenameColumn(
                name: "UrlImage",
                schema: "user",
                table: "UserProfiles",
                newName: "ImageUrl");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                schema: "user",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                schema: "user",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 141, DateTimeKind.Utc).AddTicks(1932));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 141, DateTimeKind.Utc).AddTicks(1936));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 141, DateTimeKind.Utc).AddTicks(1937));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 141, DateTimeKind.Utc).AddTicks(1938));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 141, DateTimeKind.Utc).AddTicks(1942));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 141, DateTimeKind.Utc).AddTicks(1943));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 141, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 141, DateTimeKind.Utc).AddTicks(1940));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 141, DateTimeKind.Utc).AddTicks(1944));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 141, DateTimeKind.Utc).AddTicks(1946));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5065));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5073));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5076));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5079));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5081));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5083));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5091));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5093));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5096));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5098));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5161));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5165));

            migrationBuilder.UpdateData(
                schema: "course",
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 142, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 143, DateTimeKind.Utc).AddTicks(1988));

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 143, DateTimeKind.Utc).AddTicks(1995));

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 143, DateTimeKind.Utc).AddTicks(2001));

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 143, DateTimeKind.Utc).AddTicks(2004));

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 143, DateTimeKind.Utc).AddTicks(2005));

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 143, DateTimeKind.Utc).AddTicks(2007));

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 143, DateTimeKind.Utc).AddTicks(2008));

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 143, DateTimeKind.Utc).AddTicks(2010));

            migrationBuilder.UpdateData(
                schema: "enrollment",
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 143, DateTimeKind.Utc).AddTicks(2011));

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Instructors",
                keyColumn: "UserProfileId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 145, DateTimeKind.Utc).AddTicks(4494));

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Instructors",
                keyColumn: "UserProfileId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 145, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Instructors",
                keyColumn: "UserProfileId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 145, DateTimeKind.Utc).AddTicks(4500));

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Instructors",
                keyColumn: "UserProfileId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 145, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 151, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 151, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 151, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 151, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 152, DateTimeKind.Utc).AddTicks(9394));

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 152, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 152, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                schema: "payment",
                table: "Payments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 152, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Reviews",
                keyColumn: "EnrollmentId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 147, DateTimeKind.Utc).AddTicks(2099));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Reviews",
                keyColumn: "EnrollmentId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 147, DateTimeKind.Utc).AddTicks(2105));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Reviews",
                keyColumn: "EnrollmentId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 147, DateTimeKind.Utc).AddTicks(2166));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Reviews",
                keyColumn: "EnrollmentId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 147, DateTimeKind.Utc).AddTicks(2168));

            migrationBuilder.UpdateData(
                schema: "review",
                table: "Reviews",
                keyColumn: "EnrollmentId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 147, DateTimeKind.Utc).AddTicks(2170));

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Students",
                keyColumn: "UserProfileId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 150, DateTimeKind.Utc).AddTicks(2611));

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Students",
                keyColumn: "UserProfileId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 150, DateTimeKind.Utc).AddTicks(2616));

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Students",
                keyColumn: "UserProfileId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 150, DateTimeKind.Utc).AddTicks(2617));

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Students",
                keyColumn: "UserProfileId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 150, DateTimeKind.Utc).AddTicks(2618));

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Students",
                keyColumn: "UserProfileId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 18, 8, 40, 36, 150, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8353f365-82f9-4e05-bdb1-42e058716990");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b90cb2f5-cb07-4a4a-8ebc-00735dce4c0b");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "341288a8-f0e4-4b7f-8572-17e073c00ef6");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "9a48c97b-a4c5-4342-a3dd-a5762eb079d9");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "a066a393-cdee-4515-bb05-7f523066d910");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "304452bc-1d8a-464f-836e-f938266e3fb4");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "2c1a8641-73cb-402d-a481-b5f1aee62f2a");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "e7dc7f13-f3f7-4944-9fbe-7eec5bbd62ba");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "17ab8c9f-79d2-4698-a028-b25f2fedb32a");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "UserIdentities",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "d7d00c88-a369-4e79-b94a-5f56ec5950c7");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                schema: "user",
                table: "UserProfiles",
                newName: "UrlImage");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                schema: "user",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                schema: "user",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "user",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2025, 7, 18, 6, 3, 22, 641, DateTimeKind.Utc).AddTicks(5630), "A passionate front-end engineer with deep understanding of UI/UX and web accessibility standards. Taught over 20,000 students online." });

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Instructors",
                keyColumn: "UserProfileId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2025, 7, 18, 6, 3, 22, 641, DateTimeKind.Utc).AddTicks(5636), "React.js and modern JavaScript enthusiast. Developed enterprise-level SPAs and actively contributes to open source projects." });

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Instructors",
                keyColumn: "UserProfileId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2025, 7, 18, 6, 3, 22, 641, DateTimeKind.Utc).AddTicks(5638), "Data scientist with a focus on machine learning and NLP. Regular speaker at tech conferences and contributor to AI research papers." });

            migrationBuilder.UpdateData(
                schema: "user",
                table: "Instructors",
                keyColumn: "UserProfileId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2025, 7, 18, 6, 3, 22, 641, DateTimeKind.Utc).AddTicks(5640), "Senior full-stack developer with DevOps experience. Has led development teams in building scalable cloud-based solutions." });

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
    }
}
