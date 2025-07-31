using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduCore.BackEnd.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitDbAndData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "exercise");

            migrationBuilder.EnsureSchema(
                name: "course");

            migrationBuilder.EnsureSchema(
                name: "certificate");

            migrationBuilder.EnsureSchema(
                name: "review");

            migrationBuilder.EnsureSchema(
                name: "enrollment");

            migrationBuilder.EnsureSchema(
                name: "user");

            migrationBuilder.EnsureSchema(
                name: "payment");

            migrationBuilder.EnsureSchema(
                name: "identity");

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserIdentities",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
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
                    table.PrimaryKey("PK_UserIdentities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                schema: "course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "course",
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                schema: "identity",
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
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "identity",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                schema: "identity",
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
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_UserIdentities_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "UserIdentities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                schema: "identity",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_UserIdentities_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "UserIdentities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                schema: "user",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles_UserId", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserProfiles_UserIdentities_Id",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "UserIdentities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "identity",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "identity",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_UserIdentities_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "UserIdentities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                schema: "identity",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_UserIdentities_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "UserIdentities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                schema: "course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    InstructorProfileId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Level = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Duration = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(2,1)", nullable: true),
                    SubCategoryId = table.Column<int>(type: "int", nullable: true),
                    URL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifierId = table.Column<int>(type: "int", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterId = table.Column<int>(type: "int", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Profiles_AccountId",
                        column: x => x.InstructorProfileId,
                        principalSchema: "user",
                        principalTable: "UserProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_SubCategories_Id",
                        column: x => x.SubCategoryId,
                        principalSchema: "course",
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                schema: "user",
                columns: table => new
                {
                    UserProfileId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qualifications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specializations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearsOfExperience = table.Column<int>(type: "int", nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifierId = table.Column<int>(type: "int", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterId = table.Column<int>(type: "int", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors_UserProfileId", x => x.UserProfileId);
                    table.ForeignKey(
                        name: "FK_Instructors_Profiles_AccountId",
                        column: x => x.UserProfileId,
                        principalSchema: "user",
                        principalTable: "UserProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                schema: "user",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserProfileId = table.Column<int>(type: "int", nullable: false),
                    Theme = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Language = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NotificationsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Settings_UserProfiles_UserId",
                        column: x => x.UserProfileId,
                        principalSchema: "user",
                        principalTable: "UserProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                schema: "user",
                columns: table => new
                {
                    UserProfileId = table.Column<int>(type: "int", nullable: false),
                    EducationLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Interests = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifierId = table.Column<int>(type: "int", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterId = table.Column<int>(type: "int", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students_UserProfileId", x => x.UserProfileId);
                    table.ForeignKey(
                        name: "FK_Students_UserProfiles_UserId",
                        column: x => x.UserProfileId,
                        principalSchema: "user",
                        principalTable: "UserProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                schema: "certificate",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertificateUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates_CourseId", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Certificates_Courses_Id",
                        column: x => x.CourseId,
                        principalSchema: "course",
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                schema: "enrollment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentProfileId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CompletedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifierId = table.Column<int>(type: "int", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterId = table.Column<int>(type: "int", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments_EnrollmentId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enrollmens_Courses_Id",
                        column: x => x.CourseId,
                        principalSchema: "course",
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrollmens_UserProfiles_UserId",
                        column: x => x.StudentProfileId,
                        principalSchema: "user",
                        principalTable: "UserProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                schema: "course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    DiscountPercent = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sale_Courses_CourseId",
                        column: x => x.CourseId,
                        principalSchema: "course",
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                schema: "course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    WeightPercentage = table.Column<float>(type: "real", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_Courses_Id",
                        column: x => x.CourseId,
                        principalSchema: "course",
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                schema: "enrollment",
                columns: table => new
                {
                    StudentProfileId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses_StudentProfileId_CourseId", x => new { x.StudentProfileId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentCourses_Courses_Id",
                        column: x => x.CourseId,
                        principalSchema: "course",
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentCourses_UserProfiles_UserId",
                        column: x => x.StudentProfileId,
                        principalSchema: "user",
                        principalTable: "UserProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                schema: "payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnrollmentId = table.Column<int>(type: "int", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    UserProfileUserId = table.Column<int>(type: "int", nullable: true),
                    InstructorProfileId = table.Column<int>(type: "int", nullable: true),
                    SystemPayment_CourseId = table.Column<int>(type: "int", nullable: true),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifierId = table.Column<int>(type: "int", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterId = table.Column<int>(type: "int", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Courses_CourseId",
                        column: x => x.CourseId,
                        principalSchema: "course",
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_Courses_SystemPayment_CourseId",
                        column: x => x.SystemPayment_CourseId,
                        principalSchema: "course",
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_UserProfiles_UserProfileUserId",
                        column: x => x.UserProfileUserId,
                        principalSchema: "user",
                        principalTable: "UserProfiles",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_StudentPayments_Enrollments_EnrollmentId",
                        column: x => x.EnrollmentId,
                        principalSchema: "enrollment",
                        principalTable: "Enrollments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemPayments_Profiles_AccountId",
                        column: x => x.InstructorProfileId,
                        principalSchema: "user",
                        principalTable: "UserProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                schema: "review",
                columns: table => new
                {
                    EnrollmentId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReOpen = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifierId = table.Column<int>(type: "int", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterId = table.Column<int>(type: "int", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews_EnrollmentId", x => x.EnrollmentId);
                    table.ForeignKey(
                        name: "FK_Reviews_Enrollments_EnrollmentId",
                        column: x => x.EnrollmentId,
                        principalSchema: "enrollment",
                        principalTable: "Enrollments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lectures",
                schema: "course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    IsPreview = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    ResourceUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    WeightPercentage = table.Column<float>(type: "real", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lectures_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lectures_Sections_Id",
                        column: x => x.SectionId,
                        principalSchema: "course",
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                schema: "review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfLikes = table.Column<int>(type: "int", nullable: false),
                    LectureId = table.Column<int>(type: "int", nullable: false),
                    ParentCommentId = table.Column<int>(type: "int", nullable: true),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifierId = table.Column<int>(type: "int", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterId = table.Column<int>(type: "int", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Comments_Id",
                        column: x => x.ParentCommentId,
                        principalSchema: "review",
                        principalTable: "Comments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Lectures_Id",
                        column: x => x.LectureId,
                        principalSchema: "course",
                        principalTable: "Lectures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Profiles_AccountId",
                        column: x => x.CreatorId,
                        principalSchema: "user",
                        principalTable: "UserProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContentBlocks",
                schema: "course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LectureId = table.Column<int>(type: "int", nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentBlocks_Id", x => x.Id);
                    table.ForeignKey(
                        name: "PK_ContentBlocks_LectureId",
                        column: x => x.LectureId,
                        principalSchema: "course",
                        principalTable: "Lectures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                schema: "exercise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    MaxScore = table.Column<float>(type: "real", nullable: false, defaultValue: 10f),
                    WeightPercentage = table.Column<float>(type: "real", nullable: false, defaultValue: 0f),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LectureId = table.Column<int>(type: "int", nullable: false),
                    ExerciseUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubmissionInstruction = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    AllowResubmission = table.Column<bool>(type: "bit", nullable: true),
                    GuidelineDocumentUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    SampleProjectUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercises_Lectures_Id",
                        column: x => x.LectureId,
                        principalSchema: "course",
                        principalTable: "Lectures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                schema: "exercise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuizId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Exercises_QuizId",
                        column: x => x.QuizId,
                        principalSchema: "exercise",
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Submissions",
                schema: "exercise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    StudentProfileId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<float>(type: "real", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmittedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsResubmitted = table.Column<bool>(type: "bit", nullable: false),
                    ResubmittedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submissions_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Submissions_Exercises_Id",
                        column: x => x.ExerciseId,
                        principalSchema: "exercise",
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Submissions_Profiles_AccountId",
                        column: x => x.StudentProfileId,
                        principalSchema: "user",
                        principalTable: "UserProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                schema: "exercise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_Id",
                        column: x => x.QuestionId,
                        principalSchema: "exercise",
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "course",
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Development" },
                    { 2, "Business" },
                    { 3, "Finance & Accounting" },
                    { 4, "IT & Software" },
                    { 5, "Office Productivity" },
                    { 6, "Personal Development" },
                    { 7, "Design" },
                    { 8, "Marketing" },
                    { 9, "Lifestyle" },
                    { 10, "Photography & Video" }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Admin", "ADMIN" },
                    { 2, null, "Instructor", "INSTRUCTOR" },
                    { 3, null, "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "UserIdentities",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "ce57a99c-7e20-4c7c-9a1e-329ccb7c814a", "admin@eduplatform.com", true, true, false, null, "ADMIN@EDUPLATFORM.COM", "ADMIN", null, null, false, "A1", false, "admin" },
                    { 2, 0, "0ff61962-2b0f-4dc3-9421-60f9735c78ce", "john@eduplatform.com", true, true, false, null, "JOHN@EDUPLATFORM.COM", "INSTRUCTOR.JOHN", null, null, false, "A2", false, "instructor.john" },
                    { 3, 0, "a3cafbc4-2404-46e9-ac60-483456f76d42", "jane@eduplatform.com", true, true, false, null, "JANE@EDUPLATFORM.COM", "INSTRUCTOR.JANE", null, null, false, "A3", false, "instructor.jane" },
                    { 4, 0, "06d87006-7882-483e-b426-43e5646d8505", "mike@eduplatform.com", true, true, false, null, "MIKE@EDUPLATFORM.COM", "INSTRUCTOR.MIKE", null, null, false, "A4", false, "instructor.mike" },
                    { 5, 0, "e9c7d78f-d234-4373-88ec-891550d7a543", "emily@eduplatform.com", true, true, false, null, "EMILY@EDUPLATFORM.COM", "INSTRUCTOR.EMILY", null, null, false, "A5", false, "instructor.emily" },
                    { 6, 0, "3a5bee4e-ea5e-4cf9-9c17-2dea66756a12", "alex@eduplatform.com", true, true, false, null, "ALEX@EDUPLATFORM.COM", "STUDENT.ALEX", null, null, false, "A6", false, "student.alex" },
                    { 7, 0, "66c69d5a-9ac5-4363-8d10-7570a32e76b0", "sophia@eduplatform.com", true, true, false, null, "SOPHIA@EDUPLATFORM.COM", "STUDENT.SOPHIA", null, null, false, "A7", false, "student.sophia" },
                    { 8, 0, "7d68c499-acc0-4703-a004-a71e0d12d13a", "william@eduplatform.com", true, true, false, null, "WILLIAM@EDUPLATFORM.COM", "STUDENT.WILLIAM", null, null, false, "A8", false, "student.william" },
                    { 9, 0, "19f02f90-a8d5-4af7-a42c-5b976c30b09a", "olivia@eduplatform.com", true, true, false, null, "OLIVIA@EDUPLATFORM.COM", "STUDENT.OLIVIA", null, null, false, "A9", false, "student.olivia" },
                    { 10, 0, "62d6b3f5-4e0b-4a8a-9cda-a80a5e7bed36", "david@eduplatform.com", true, true, false, null, "DAVID@EDUPLATFORM.COM", "STUDENT.DAVID", null, null, false, "A10", false, "student.david" }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "RoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "Permission", "FullAccess", 1 },
                    { 2, "Permission", "ManageCourses", 2 },
                    { 3, "Permission", "EnrollCourses", 3 }
                });

            migrationBuilder.InsertData(
                schema: "course",
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Web Development" },
                    { 2, 1, "Data Science" },
                    { 3, 1, "Mobile Development" },
                    { 4, 1, "Game Development" },
                    { 5, 1, "Programming Languages" },
                    { 6, 1, "Database Design" },
                    { 7, 1, "Software Testing" },
                    { 8, 1, "DevOps" },
                    { 9, 1, "Cloud Computing" },
                    { 10, 1, "Cyber Security" },
                    { 11, 2, "Entrepreneurship" },
                    { 12, 3, "Accounting" },
                    { 13, 4, "Network & Security" },
                    { 14, 5, "Microsoft Office" },
                    { 15, 6, "Productivity Hacks" },
                    { 16, 7, "UX/UI Design" },
                    { 17, 8, "Social Media Marketing" },
                    { 18, 10, "Video Production" }
                });

            migrationBuilder.InsertData(
                schema: "user",
                table: "UserProfiles",
                columns: new[] { "UserId", "Address", "Bio", "FullName", "UrlImage" },
                values: new object[,]
                {
                    { 1, "System HQ", "Platform administrator with full access rights.", "Admin User", "https://example.com/images/admin.jpg" },
                    { 2, "123 Instructor Ave", "Instructor in web development and design.", "John Smith", "https://example.com/images/instructor1.jpg" },
                    { 3, "456 Teaching Blvd", "Experienced instructor in data science and AI.", "Jane Doe", "https://example.com/images/instructor2.jpg" },
                    { 4, "789 Mentor Street", "Instructor focused on backend technologies.", "Michael Brown", "https://example.com/images/instructor3.jpg" },
                    { 5, "1010 Code Lane", "DevOps engineer and cloud solutions instructor.", "Emily Johnson", "https://example.com/images/instructor4.jpg" },
                    { 6, "202 Student Road", "Student learning full-stack web development.", "Alex Nguyen", "https://example.com/images/student1.jpg" },
                    { 7, "303 Student Avenue", "Student interested in UI/UX and mobile apps.", "Sophia Le", "https://example.com/images/student2.jpg" },
                    { 8, "404 Study Blvd", "Student exploring cloud infrastructure and databases.", "William Pham", "https://example.com/images/student3.jpg" },
                    { 9, "505 Academy Street", "Student specializing in Android and Flutter.", "Olivia Tran", "https://example.com/images/student4.jpg" },
                    { 10, "606 Education Drive", "Student passionate about AI and machine learning.", "David Vo", "https://example.com/images/student5.jpg" }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 }
                });

            migrationBuilder.InsertData(
                schema: "course",
                table: "Courses",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "DeleterId", "Description", "Duration", "InstructorProfileId", "IsDeleted", "Level", "ModifiedAt", "ModifierId", "Price", "Rating", "SubCategoryId", "Title", "URL" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3300), null, null, "Learn the fundamentals of web development", "4h", 2, false, "Beginner", null, null, 49.99m, 4.5m, 1, "HTML & CSS Basics", "https://example.com/html" },
                    { 2, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3312), null, null, "Master JavaScript core concepts", "6h", 2, false, "Intermediate", null, null, 59.99m, 4.6m, 1, "JavaScript Essentials", "https://example.com/js" },
                    { 3, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3315), null, null, "Build modern web apps with React", "5h", 3, false, "Beginner", null, null, 69.99m, 4.7m, 1, "React for Beginners", "https://example.com/react" },
                    { 4, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3361), null, null, "Create flexible layouts with CSS", "3h", 4, false, "Advanced", null, null, 39.99m, 4.8m, 1, "Advanced CSS Flexbox", "https://example.com/css-flex" },
                    { 5, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3363), null, null, "Backend JavaScript with Node.js", "5.5h", 5, false, "Intermediate", null, null, 54.99m, 4.4m, 1, "Node.js Fundamentals", "https://example.com/node" },
                    { 6, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3367), null, null, "Build a complete MERN stack app", "8h", 2, false, "Advanced", null, null, 89.99m, 4.9m, 1, "Fullstack Project: MERN", "https://example.com/mern" },
                    { 7, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3370), null, null, "Style modern UI with Tailwind", "2h", 4, false, "Beginner", null, null, 29.99m, 4.3m, 1, "Tailwind CSS Crash Course", "https://example.com/tailwind" },
                    { 8, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3374), null, null, "Master DSA in JS", "6h", 3, false, "Advanced", null, null, 64.99m, 4.7m, 1, "JavaScript Algorithms", "https://example.com/js-dsa" },
                    { 9, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3376), null, null, "Learn SSR with Next.js", "5h", 5, false, "Intermediate", null, null, 74.99m, 4.5m, 1, "Next.js from Scratch", "https://example.com/nextjs" },
                    { 10, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3379), null, null, "Use TS to build reliable apps", "4.5h", 2, false, "Intermediate", null, null, 59.99m, 4.6m, 1, "TypeScript for Web Dev", "https://example.com/ts" },
                    { 11, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3381), null, null, "Data science basics", "3h", 2, false, "Beginner", null, null, 49.99m, 4.5m, 2, "Intro to Data Science", "https://example.com/ds" },
                    { 12, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3384), null, null, "Use pandas and numpy", "6h", 2, false, "Intermediate", null, null, 59.99m, 4.6m, 2, "Python for Data Analysis", "https://example.com/python-data" },
                    { 13, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3387), null, null, "Build Android apps", "5h", 3, false, "Beginner", null, null, 69.99m, 4.7m, 3, "Android Development", "https://example.com/android" },
                    { 14, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3389), null, null, "Start with iOS dev", "4h", 4, false, "Beginner", null, null, 79.99m, 4.6m, 3, "iOS SwiftUI Basics", "https://example.com/swiftui" },
                    { 15, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3392), null, null, "Create 2D games", "6h", 5, false, "Intermediate", null, null, 84.99m, 4.5m, 4, "Unity Game Dev", "https://example.com/unity" },
                    { 16, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3397), null, null, "3D game dev with UE", "7h", 2, false, "Advanced", null, null, 89.99m, 4.7m, 4, "Unreal Engine Essentials", "https://example.com/unreal" },
                    { 17, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3400), null, null, "Learn C# basics", "4h", 4, false, "Beginner", null, null, 44.99m, 4.4m, 5, "C# for Beginners", "https://example.com/csharp" },
                    { 18, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3402), null, null, "Core Java concepts", "5h", 3, false, "Intermediate", null, null, 54.99m, 4.6m, 5, "Java Programming", "https://example.com/java" },
                    { 19, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3405), null, null, "Dynamic websites with PHP", "6h", 5, false, "Intermediate", null, null, 59.99m, 4.3m, 3, "PHP & MySQL Web App", "https://example.com/php" },
                    { 20, new DateTime(2025, 7, 18, 4, 26, 39, 79, DateTimeKind.Utc).AddTicks(3408), null, null, "Modern Android dev", "5h", 2, false, "Intermediate", null, null, 64.99m, 4.5m, 3, "Kotlin for Android", "https://example.com/kotlin" }
                });

            migrationBuilder.InsertData(
                schema: "user",
                table: "Instructors",
                columns: new[] { "UserProfileId", "CreatedAt", "CreatorId", "DeletedAt", "DeleterId", "Description", "IsDeleted", "ModifiedAt", "ModifierId", "Qualifications", "Specializations", "Website", "YearsOfExperience" },
                values: new object[,]
                {
                    { 2, new DateTime(2025, 7, 18, 4, 26, 39, 82, DateTimeKind.Utc).AddTicks(7561), 0, null, null, "A passionate front-end engineer with deep understanding of UI/UX and web accessibility standards. Taught over 20,000 students online.", false, null, null, "B.Sc. in Computer Science, Certified Web Accessibility Specialist", "HTML, CSS, JavaScript, UI/UX", "https://frontendmentor.dev", 6 },
                    { 3, new DateTime(2025, 7, 18, 4, 26, 39, 82, DateTimeKind.Utc).AddTicks(7566), 0, null, null, "React.js and modern JavaScript enthusiast. Developed enterprise-level SPAs and actively contributes to open source projects.", false, null, null, "M.Sc. in Software Engineering, React Certification", "React, Redux, TypeScript, Next.js", "https://reactwizard.io", 5 },
                    { 4, new DateTime(2025, 7, 18, 4, 26, 39, 82, DateTimeKind.Utc).AddTicks(7568), 0, null, null, "Data scientist with a focus on machine learning and NLP. Regular speaker at tech conferences and contributor to AI research papers.", false, null, null, "PhD in Artificial Intelligence", "Machine Learning, NLP, Python, TensorFlow", "https://datasciencelab.ai", 8 },
                    { 5, new DateTime(2025, 7, 18, 4, 26, 39, 82, DateTimeKind.Utc).AddTicks(7570), 0, null, null, "Senior full-stack developer with DevOps experience. Has led development teams in building scalable cloud-based solutions.", false, null, null, "AWS Certified DevOps Engineer, Full Stack Bootcamp Graduate", "Node.js, Docker, AWS, MongoDB", "https://devopsfullstack.pro", 7 }
                });

            migrationBuilder.InsertData(
                schema: "payment",
                table: "Payments",
                columns: new[] { "Id", "Amount", "SystemPayment_CourseId", "CreatedAt", "CreatorId", "DeletedAt", "DeleterId", "Discriminator", "InstructorProfileId", "IsDeleted", "ModifiedAt", "ModifierId", "PaymentDate", "PaymentMethod", "Status", "TransactionId" },
                values: new object[,]
                {
                    { 5, 1500000m, null, new DateTime(2025, 7, 18, 4, 26, 39, 94, DateTimeKind.Utc).AddTicks(8910), 0, null, null, "SystemPayment", 2, false, null, null, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "BankTransfer", "Completed", "SYS1001" },
                    { 6, 2000000m, null, new DateTime(2025, 7, 18, 4, 26, 39, 94, DateTimeKind.Utc).AddTicks(8920), 0, null, null, "SystemPayment", 3, false, null, null, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "BankTransfer", "Completed", "SYS1002" },
                    { 7, 1700000m, null, new DateTime(2025, 7, 18, 4, 26, 39, 94, DateTimeKind.Utc).AddTicks(8923), 0, null, null, "SystemPayment", 4, false, null, null, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "BankTransfer", "Completed", "SYS1003" },
                    { 8, 1800000m, null, new DateTime(2025, 7, 18, 4, 26, 39, 94, DateTimeKind.Utc).AddTicks(8926), 0, null, null, "SystemPayment", 5, false, null, null, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "BankTransfer", "Completed", "SYS1004" }
                });

            migrationBuilder.InsertData(
                schema: "user",
                table: "Settings",
                columns: new[] { "Id", "Language", "NotificationsEnabled", "Theme", "UserProfileId" },
                values: new object[,]
                {
                    { 1, "en", true, "Light", 1 },
                    { 2, "vi", true, "Dark", 2 },
                    { 3, "en", false, "Light", 3 },
                    { 4, "vi", true, "Dark", 4 },
                    { 5, "en", true, "Light", 5 },
                    { 6, "vi", false, "Dark", 6 },
                    { 7, "en", true, "Light", 7 },
                    { 8, "vi", true, "Dark", 8 },
                    { 9, "en", false, "Light", 9 },
                    { 10, "vi", true, "Dark", 10 }
                });

            migrationBuilder.InsertData(
                schema: "user",
                table: "Students",
                columns: new[] { "UserProfileId", "CreatedAt", "CreatorId", "DeletedAt", "DeleterId", "EducationLevel", "Interests", "IsDeleted", "ModifiedAt", "ModifierId" },
                values: new object[,]
                {
                    { 6, new DateTime(2025, 7, 18, 4, 26, 39, 89, DateTimeKind.Utc).AddTicks(812), 0, null, null, "Undergraduate", "Frontend development, graphic design, and responsive web design.", false, null, null },
                    { 7, new DateTime(2025, 7, 18, 4, 26, 39, 89, DateTimeKind.Utc).AddTicks(815), 0, null, null, "Graduate", "Database systems, data warehousing, and performance optimization techniques.", false, null, null },
                    { 8, new DateTime(2025, 7, 18, 4, 26, 39, 89, DateTimeKind.Utc).AddTicks(816), 0, null, null, "PhD", "Artificial Intelligence, deep learning, and ethical AI in education.", false, null, null },
                    { 9, new DateTime(2025, 7, 18, 4, 26, 39, 89, DateTimeKind.Utc).AddTicks(817), 0, null, null, "High School", "Mobile apps, cross-platform development, and game mechanics.", false, null, null },
                    { 10, new DateTime(2025, 7, 18, 4, 26, 39, 89, DateTimeKind.Utc).AddTicks(819), 0, null, null, "College", "Cybersecurity, ethical hacking, and network architecture.", false, null, null }
                });

            migrationBuilder.InsertData(
                schema: "certificate",
                table: "Certificates",
                columns: new[] { "CourseId", "CertificateUrl", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "https://example.com/cert/html", "Certificate for completing HTML & CSS Basics", "HTML & CSS Basics Certificate" },
                    { 2, "https://example.com/cert/js", "Certificate for mastering JavaScript core concepts", "JavaScript Essentials Certificate" },
                    { 3, "https://example.com/cert/react", "Certificate for learning React", "React for Beginners Certificate" },
                    { 4, "https://example.com/cert/css-flex", "Certificate for mastering CSS Flexbox", "Advanced CSS Flexbox Certificate" },
                    { 5, "https://example.com/cert/node", "Certificate for learning Node.js", "Node.js Fundamentals Certificate" },
                    { 6, "https://example.com/cert/mern", "Certificate for completing MERN stack project", "Fullstack MERN Project Certificate" },
                    { 7, "https://example.com/cert/tailwind", "Certificate for Tailwind CSS", "Tailwind CSS Crash Course Certificate" },
                    { 8, "https://example.com/cert/js-dsa", "Certificate for completing JS algorithms", "JavaScript Algorithms Certificate" },
                    { 9, "https://example.com/cert/nextjs", "Certificate for mastering Next.js", "Next.js from Scratch Certificate" },
                    { 10, "https://example.com/cert/ts", "Certificate for learning TypeScript", "TypeScript for Web Dev Certificate" },
                    { 11, "https://example.com/cert/ds", "Certificate for learning Data Science basics", "Intro to Data Science Certificate" },
                    { 12, "https://example.com/cert/python-data", "Certificate for pandas and numpy", "Python for Data Analysis Certificate" },
                    { 13, "https://example.com/cert/android", "Certificate for Android development", "Android Development Certificate" },
                    { 14, "https://example.com/cert/swiftui", "Certificate for iOS development", "iOS SwiftUI Basics Certificate" },
                    { 15, "https://example.com/cert/unity", "Certificate for Unity game development", "Unity Game Dev Certificate" },
                    { 16, "https://example.com/cert/unreal", "Certificate for Unreal Engine development", "Unreal Engine Essentials Certificate" },
                    { 17, "https://example.com/cert/csharp", "Certificate for C# basics", "C# for Beginners Certificate" },
                    { 18, "https://example.com/cert/java", "Certificate for Java programming", "Java Programming Certificate" },
                    { 19, "https://example.com/cert/php", "Certificate for PHP web development", "PHP & MySQL Web App Certificate" },
                    { 20, "https://example.com/cert/kotlin", "Certificate for Kotlin Android development", "Kotlin for Android Certificate" }
                });

            migrationBuilder.InsertData(
                schema: "enrollment",
                table: "Enrollments",
                columns: new[] { "Id", "CompletedAt", "CourseId", "CreatedAt", "CreatorId", "DeletedAt", "DeleterId", "IsDeleted", "ModifiedAt", "ModifierId", "Status", "StudentProfileId" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTime(2025, 7, 18, 4, 26, 39, 80, DateTimeKind.Utc).AddTicks(1913), 6, null, null, false, null, null, 0, 6 },
                    { 2, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2025, 7, 18, 4, 26, 39, 80, DateTimeKind.Utc).AddTicks(1924), 6, null, null, false, null, null, 2, 6 },
                    { 3, null, 2, new DateTime(2025, 7, 18, 4, 26, 39, 80, DateTimeKind.Utc).AddTicks(1950), 6, null, null, false, null, null, 5, 6 },
                    { 4, null, 11, new DateTime(2025, 7, 18, 4, 26, 39, 80, DateTimeKind.Utc).AddTicks(1951), 6, null, null, false, null, null, 0, 6 },
                    { 5, new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2025, 7, 18, 4, 26, 39, 80, DateTimeKind.Utc).AddTicks(1952), 7, null, null, false, null, null, 2, 7 },
                    { 6, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2025, 7, 18, 4, 26, 39, 80, DateTimeKind.Utc).AddTicks(1956), 8, null, null, false, null, null, 2, 8 },
                    { 7, new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2025, 7, 18, 4, 26, 39, 80, DateTimeKind.Utc).AddTicks(1958), 9, null, null, false, null, null, 2, 9 },
                    { 8, null, 18, new DateTime(2025, 7, 18, 4, 26, 39, 80, DateTimeKind.Utc).AddTicks(1960), 10, null, null, false, null, null, 5, 10 },
                    { 9, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2025, 7, 18, 4, 26, 39, 80, DateTimeKind.Utc).AddTicks(1961), 10, null, null, false, null, null, 2, 10 }
                });

            migrationBuilder.InsertData(
                schema: "course",
                table: "Sale",
                columns: new[] { "Id", "CourseId", "DiscountPercent", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 7, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 8, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 9, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 10, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 11, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 12, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 13, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 14, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 15, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 16, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 17, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 18, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 19, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 20, 40, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 1, 25, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 2, 25, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "course",
                table: "Sections",
                columns: new[] { "Id", "CourseId", "Duration", "Position", "Title", "WeightPercentage" },
                values: new object[,]
                {
                    { 1, 1, new TimeSpan(0, 0, 30, 0, 0), 1, "Introduction to HTML", 30f },
                    { 2, 1, new TimeSpan(0, 1, 0, 0, 0), 2, "Styling with CSS", 70f },
                    { 3, 2, new TimeSpan(0, 0, 45, 0, 0), 1, "JS Basics", 50f },
                    { 4, 2, new TimeSpan(0, 0, 45, 0, 0), 2, "JS Functions", 50f }
                });

            migrationBuilder.InsertData(
                schema: "course",
                table: "Lectures",
                columns: new[] { "Id", "Duration", "IsPreview", "Position", "ResourceUrl", "SectionId", "Title", "ViewCount", "WeightPercentage" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 0, 15, 0, 0), true, 1, null, 1, "What is HTML?", 200, 50f },
                    { 2, new TimeSpan(0, 0, 15, 0, 0), false, 2, null, 1, "Basic Tags", 150, 50f },
                    { 3, new TimeSpan(0, 0, 30, 0, 0), false, 1, null, 2, "CSS Selectors", 180, 50f },
                    { 4, new TimeSpan(0, 0, 30, 0, 0), false, 2, null, 2, "CSS Box Model", 160, 50f },
                    { 5, new TimeSpan(0, 0, 22, 0, 0), false, 1, null, 3, "Variables and Data Types", 210, 50f },
                    { 6, new TimeSpan(0, 0, 23, 0, 0), false, 2, null, 3, "Control Flow", 190, 50f },
                    { 7, new TimeSpan(0, 0, 25, 0, 0), false, 1, null, 4, "Functions Basics", 170, 50f },
                    { 8, new TimeSpan(0, 0, 20, 0, 0), false, 2, null, 4, "Arrow Functions", 165, 50f }
                });

            migrationBuilder.InsertData(
                schema: "payment",
                table: "Payments",
                columns: new[] { "Id", "Amount", "CourseId", "CreatedAt", "CreatorId", "DeletedAt", "DeleterId", "Discriminator", "EnrollmentId", "IsDeleted", "ModifiedAt", "ModifierId", "PaymentDate", "PaymentMethod", "Status", "TransactionId", "UserProfileUserId" },
                values: new object[,]
                {
                    { 1, 499000m, null, new DateTime(2025, 7, 18, 4, 26, 39, 91, DateTimeKind.Utc).AddTicks(6431), 0, null, null, "StudentPayment", 1, false, null, null, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "CreditCard", "Completed", "TXN1001", null },
                    { 2, 699000m, null, new DateTime(2025, 7, 18, 4, 26, 39, 91, DateTimeKind.Utc).AddTicks(6445), 0, null, null, "StudentPayment", 2, false, null, null, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PayPal", "Completed", "TXN1002", null },
                    { 3, 499000m, null, new DateTime(2025, 7, 18, 4, 26, 39, 91, DateTimeKind.Utc).AddTicks(6449), 0, null, null, "StudentPayment", 3, false, null, null, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "CreditCard", "Completed", "TXN1003", null },
                    { 4, 699000m, null, new DateTime(2025, 7, 18, 4, 26, 39, 91, DateTimeKind.Utc).AddTicks(6451), 0, null, null, "StudentPayment", 4, false, null, null, new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "PayPal", "Completed", "TXN1004", null }
                });

            migrationBuilder.InsertData(
                schema: "review",
                table: "Reviews",
                columns: new[] { "EnrollmentId", "Content", "CreatedAt", "DeletedAt", "DeleterId", "IsDeleted", "ModifiedAt", "ModifierId", "Rating", "ReOpen" },
                values: new object[,]
                {
                    { 2, "Khóa học rất hữu ích!", new DateTime(2025, 7, 18, 4, 26, 39, 85, DateTimeKind.Utc).AddTicks(2940), null, null, false, null, null, 4.5m, null },
                    { 5, "Giáo viên giảng dễ hiểu.", new DateTime(2025, 7, 18, 4, 26, 39, 85, DateTimeKind.Utc).AddTicks(2946), null, null, false, null, null, 4.0m, null },
                    { 6, "Nội dung hơi ngắn, nhưng vẫn ổn.", new DateTime(2025, 7, 18, 4, 26, 39, 85, DateTimeKind.Utc).AddTicks(2948), null, null, false, null, null, 3.5m, null },
                    { 7, "Xuất sắc! Học được rất nhiều.", new DateTime(2025, 7, 18, 4, 26, 39, 85, DateTimeKind.Utc).AddTicks(2949), null, null, false, null, null, 5.0m, null },
                    { 9, "Tài liệu đầy đủ và chi tiết.", new DateTime(2025, 7, 18, 4, 26, 39, 85, DateTimeKind.Utc).AddTicks(2950), null, null, false, null, null, 4.8m, null }
                });

            migrationBuilder.InsertData(
                schema: "review",
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "CreatorId", "DeletedAt", "DeleterId", "IsDeleted", "LectureId", "ModifiedAt", "ModifierId", "NumberOfLikes", "ParentCommentId" },
                values: new object[,]
                {
                    { 1, "Great explanation on HTML basics!", new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7629), 2, null, null, false, 1, null, null, 3, null },
                    { 2, "This was really helpful, thanks!", new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7633), 3, null, null, false, 1, null, null, 5, null },
                    { 3, "Can you explain more about DOCTYPE?", new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7635), 4, null, null, false, 1, null, null, 1, null },
                    { 4, "Loved the video example!", new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7637), 5, null, null, false, 1, null, null, 4, null },
                    { 7, "I'm learning a lot from this lecture!", new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7638), 2, null, null, false, 1, null, null, 6, null },
                    { 8, "Is there a cheat sheet for HTML tags?", new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7639), 3, null, null, false, 1, null, null, 2, null }
                });

            migrationBuilder.InsertData(
                schema: "course",
                table: "ContentBlocks",
                columns: new[] { "Id", "Content", "ContentType", "ImageUrl", "LectureId", "Position", "Title" },
                values: new object[,]
                {
                    { 1, "HTML stands for HyperText Markup Language...", "Text", null, 1, 1, "HTML Overview" },
                    { 2, "https://www.youtube.com/embed/html_intro", "Video", null, 1, 2, "Intro Video" },
                    { 3, "<p>Hello World</p>", "Text", null, 2, 1, "Tag Examples" },
                    { 4, null, "Image", "https://example.com/images/html-tags.png", 2, 2, "HTML Tags Image" },
                    { 5, "Selectors let you target elements...", "Text", null, 3, 1, "Using Selectors" },
                    { 6, "JS has different data types such as string, number...", "Text", null, 5, 1, "Data Types" }
                });

            migrationBuilder.InsertData(
                schema: "exercise",
                table: "Exercises",
                columns: new[] { "Id", "Description", "Discriminator", "DueDate", "ExerciseUrl", "LectureId", "MaxScore", "WeightPercentage" },
                values: new object[] { 1, "Quiz for HTML Basics", "Quiz", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 10f, 20f });

            migrationBuilder.InsertData(
                schema: "exercise",
                table: "Exercises",
                columns: new[] { "Id", "AllowResubmission", "Description", "Discriminator", "DueDate", "ExerciseUrl", "LectureId", "MaxScore", "SubmissionInstruction", "WeightPercentage" },
                values: new object[] { 2, true, "Submit an HTML page", "Assignment", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 20f, "Submit via portal", 40f });

            migrationBuilder.InsertData(
                schema: "exercise",
                table: "Exercises",
                columns: new[] { "Id", "Description", "Discriminator", "DueDate", "ExerciseUrl", "GuidelineDocumentUrl", "LectureId", "MaxScore", "SampleProjectUrl", "WeightPercentage" },
                values: new object[] { 3, "Build a static website", "Project", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://example.com/guideline.pdf", 1, 30f, "https://example.com/sample.zip", 40f });

            migrationBuilder.InsertData(
                schema: "exercise",
                table: "Exercises",
                columns: new[] { "Id", "Description", "Discriminator", "DueDate", "ExerciseUrl", "LectureId", "MaxScore", "WeightPercentage" },
                values: new object[] { 4, "Quiz on Basic HTML Tags", "Quiz", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 10f, 30f });

            migrationBuilder.InsertData(
                schema: "exercise",
                table: "Exercises",
                columns: new[] { "Id", "AllowResubmission", "Description", "Discriminator", "DueDate", "ExerciseUrl", "LectureId", "MaxScore", "SubmissionInstruction", "WeightPercentage" },
                values: new object[] { 5, false, "Write HTML for a contact form", "Assignment", new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 20f, "Upload as .html file", 70f });

            migrationBuilder.InsertData(
                schema: "exercise",
                table: "Exercises",
                columns: new[] { "Id", "Description", "Discriminator", "DueDate", "ExerciseUrl", "GuidelineDocumentUrl", "LectureId", "MaxScore", "SampleProjectUrl", "WeightPercentage" },
                values: new object[] { 6, "Style a webpage using selectors", "Project", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://example.com/css_guideline.pdf", 3, 30f, "https://example.com/css_sample.zip", 100f });

            migrationBuilder.InsertData(
                schema: "exercise",
                table: "Exercises",
                columns: new[] { "Id", "Description", "Discriminator", "DueDate", "ExerciseUrl", "LectureId", "MaxScore", "WeightPercentage" },
                values: new object[] { 7, "Quiz on CSS Box Model", "Quiz", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 15f, 50f });

            migrationBuilder.InsertData(
                schema: "exercise",
                table: "Exercises",
                columns: new[] { "Id", "AllowResubmission", "Description", "Discriminator", "DueDate", "ExerciseUrl", "LectureId", "MaxScore", "SubmissionInstruction", "WeightPercentage" },
                values: new object[] { 8, true, "Box Model Layout Exercise", "Assignment", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 15f, "Provide a CSS file", 50f });

            migrationBuilder.InsertData(
                schema: "review",
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "CreatorId", "DeletedAt", "DeleterId", "IsDeleted", "LectureId", "ModifiedAt", "ModifierId", "NumberOfLikes", "ParentCommentId" },
                values: new object[,]
                {
                    { 5, "Sure, DOCTYPE tells the browser which HTML version you're using.", new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7641), 3, null, null, false, 1, null, null, 2, 3 },
                    { 6, "Agreed, video really helped.", new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7643), 2, null, null, false, 1, null, null, 1, 4 },
                    { 9, "You can find many online. W3Schools is great!", new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7644), 4, null, null, false, 1, null, null, 3, 8 }
                });

            migrationBuilder.InsertData(
                schema: "exercise",
                table: "Questions",
                columns: new[] { "Id", "Content", "QuizId" },
                values: new object[,]
                {
                    { 1, "What does HTML stand for?", 1 },
                    { 2, "What tag is used for a paragraph?", 1 },
                    { 3, "Which HTML tag creates a line break?", 4 },
                    { 4, "Which tag makes text bold?", 4 },
                    { 5, "What does the padding property affect in the box model?", 7 },
                    { 6, "Which CSS property sets the border size?", 7 }
                });

            migrationBuilder.InsertData(
                schema: "exercise",
                table: "Answers",
                columns: new[] { "Id", "Content", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { 1, "HyperText Markup Language", true, 1 },
                    { 2, "Home Tool Markup Language", false, 1 },
                    { 3, "Hyperlink and Text Markup Language", false, 1 },
                    { 4, "HighText Machine Language", false, 1 },
                    { 5, "<p>", true, 2 },
                    { 6, "<div>", false, 2 },
                    { 7, "<span>", false, 2 },
                    { 8, "<h1>", false, 2 },
                    { 9, "<br>", true, 3 },
                    { 10, "<hr>", false, 3 },
                    { 11, "<div>", false, 3 },
                    { 12, "<h2>", false, 3 },
                    { 13, "<b>", true, 4 },
                    { 14, "<i>", false, 4 },
                    { 15, "<u>", false, 4 },
                    { 16, "<em>", false, 4 },
                    { 17, "Inner spacing inside the border", true, 5 },
                    { 18, "Space outside the element", false, 5 },
                    { 19, "Text decoration", false, 5 },
                    { 20, "Font styling", false, 5 },
                    { 21, "border-width", true, 6 },
                    { 22, "margin", false, 6 },
                    { 23, "padding", false, 6 },
                    { 24, "outline", false, 6 }
                });

            migrationBuilder.InsertData(
                schema: "review",
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "CreatorId", "DeletedAt", "DeleterId", "IsDeleted", "LectureId", "ModifiedAt", "ModifierId", "NumberOfLikes", "ParentCommentId" },
                values: new object[] { 10, "Thanks for the tip!", new DateTime(2025, 7, 18, 4, 26, 39, 77, DateTimeKind.Utc).AddTicks(7646), 5, null, null, false, 1, null, null, 1, 9 });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                schema: "exercise",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CreatorId",
                schema: "review",
                table: "Comments",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_LectureId_ParentCommentId_CreatedAt_ProfileId",
                schema: "review",
                table: "Comments",
                columns: new[] { "LectureId", "ParentCommentId", "CreatedAt", "CreatorId" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ParentCommentId",
                schema: "review",
                table: "Comments",
                column: "ParentCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentBlocks_LectureId",
                schema: "course",
                table: "ContentBlocks",
                column: "LectureId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InstructorProfileId_SubCategoryId",
                schema: "course",
                table: "Courses",
                columns: new[] { "InstructorProfileId", "SubCategoryId" });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SubCategoryId",
                schema: "course",
                table: "Courses",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseId",
                schema: "enrollment",
                table: "Enrollments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentProfileId",
                schema: "enrollment",
                table: "Enrollments",
                column: "StudentProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentProfileId_CourseId",
                schema: "enrollment",
                table: "Enrollments",
                columns: new[] { "StudentProfileId", "CourseId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_LectureId_Discriminator",
                schema: "exercise",
                table: "Exercises",
                columns: new[] { "LectureId", "Discriminator" });

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_SectionId",
                schema: "course",
                table: "Lectures",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CourseId",
                schema: "payment",
                table: "Payments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_InstructorProfileId",
                schema: "payment",
                table: "Payments",
                column: "InstructorProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_SystemPayment_CourseId",
                schema: "payment",
                table: "Payments",
                column: "SystemPayment_CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UserProfileUserId",
                schema: "payment",
                table: "Payments",
                column: "UserProfileUserId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPayments_EnrollmentId",
                schema: "payment",
                table: "Payments",
                column: "EnrollmentId",
                unique: true,
                filter: "[EnrollmentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuizId",
                schema: "exercise",
                table: "Questions",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                schema: "identity",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "identity",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_CourseId",
                schema: "course",
                table: "Sale",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_CourseID",
                schema: "course",
                table: "Sections",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Settings_UserProfileId",
                schema: "user",
                table: "Settings",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseId",
                schema: "enrollment",
                table: "StudentCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_StudentProfileId",
                schema: "enrollment",
                table: "StudentCourses",
                column: "StudentProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                schema: "course",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_ExerciseId_StudentProfileId",
                schema: "exercise",
                table: "Submissions",
                columns: new[] { "ExerciseId", "StudentProfileId" });

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_StudentProfileId",
                schema: "exercise",
                table: "Submissions",
                column: "StudentProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                schema: "identity",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "identity",
                table: "UserIdentities",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "identity",
                table: "UserIdentities",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                schema: "identity",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                schema: "identity",
                table: "UserRoles",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers",
                schema: "exercise");

            migrationBuilder.DropTable(
                name: "Certificates",
                schema: "certificate");

            migrationBuilder.DropTable(
                name: "Comments",
                schema: "review");

            migrationBuilder.DropTable(
                name: "ContentBlocks",
                schema: "course");

            migrationBuilder.DropTable(
                name: "Instructors",
                schema: "user");

            migrationBuilder.DropTable(
                name: "Payments",
                schema: "payment");

            migrationBuilder.DropTable(
                name: "Reviews",
                schema: "review");

            migrationBuilder.DropTable(
                name: "RoleClaims",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Sale",
                schema: "course");

            migrationBuilder.DropTable(
                name: "Settings",
                schema: "user");

            migrationBuilder.DropTable(
                name: "StudentCourses",
                schema: "enrollment");

            migrationBuilder.DropTable(
                name: "Students",
                schema: "user");

            migrationBuilder.DropTable(
                name: "Submissions",
                schema: "exercise");

            migrationBuilder.DropTable(
                name: "UserClaims",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "UserLogins",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "UserTokens",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Questions",
                schema: "exercise");

            migrationBuilder.DropTable(
                name: "Enrollments",
                schema: "enrollment");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Exercises",
                schema: "exercise");

            migrationBuilder.DropTable(
                name: "Lectures",
                schema: "course");

            migrationBuilder.DropTable(
                name: "Sections",
                schema: "course");

            migrationBuilder.DropTable(
                name: "Courses",
                schema: "course");

            migrationBuilder.DropTable(
                name: "UserProfiles",
                schema: "user");

            migrationBuilder.DropTable(
                name: "SubCategories",
                schema: "course");

            migrationBuilder.DropTable(
                name: "UserIdentities",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "course");
        }
    }
}
