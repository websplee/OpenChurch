using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OC.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChurchSettingsDbInsert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCellGroupHosts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CellGroupId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_tblCellGroupHosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCellGroupHosts_tblCellGroups_CellGroupId",
                        column: x => x.CellGroupId,
                        principalTable: "tblCellGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblCellGroupHosts_tblMembers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "tblMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblChurchSettings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FounderDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoundingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BranchId = table.Column<long>(type: "bigint", nullable: true),
                    MakerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblChurchSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblChurchSettings_tblBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "tblBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(820), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(831), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(837), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(842), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(855), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(2915), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(2920), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(2924), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(2927), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(2930), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(2933), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(2936), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4162), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4171), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4174), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4344), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4347), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4349), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4615), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4619), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4623), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4626), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4629), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4632), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4635), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4637), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4640), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4643), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(5284), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(5288), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(5290), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(5293), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(5295), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(5298), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(5300), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(5303), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(6058), new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(6064), new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(6068), new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(6071), new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(6075), new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(6081), new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4807), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4812), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4821), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4825), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4828), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4831), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4834), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4837), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4840), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4842), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4845), new DateTime(2025, 7, 30, 20, 9, 6, 661, DateTimeKind.Utc).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "0a8baeb0-7191-4731-b8f2-a8b22b5a8596",
                column: "ConcurrencyStamp",
                value: "3caa0a31-59a5-4da7-aae7-b0ce9dfc1260");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "575759c6-e020-4c4b-888d-24e01ba62797",
                column: "ConcurrencyStamp",
                value: "8555cc39-f634-4a94-a1a7-85d73c8d588f");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a173a5cc-3edc-4f49-979c-f423e044b202",
                column: "ConcurrencyStamp",
                value: "379836c8-c106-4541-809f-71b57aa535e3");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a1922985-be01-4762-a2b6-32d6f4f58235",
                column: "ConcurrencyStamp",
                value: "082e10a4-cd9a-4be4-bfe4-043eda4e0535");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "d48f050c-1abf-4aca-8f0e-2640d2995ba9");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f0223225-0c52-413d-b188-0868ea111427",
                column: "ConcurrencyStamp",
                value: "932b56ec-5984-442a-8a27-f6a51aa1baf1");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f077ed29-51b7-4fe7-8136-c65b8e7b3f15",
                column: "ConcurrencyStamp",
                value: "9be39d60-d07c-48ca-8710-084d8a761ce4");

            migrationBuilder.UpdateData(
                table: "tblTransactionTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(5916), new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "tblTransactionTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(5923), new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "tblTransactionTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(5926), new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(7035), "f9c13b05-4747-43e9-9b3c-926be15e28f0", "AQAAAAEAACcQAAAAEGtNFTCG2PexQQMdAoqj3QvSW14QE76fq0zcNvb57x/o1gkvCdBsQhqzgJTavUaDzg==", "965166fb-61cb-4d12-9f93-5043a43d38f9", new DateTime(2025, 7, 30, 20, 9, 6, 664, DateTimeKind.Utc).AddTicks(7034) });

            migrationBuilder.CreateIndex(
                name: "IX_tblCellGroupHosts_CellGroupId",
                table: "tblCellGroupHosts",
                column: "CellGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCellGroupHosts_MemberId",
                table: "tblCellGroupHosts",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_tblChurchSettings_BranchId",
                table: "tblChurchSettings",
                column: "BranchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCellGroupHosts");

            migrationBuilder.DropTable(
                name: "tblChurchSettings");

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(2289), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(2299), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(2304), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(2307), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(2310), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(3372), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(3375), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(3378), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(3380), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(3383), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(3385), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(3387), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4139), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4150), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4152), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4162), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4164), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4166), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4297), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4301), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4303), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4305), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4307), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4310), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4312), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4314), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4316), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4318), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4955), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4958), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4960), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4962), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4964), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4966), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4968), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4969), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8401), new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8406), new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8408), new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8411), new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8415), new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8417), new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8419), new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8418) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4451), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4454), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4467), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4469), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4471), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4473), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4476), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4478), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4480), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4574), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4481) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4578), new DateTime(2025, 7, 30, 10, 42, 19, 419, DateTimeKind.Utc).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "0a8baeb0-7191-4731-b8f2-a8b22b5a8596",
                column: "ConcurrencyStamp",
                value: "ebeacdf2-3636-49ff-8cdb-8a24415863b2");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "575759c6-e020-4c4b-888d-24e01ba62797",
                column: "ConcurrencyStamp",
                value: "1c1465a0-0041-4231-8efe-e212c8414356");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a173a5cc-3edc-4f49-979c-f423e044b202",
                column: "ConcurrencyStamp",
                value: "a4c8d24e-5838-4965-a734-33ed7d28dda2");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a1922985-be01-4762-a2b6-32d6f4f58235",
                column: "ConcurrencyStamp",
                value: "029373ca-e28f-4be9-8b64-e30a8832a01a");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "12fd4f98-76ad-4a90-a8c9-699e9f767ba7");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f0223225-0c52-413d-b188-0868ea111427",
                column: "ConcurrencyStamp",
                value: "e46f1224-c42c-4932-aaaa-9ada9eceb878");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f077ed29-51b7-4fe7-8136-c65b8e7b3f15",
                column: "ConcurrencyStamp",
                value: "8284ea0d-47a4-4029-aa39-b6318bd3d24b");

            migrationBuilder.UpdateData(
                table: "tblTransactionTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8302), new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8296) });

            migrationBuilder.UpdateData(
                table: "tblTransactionTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8307), new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "tblTransactionTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8310), new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(9284), "8495b355-7825-42d6-a3a5-c0ed140ebb57", "AQAAAAEAACcQAAAAEMpY8POGz4mcXg0qAHT+miplSePiHiSUfDpGbNhvWAONlikHQRNmD2Cj/Gx9LzCq7g==", "651a982d-2cc7-4d62-a71c-7fcb22b7307d", new DateTime(2025, 7, 30, 10, 42, 19, 421, DateTimeKind.Utc).AddTicks(9283) });
        }
    }
}
