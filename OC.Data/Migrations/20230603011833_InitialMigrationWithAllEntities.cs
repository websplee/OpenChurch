using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OC.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationWithAllEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAudits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OldValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AffectedColumns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryKey = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAudits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblBranchStaffResignations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchStaffId = table.Column<long>(type: "bigint", nullable: false),
                    ResignationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBranchStaffResignations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblChurchProgramSessionAttendances",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblChurchProgramSessionAttendances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblChurchProgramSessions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTimeTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblChurchProgramSessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblChurchProgramSessionVistors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChurchProgramSessionId = table.Column<long>(type: "bigint", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblChurchProgramSessionVistors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblContinents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblContinents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblEducationFields",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEducationFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblEducationLevels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEducationLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblExpenseTpes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblExpenseTpes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblIncomeTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblIncomeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblLeadershipRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLeadershipRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblMemberEducations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<long>(type: "bigint", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMemberEducations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblMinistries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMinistries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblModules",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblModules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblTransactionTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTransactionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
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
                    table.PrimaryKey("PK_tblUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblCountries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContinentId = table.Column<long>(type: "bigint", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCountries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCountries_tblContinents_ContinentId",
                        column: x => x.ContinentId,
                        principalTable: "tblContinents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_tblRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "tblRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblRoleModules",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ModuleId = table.Column<long>(type: "bigint", nullable: false),
                    CanView = table.Column<bool>(type: "bit", nullable: false),
                    CanAddEdit = table.Column<bool>(type: "bit", nullable: false),
                    CanDelete = table.Column<bool>(type: "bit", nullable: false),
                    CanApprove = table.Column<bool>(type: "bit", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRoleModules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblRoleModules_tblModules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "tblModules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblRoleModules_tblRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "tblRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_tblUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_tblUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_tblUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_tblUserRoles_tblRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "tblRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblUserRoles_tblUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblRegions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfficeLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRegions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblRegions_tblCountries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "tblCountries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblBranches",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    OwnBuilding = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBranches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblBranches_tblRegions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "tblRegions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblBranchMinistries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MinistryId = table.Column<long>(type: "bigint", nullable: false),
                    BranchId = table.Column<long>(type: "bigint", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBranchMinistries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblBranchMinistries_tblBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "tblBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblBranchMinistries_tblMinistries_MinistryId",
                        column: x => x.MinistryId,
                        principalTable: "tblMinistries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblBranchStaff",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchId = table.Column<long>(type: "bigint", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBranchStaff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblBranchStaff_tblBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "tblBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblCellGroups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCellGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCellGroups_tblBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "tblBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblBranchLeaderships",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<long>(type: "bigint", nullable: false),
                    LeadershipRoleId = table.Column<long>(type: "bigint", nullable: false),
                    MemberId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBranchLeaderships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblBranchLeaderships_tblBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "tblBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblBranchLeaderships_tblLeadershipRoles_LeadershipRoleId",
                        column: x => x.LeadershipRoleId,
                        principalTable: "tblLeadershipRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblBranchMinistryLeaderships",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchMinistryId = table.Column<long>(type: "bigint", nullable: false),
                    LeadershipRoleId = table.Column<long>(type: "bigint", nullable: false),
                    MemberId = table.Column<long>(type: "bigint", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBranchMinistryLeaderships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblBranchMinistryLeaderships_tblBranchMinistries_BranchMinistryId",
                        column: x => x.BranchMinistryId,
                        principalTable: "tblBranchMinistries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblBranchMinistryLeaderships_tblLeadershipRoles_LeadershipRoleId",
                        column: x => x.LeadershipRoleId,
                        principalTable: "tblLeadershipRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblCellLeaderships",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CellGroupId = table.Column<long>(type: "bigint", nullable: false),
                    LeadershipRoleId = table.Column<long>(type: "bigint", nullable: false),
                    MemberId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCellLeaderships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCellLeaderships_tblCellGroups_CellGroupId",
                        column: x => x.CellGroupId,
                        principalTable: "tblCellGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblCellLeaderships_tblLeadershipRoles_LeadershipRoleId",
                        column: x => x.LeadershipRoleId,
                        principalTable: "tblLeadershipRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblExpenses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<long>(type: "bigint", nullable: false),
                    ChurchProgramSessionId = table.Column<long>(type: "bigint", nullable: true),
                    MemberId = table.Column<long>(type: "bigint", nullable: true),
                    ExpenseTypeId = table.Column<long>(type: "bigint", nullable: false),
                    TrxDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblExpenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblExpenses_tblBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "tblBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblExpenses_tblChurchProgramSessions_ChurchProgramSessionId",
                        column: x => x.ChurchProgramSessionId,
                        principalTable: "tblChurchProgramSessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblExpenses_tblExpenseTpes_ExpenseTypeId",
                        column: x => x.ExpenseTypeId,
                        principalTable: "tblExpenseTpes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblFamilies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyAdminId = table.Column<long>(type: "bigint", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFamilies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblMembers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<long>(type: "bigint", nullable: true),
                    CellGroupId = table.Column<long>(type: "bigint", nullable: true),
                    SpouseId = table.Column<long>(type: "bigint", nullable: true),
                    FamilyId = table.Column<long>(type: "bigint", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateBornAgain = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateBaptised = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateJoined = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblMembers_tblBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "tblBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblMembers_tblCellGroups_CellGroupId",
                        column: x => x.CellGroupId,
                        principalTable: "tblCellGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblMembers_tblFamilies_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "tblFamilies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tblMembers_tblMembers_SpouseId",
                        column: x => x.SpouseId,
                        principalTable: "tblMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblIncomes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<long>(type: "bigint", nullable: false),
                    ChurchProgramSessionId = table.Column<long>(type: "bigint", nullable: true),
                    MemberId = table.Column<long>(type: "bigint", nullable: true),
                    IncomeTypeId = table.Column<long>(type: "bigint", nullable: false),
                    TrxDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrxSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblIncomes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblIncomes_tblBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "tblBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblIncomes_tblChurchProgramSessions_ChurchProgramSessionId",
                        column: x => x.ChurchProgramSessionId,
                        principalTable: "tblChurchProgramSessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblIncomes_tblIncomeTypes_IncomeTypeId",
                        column: x => x.IncomeTypeId,
                        principalTable: "tblIncomeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblIncomes_tblMembers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "tblMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblIncomingTransfers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<long>(type: "bigint", nullable: false),
                    OldBranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberId = table.Column<long>(type: "bigint", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblIncomingTransfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblIncomingTransfers_tblBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "tblBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblIncomingTransfers_tblMembers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "tblMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblMemberTransactions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<long>(type: "bigint", nullable: false),
                    TransactionTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMemberTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblMemberTransactions_tblMembers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "tblMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblMemberTransactions_tblTransactionTypes_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "tblTransactionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblOutgoingTransfers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<long>(type: "bigint", nullable: false),
                    OldBranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberId = table.Column<long>(type: "bigint", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOutgoingTransfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblOutgoingTransfers_tblBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "tblBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblOutgoingTransfers_tblMembers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "tblMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblPledges",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<long>(type: "bigint", nullable: true),
                    MinistryId = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    PaidAmount = table.Column<double>(type: "float", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaidDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPledges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblPledges_tblMembers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "tblMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPledges_tblMinistries_MinistryId",
                        column: x => x.MinistryId,
                        principalTable: "tblMinistries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblRegionLeaderships",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionId = table.Column<long>(type: "bigint", nullable: false),
                    LeadershipRoleId = table.Column<long>(type: "bigint", nullable: false),
                    MemberId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRegionLeaderships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblRegionLeaderships_tblLeadershipRoles_LeadershipRoleId",
                        column: x => x.LeadershipRoleId,
                        principalTable: "tblLeadershipRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblRegionLeaderships_tblMembers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "tblMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblRegionLeaderships_tblRegions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "tblRegions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "tblContinents",
                columns: new[] { "Id", "ApprovalDate", "CheckerId", "IsActive", "MakerId", "Name", "RejectionDate", "SubmissionDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6844), "8a4353dd-5496-4ffe-bfa3-db90afab6684", null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Africa", null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6843) },
                    { 2L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6848), "8a4353dd-5496-4ffe-bfa3-db90afab6684", null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Australia", null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6847) },
                    { 3L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6850), "8a4353dd-5496-4ffe-bfa3-db90afab6684", null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "North America", null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6849) },
                    { 4L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6852), "8a4353dd-5496-4ffe-bfa3-db90afab6684", null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "South America", null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6851) },
                    { 5L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6854), "8a4353dd-5496-4ffe-bfa3-db90afab6684", null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Europe", null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6853) },
                    { 6L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6855), "8a4353dd-5496-4ffe-bfa3-db90afab6684", null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Asia", null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6855) }
                });

            migrationBuilder.InsertData(
                table: "tblModules",
                columns: new[] { "Id", "ApprovalDate", "CheckerId", "Description", "IsActive", "MakerId", "Name", "RejectionDate", "SubmissionDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6344), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Master access to all modules", true, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Admin", null, new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6341) },
                    { 2L, new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6350), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Users Management System Module", true, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Users", null, new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6349) },
                    { 3L, new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6353), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Accounting System Module", true, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Accounting", null, new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6352) },
                    { 4L, new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6355), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Reporting System Module", true, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Reports", null, new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6354) },
                    { 5L, new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6357), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Branches System Module", true, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Branches", null, new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6356) },
                    { 6L, new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6359), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Locations System Module", true, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Locations", null, new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6358) },
                    { 7L, new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6361), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Members System Module", true, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Members", null, new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6360) }
                });

            migrationBuilder.InsertData(
                table: "tblRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a8baeb0-7191-4731-b8f2-a8b22b5a8596", "2e0934ba-c952-489b-b1ab-0d45b3c45876", "FourthApprover", "FOURTHAPPROVER" },
                    { "575759c6-e020-4c4b-888d-24e01ba62797", "a0ddf440-0a71-45c2-8130-87d708759aad", "ThirdApprover", "THIRDAPPROVER" },
                    { "a173a5cc-3edc-4f49-979c-f423e044b202", "e2acfcaf-0f3a-42ec-b985-9d37ec0d4261", "FirstApprover", "FIRSTAPPROVER" },
                    { "a1922985-be01-4762-a2b6-32d6f4f58235", "a155248f-ed28-414b-ba63-4fd3054f6dad", "FifthApprover", "FIFTHAPPROVER" },
                    { "bdf53b89-5034-4dfa-8d2b-7441ce66a535", "ceab96dc-b68c-4654-bc0f-848b9cb55357", "Admin", "ADMIN" },
                    { "f0223225-0c52-413d-b188-0868ea111427", "b9611511-8010-4f77-b2e6-b6ed03401ace", "SecondApprover", "SECONDAPPROVER" },
                    { "f077ed29-51b7-4fe7-8136-c65b8e7b3f15", "41d17428-28af-4000-92ef-8c48a949cf4a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "tblUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApprovalDate", "CheckerId", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "Fullname", "IsActive", "LockoutEnabled", "LockoutEnd", "MakerId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureUrl", "RejectionDate", "SecurityStamp", "SubmissionDate", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8a4353dd-5496-4ffe-bfa3-db90afab6684", 0, new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(7004), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "29c3ec8a-e696-4baf-b78d-a1b641309f16", "Systems Administrator", "superadmin@blci.com", true, "Super Admin", true, false, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "SUPERADMIN@BLCI.COM", "SUPERADMIN@BLCI.COM", "AQAAAAEAACcQAAAAEDZdu5jfy1i0ecZHra5VQdO0sPWEvhmuc9kGU0tw1vPzqc3CJOJS3/eTdiPmk08pmg==", null, false, null, null, "4b3f282c-fc50-4dc7-a75b-c5154ae03512", new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(7001), false, "superadmin@blci.com" });

            migrationBuilder.InsertData(
                table: "tblCountries",
                columns: new[] { "Id", "ApprovalDate", "CheckerId", "Code", "ContinentId", "IsActive", "MakerId", "Name", "RejectionDate", "SubmissionDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6974), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "zm", 1L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Zambia", null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6973) },
                    { 2L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6977), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "cd", 1L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Democratic Republic of Congo", null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6976) },
                    { 3L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6984), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "na", 1L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Namibia", null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6983) },
                    { 4L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6986), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "za", 1L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "South Africa", null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6985) },
                    { 5L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6995), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "mw", 1L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Malawi", null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6994) },
                    { 6L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6997), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "tz", 1L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Tanzania", null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6996) },
                    { 7L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6999), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "bw", 1L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Botswana", null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6998) },
                    { 8L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7000), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "us", 3L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "United States", null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7000) },
                    { 9L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7002), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "au", 2L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Australia", null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7002) },
                    { 10L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7004), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "gb", 5L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "United Kingdom", null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7003) }
                });

            migrationBuilder.InsertData(
                table: "tblUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bdf53b89-5034-4dfa-8d2b-7441ce66a535", "8a4353dd-5496-4ffe-bfa3-db90afab6684" });

            migrationBuilder.InsertData(
                table: "tblRegions",
                columns: new[] { "Id", "ApprovalDate", "CheckerId", "CountryId", "IsActive", "MakerId", "Name", "OfficeLocation", "RejectionDate", "SubmissionDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7146), "8a4353dd-5496-4ffe-bfa3-db90afab6684", 1L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "North-Western", null, null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7145) },
                    { 2L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7149), "8a4353dd-5496-4ffe-bfa3-db90afab6684", 1L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Northern", null, null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7149) },
                    { 3L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7151), "8a4353dd-5496-4ffe-bfa3-db90afab6684", 1L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Muchinga", null, null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7151) },
                    { 4L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7154), "8a4353dd-5496-4ffe-bfa3-db90afab6684", 1L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Luapula", null, null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7153) },
                    { 5L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7155), "8a4353dd-5496-4ffe-bfa3-db90afab6684", 1L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Eastern", null, null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7155) },
                    { 6L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7157), "8a4353dd-5496-4ffe-bfa3-db90afab6684", 1L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Lusaka", null, null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7157) },
                    { 7L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7159), "8a4353dd-5496-4ffe-bfa3-db90afab6684", 1L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Central", null, null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7159) },
                    { 8L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7161), "8a4353dd-5496-4ffe-bfa3-db90afab6684", 1L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Copperbelt-South", null, null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7160) },
                    { 9L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7163), "8a4353dd-5496-4ffe-bfa3-db90afab6684", 1L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Copperbelt-North", null, null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7162) },
                    { 10L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7168), "8a4353dd-5496-4ffe-bfa3-db90afab6684", 1L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Southern", null, null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7167) },
                    { 11L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7170), "8a4353dd-5496-4ffe-bfa3-db90afab6684", 1L, null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Western", null, null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7169) }
                });

            migrationBuilder.InsertData(
                table: "tblBranches",
                columns: new[] { "Id", "ApprovalDate", "CheckerId", "Email", "IsActive", "Latitude", "Longitude", "MakerId", "Name", "OwnBuilding", "Phone1", "Phone2", "PhysicalAddress", "RegionId", "RejectionDate", "SubmissionDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5400), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "chawamabranch@blci.com", true, 0.0, 0.0, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Chawama", false, "", "", "Plot 10, Chawama Road", 6L, null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5396) },
                    { 2L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5413), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "chilangabranch@blci.com", true, 0.0, 0.0, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Chilanga", false, "", "", "Plot 3, Munda Wanga", 6L, null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5412) },
                    { 3L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5417), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "chongwebranch@blci.com", true, 0.0, 0.0, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Chongwe", false, "", "", "Corner Great East Road", 6L, null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5416) },
                    { 4L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5420), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "chisambabranch@blci.com", true, 0.0, 0.0, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Chisamba Boma", false, "", "", "Town Centre", 6L, null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5419) },
                    { 5L, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5422), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "chisambabranch@blci.com", true, 0.0, 0.0, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Chisamba William", false, "", "", "William Farm", 6L, null, new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5422) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblBranches_RegionId",
                table: "tblBranches",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_tblBranchLeaderships_BranchId",
                table: "tblBranchLeaderships",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_tblBranchLeaderships_LeadershipRoleId",
                table: "tblBranchLeaderships",
                column: "LeadershipRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_tblBranchLeaderships_MemberId",
                table: "tblBranchLeaderships",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_tblBranchMinistries_BranchId",
                table: "tblBranchMinistries",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_tblBranchMinistries_MinistryId",
                table: "tblBranchMinistries",
                column: "MinistryId");

            migrationBuilder.CreateIndex(
                name: "IX_tblBranchMinistryLeaderships_BranchMinistryId",
                table: "tblBranchMinistryLeaderships",
                column: "BranchMinistryId");

            migrationBuilder.CreateIndex(
                name: "IX_tblBranchMinistryLeaderships_LeadershipRoleId",
                table: "tblBranchMinistryLeaderships",
                column: "LeadershipRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_tblBranchMinistryLeaderships_MemberId",
                table: "tblBranchMinistryLeaderships",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_tblBranchStaff_BranchId",
                table: "tblBranchStaff",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCellGroups_BranchId",
                table: "tblCellGroups",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCellLeaderships_CellGroupId",
                table: "tblCellLeaderships",
                column: "CellGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCellLeaderships_LeadershipRoleId",
                table: "tblCellLeaderships",
                column: "LeadershipRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCellLeaderships_MemberId",
                table: "tblCellLeaderships",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCountries_ContinentId",
                table: "tblCountries",
                column: "ContinentId");

            migrationBuilder.CreateIndex(
                name: "IX_tblExpenses_BranchId",
                table: "tblExpenses",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_tblExpenses_ChurchProgramSessionId",
                table: "tblExpenses",
                column: "ChurchProgramSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_tblExpenses_ExpenseTypeId",
                table: "tblExpenses",
                column: "ExpenseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblExpenses_MemberId",
                table: "tblExpenses",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_tblFamilies_FamilyAdminId",
                table: "tblFamilies",
                column: "FamilyAdminId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblIncomes_BranchId",
                table: "tblIncomes",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_tblIncomes_ChurchProgramSessionId",
                table: "tblIncomes",
                column: "ChurchProgramSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_tblIncomes_IncomeTypeId",
                table: "tblIncomes",
                column: "IncomeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblIncomes_MemberId",
                table: "tblIncomes",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_tblIncomingTransfers_BranchId",
                table: "tblIncomingTransfers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_tblIncomingTransfers_MemberId",
                table: "tblIncomingTransfers",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_tblMembers_BranchId",
                table: "tblMembers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_tblMembers_CellGroupId",
                table: "tblMembers",
                column: "CellGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_tblMembers_FamilyId",
                table: "tblMembers",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_tblMembers_SpouseId",
                table: "tblMembers",
                column: "SpouseId");

            migrationBuilder.CreateIndex(
                name: "IX_tblMemberTransactions_MemberId",
                table: "tblMemberTransactions",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_tblMemberTransactions_TransactionTypeId",
                table: "tblMemberTransactions",
                column: "TransactionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblModules_Name",
                table: "tblModules",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblOutgoingTransfers_BranchId",
                table: "tblOutgoingTransfers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOutgoingTransfers_MemberId",
                table: "tblOutgoingTransfers",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPledges_MemberId",
                table: "tblPledges",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPledges_MinistryId",
                table: "tblPledges",
                column: "MinistryId");

            migrationBuilder.CreateIndex(
                name: "IX_tblRegionLeaderships_LeadershipRoleId",
                table: "tblRegionLeaderships",
                column: "LeadershipRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_tblRegionLeaderships_MemberId",
                table: "tblRegionLeaderships",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_tblRegionLeaderships_RegionId",
                table: "tblRegionLeaderships",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_tblRegions_CountryId",
                table: "tblRegions",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_tblRoleModules_ModuleId_RoleId",
                table: "tblRoleModules",
                columns: new[] { "ModuleId", "RoleId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblRoleModules_RoleId",
                table: "tblRoleModules",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "tblRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblUserRoles_RoleId",
                table: "tblUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "tblUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "tblUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_tblBranchLeaderships_tblMembers_MemberId",
                table: "tblBranchLeaderships",
                column: "MemberId",
                principalTable: "tblMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblBranchMinistryLeaderships_tblMembers_MemberId",
                table: "tblBranchMinistryLeaderships",
                column: "MemberId",
                principalTable: "tblMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblCellLeaderships_tblMembers_MemberId",
                table: "tblCellLeaderships",
                column: "MemberId",
                principalTable: "tblMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblExpenses_tblMembers_MemberId",
                table: "tblExpenses",
                column: "MemberId",
                principalTable: "tblMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblFamilies_tblMembers_FamilyAdminId",
                table: "tblFamilies",
                column: "FamilyAdminId",
                principalTable: "tblMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblBranches_tblRegions_RegionId",
                table: "tblBranches");

            migrationBuilder.DropForeignKey(
                name: "FK_tblCellGroups_tblBranches_BranchId",
                table: "tblCellGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_tblMembers_tblBranches_BranchId",
                table: "tblMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_tblFamilies_tblMembers_FamilyAdminId",
                table: "tblFamilies");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "tblAudits");

            migrationBuilder.DropTable(
                name: "tblBranchLeaderships");

            migrationBuilder.DropTable(
                name: "tblBranchMinistryLeaderships");

            migrationBuilder.DropTable(
                name: "tblBranchStaff");

            migrationBuilder.DropTable(
                name: "tblBranchStaffResignations");

            migrationBuilder.DropTable(
                name: "tblCellLeaderships");

            migrationBuilder.DropTable(
                name: "tblChurchProgramSessionAttendances");

            migrationBuilder.DropTable(
                name: "tblChurchProgramSessionVistors");

            migrationBuilder.DropTable(
                name: "tblEducationFields");

            migrationBuilder.DropTable(
                name: "tblEducationLevels");

            migrationBuilder.DropTable(
                name: "tblExpenses");

            migrationBuilder.DropTable(
                name: "tblIncomes");

            migrationBuilder.DropTable(
                name: "tblIncomingTransfers");

            migrationBuilder.DropTable(
                name: "tblMemberEducations");

            migrationBuilder.DropTable(
                name: "tblMemberTransactions");

            migrationBuilder.DropTable(
                name: "tblOutgoingTransfers");

            migrationBuilder.DropTable(
                name: "tblPledges");

            migrationBuilder.DropTable(
                name: "tblRegionLeaderships");

            migrationBuilder.DropTable(
                name: "tblRoleModules");

            migrationBuilder.DropTable(
                name: "tblUserRoles");

            migrationBuilder.DropTable(
                name: "tblBranchMinistries");

            migrationBuilder.DropTable(
                name: "tblExpenseTpes");

            migrationBuilder.DropTable(
                name: "tblChurchProgramSessions");

            migrationBuilder.DropTable(
                name: "tblIncomeTypes");

            migrationBuilder.DropTable(
                name: "tblTransactionTypes");

            migrationBuilder.DropTable(
                name: "tblLeadershipRoles");

            migrationBuilder.DropTable(
                name: "tblModules");

            migrationBuilder.DropTable(
                name: "tblRoles");

            migrationBuilder.DropTable(
                name: "tblUsers");

            migrationBuilder.DropTable(
                name: "tblMinistries");

            migrationBuilder.DropTable(
                name: "tblRegions");

            migrationBuilder.DropTable(
                name: "tblCountries");

            migrationBuilder.DropTable(
                name: "tblContinents");

            migrationBuilder.DropTable(
                name: "tblBranches");

            migrationBuilder.DropTable(
                name: "tblMembers");

            migrationBuilder.DropTable(
                name: "tblCellGroups");

            migrationBuilder.DropTable(
                name: "tblFamilies");
        }
    }
}
