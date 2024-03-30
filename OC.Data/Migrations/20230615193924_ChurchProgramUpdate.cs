using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OC.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChurchProgramUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "tblChurchProgramSessions");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "tblRegionLeaderships",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "IsRecurring",
                table: "tblPledges",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecurringReminderDay",
                table: "tblPledges",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "tblChurchProgramSessionVistors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "tblChurchProgramSessionVistors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateToVisit",
                table: "tblChurchProgramSessionVistors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateVisited",
                table: "tblChurchProgramSessionVistors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "tblChurchProgramSessionVistors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "tblChurchProgramSessionVistors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "tblChurchProgramSessionVistors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "tblChurchProgramSessions",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTimeTime",
                table: "tblChurchProgramSessions",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<long>(
                name: "ChurchProgramId",
                table: "tblChurchProgramSessions",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalBoys",
                table: "tblChurchProgramSessionAttendances",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalGirls",
                table: "tblChurchProgramSessionAttendances",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalMen",
                table: "tblChurchProgramSessionAttendances",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalWomen",
                table: "tblChurchProgramSessionAttendances",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalYouthMen",
                table: "tblChurchProgramSessionAttendances",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalYouthWomen",
                table: "tblChurchProgramSessionAttendances",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "tblCellLeaderships",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.CreateTable(
                name: "ChurchProgram",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_ChurchProgram", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(3886), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(3879) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(3902), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(3907), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(3913), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(3912) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(3919), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5470), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5473), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5476), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5478), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5480), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5482), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5605), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5609), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5618), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5620), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5636), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5638), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5640), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5641), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5645), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5648), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 673, DateTimeKind.Utc).AddTicks(2534), new DateTime(2023, 6, 15, 21, 39, 23, 673, DateTimeKind.Utc).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 673, DateTimeKind.Utc).AddTicks(2540), new DateTime(2023, 6, 15, 21, 39, 23, 673, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 673, DateTimeKind.Utc).AddTicks(2543), new DateTime(2023, 6, 15, 21, 39, 23, 673, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 673, DateTimeKind.Utc).AddTicks(2545), new DateTime(2023, 6, 15, 21, 39, 23, 673, DateTimeKind.Utc).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 673, DateTimeKind.Utc).AddTicks(2547), new DateTime(2023, 6, 15, 21, 39, 23, 673, DateTimeKind.Utc).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 673, DateTimeKind.Utc).AddTicks(2549), new DateTime(2023, 6, 15, 21, 39, 23, 673, DateTimeKind.Utc).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 673, DateTimeKind.Utc).AddTicks(2551), new DateTime(2023, 6, 15, 21, 39, 23, 673, DateTimeKind.Utc).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5785), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5784) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5788), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5791), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5793), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5795), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5799), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5801), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5803), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5805), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5810), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5812), new DateTime(2023, 6, 15, 21, 39, 23, 670, DateTimeKind.Utc).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "0a8baeb0-7191-4731-b8f2-a8b22b5a8596",
                column: "ConcurrencyStamp",
                value: "a48238e1-c831-4ebd-b4e0-df6ea4267d5f");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "575759c6-e020-4c4b-888d-24e01ba62797",
                column: "ConcurrencyStamp",
                value: "97e7c52f-7715-4cf3-933d-860acaa0ff49");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a173a5cc-3edc-4f49-979c-f423e044b202",
                column: "ConcurrencyStamp",
                value: "cf356ed4-8e20-40db-929d-f5650f0a588f");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a1922985-be01-4762-a2b6-32d6f4f58235",
                column: "ConcurrencyStamp",
                value: "c8bc96f1-d14f-4014-bb87-6568b84f6847");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "8ffd2c64-224c-4d7a-a78a-2b27d2e05a17");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f0223225-0c52-413d-b188-0868ea111427",
                column: "ConcurrencyStamp",
                value: "d5135a12-0802-483b-a45b-61a2d84ce606");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f077ed29-51b7-4fe7-8136-c65b8e7b3f15",
                column: "ConcurrencyStamp",
                value: "07b2ff33-2b34-49b6-87c0-e4bb2db4adf8");

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 39, 23, 673, DateTimeKind.Utc).AddTicks(3457), "5483296b-ce73-4560-bad9-9a748ba63f37", "AQAAAAEAACcQAAAAENuUpPbCt9cpFMseCOPJk0/WOIcaMVoT7xvnkkgrK6U0QGDZ4jJjub/8DFRMjZkaEw==", "2acb64b4-c19d-4adc-a8f7-3b8e37bfb90b", new DateTime(2023, 6, 15, 21, 39, 23, 673, DateTimeKind.Utc).AddTicks(3456) });

            migrationBuilder.CreateIndex(
                name: "IX_tblChurchProgramSessions_BranchId",
                table: "tblChurchProgramSessions",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_tblChurchProgramSessions_ChurchProgramId",
                table: "tblChurchProgramSessions",
                column: "ChurchProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblChurchProgramSessions_ChurchProgram_ChurchProgramId",
                table: "tblChurchProgramSessions",
                column: "ChurchProgramId",
                principalTable: "ChurchProgram",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblChurchProgramSessions_tblBranches_BranchId",
                table: "tblChurchProgramSessions",
                column: "BranchId",
                principalTable: "tblBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblChurchProgramSessions_ChurchProgram_ChurchProgramId",
                table: "tblChurchProgramSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_tblChurchProgramSessions_tblBranches_BranchId",
                table: "tblChurchProgramSessions");

            migrationBuilder.DropTable(
                name: "ChurchProgram");

            migrationBuilder.DropIndex(
                name: "IX_tblChurchProgramSessions_BranchId",
                table: "tblChurchProgramSessions");

            migrationBuilder.DropIndex(
                name: "IX_tblChurchProgramSessions_ChurchProgramId",
                table: "tblChurchProgramSessions");

            migrationBuilder.DropColumn(
                name: "IsRecurring",
                table: "tblPledges");

            migrationBuilder.DropColumn(
                name: "RecurringReminderDay",
                table: "tblPledges");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "tblChurchProgramSessionVistors");

            migrationBuilder.DropColumn(
                name: "Comments",
                table: "tblChurchProgramSessionVistors");

            migrationBuilder.DropColumn(
                name: "DateToVisit",
                table: "tblChurchProgramSessionVistors");

            migrationBuilder.DropColumn(
                name: "DateVisited",
                table: "tblChurchProgramSessionVistors");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "tblChurchProgramSessionVistors");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "tblChurchProgramSessionVistors");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "tblChurchProgramSessionVistors");

            migrationBuilder.DropColumn(
                name: "ChurchProgramId",
                table: "tblChurchProgramSessions");

            migrationBuilder.DropColumn(
                name: "TotalBoys",
                table: "tblChurchProgramSessionAttendances");

            migrationBuilder.DropColumn(
                name: "TotalGirls",
                table: "tblChurchProgramSessionAttendances");

            migrationBuilder.DropColumn(
                name: "TotalMen",
                table: "tblChurchProgramSessionAttendances");

            migrationBuilder.DropColumn(
                name: "TotalWomen",
                table: "tblChurchProgramSessionAttendances");

            migrationBuilder.DropColumn(
                name: "TotalYouthMen",
                table: "tblChurchProgramSessionAttendances");

            migrationBuilder.DropColumn(
                name: "TotalYouthWomen",
                table: "tblChurchProgramSessionAttendances");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "tblRegionLeaderships",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "tblChurchProgramSessions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTimeTime",
                table: "tblChurchProgramSessions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "tblChurchProgramSessions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "tblCellLeaderships",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5400), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5413), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5417), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5420), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5422), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6844), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6848), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6850), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6852), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6854), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6855), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6974), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6977), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6984), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6986), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6995), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6997), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6999), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7000), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7002), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7004), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6344), new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6350), new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6353), new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6355), new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6357), new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6359), new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6361), new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7146), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7149), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7151), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7154), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7155), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7157), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7159), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7161), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7163), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7168), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7170), new DateTime(2023, 6, 3, 3, 18, 32, 805, DateTimeKind.Utc).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "0a8baeb0-7191-4731-b8f2-a8b22b5a8596",
                column: "ConcurrencyStamp",
                value: "2e0934ba-c952-489b-b1ab-0d45b3c45876");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "575759c6-e020-4c4b-888d-24e01ba62797",
                column: "ConcurrencyStamp",
                value: "a0ddf440-0a71-45c2-8130-87d708759aad");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a173a5cc-3edc-4f49-979c-f423e044b202",
                column: "ConcurrencyStamp",
                value: "e2acfcaf-0f3a-42ec-b985-9d37ec0d4261");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a1922985-be01-4762-a2b6-32d6f4f58235",
                column: "ConcurrencyStamp",
                value: "a155248f-ed28-414b-ba63-4fd3054f6dad");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "ceab96dc-b68c-4654-bc0f-848b9cb55357");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f0223225-0c52-413d-b188-0868ea111427",
                column: "ConcurrencyStamp",
                value: "b9611511-8010-4f77-b2e6-b6ed03401ace");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f077ed29-51b7-4fe7-8136-c65b8e7b3f15",
                column: "ConcurrencyStamp",
                value: "41d17428-28af-4000-92ef-8c48a949cf4a");

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(7004), "29c3ec8a-e696-4baf-b78d-a1b641309f16", "AQAAAAEAACcQAAAAEDZdu5jfy1i0ecZHra5VQdO0sPWEvhmuc9kGU0tw1vPzqc3CJOJS3/eTdiPmk08pmg==", "4b3f282c-fc50-4dc7-a75b-c5154ae03512", new DateTime(2023, 6, 3, 3, 18, 32, 807, DateTimeKind.Utc).AddTicks(7001) });
        }
    }
}
