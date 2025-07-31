using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OC.Data.Migrations
{
    /// <inheritdoc />
    public partial class CoreEntitiesUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MeetingDay",
                table: "tblCellGroups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeetingTime",
                table: "tblCellGroups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 597, DateTimeKind.Utc).AddTicks(9601), new DateTime(2025, 7, 19, 17, 38, 19, 597, DateTimeKind.Utc).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 597, DateTimeKind.Utc).AddTicks(9622), new DateTime(2025, 7, 19, 17, 38, 19, 597, DateTimeKind.Utc).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 597, DateTimeKind.Utc).AddTicks(9641), new DateTime(2025, 7, 19, 17, 38, 19, 597, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 597, DateTimeKind.Utc).AddTicks(9649), new DateTime(2025, 7, 19, 17, 38, 19, 597, DateTimeKind.Utc).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 597, DateTimeKind.Utc).AddTicks(9657), new DateTime(2025, 7, 19, 17, 38, 19, 597, DateTimeKind.Utc).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(1911), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(1919), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(1925), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(1930), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(1945), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(1952), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(1957), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(3995), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4017), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4022), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4038), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4043), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4047), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4340), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4348), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4354), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4359), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4365), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4370), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4374), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4379), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4384), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4389), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(5407), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(5412), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(5417), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(5421), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(5426), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(5430), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(5434), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(5439), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(675), new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(686), new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(693), new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(698), new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(704), new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(702) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(709), new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(714), new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4669), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4676), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4693), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4698), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4704), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4709), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4714), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4719), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4724), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4729), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4734), new DateTime(2025, 7, 19, 17, 38, 19, 598, DateTimeKind.Utc).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "0a8baeb0-7191-4731-b8f2-a8b22b5a8596",
                column: "ConcurrencyStamp",
                value: "9e4d4b7d-0c90-4ddb-9370-a3a256c21f7e");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "575759c6-e020-4c4b-888d-24e01ba62797",
                column: "ConcurrencyStamp",
                value: "a3fc6e3d-036f-4a2d-8669-a0ce25e358bb");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a173a5cc-3edc-4f49-979c-f423e044b202",
                column: "ConcurrencyStamp",
                value: "5ea5a8d9-6547-40b8-b674-2b6d928eec7b");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a1922985-be01-4762-a2b6-32d6f4f58235",
                column: "ConcurrencyStamp",
                value: "b7cc288d-b66c-4081-84f8-507a9653f668");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "0324e417-d984-41a6-ac9a-275a5e71ab0d");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f0223225-0c52-413d-b188-0868ea111427",
                column: "ConcurrencyStamp",
                value: "52c89af6-e7a1-4ead-9850-5c6e84592f52");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f077ed29-51b7-4fe7-8136-c65b8e7b3f15",
                column: "ConcurrencyStamp",
                value: "9af2e69d-c9c6-49e0-9c83-dc3cda66d566");

            migrationBuilder.UpdateData(
                table: "tblTransactionTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(419), new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "tblTransactionTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(433), new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "tblTransactionTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(438), new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(2889), "b261c769-62fc-41a5-a465-25d6a9eac5e8", "AQAAAAEAACcQAAAAEHFxIDJ/ojUmVjHf8oVyo2v4fhe+gj+6/cr4Ie0nc8aOITnQgBRxpELJJWhMUz/w6g==", "563aa530-fe2e-4f95-9b29-5b9c62755e29", new DateTime(2025, 7, 19, 17, 38, 19, 612, DateTimeKind.Utc).AddTicks(2886) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MeetingDay",
                table: "tblCellGroups");

            migrationBuilder.DropColumn(
                name: "MeetingTime",
                table: "tblCellGroups");

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(8553), new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(8567), new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(8572), new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(8581), new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(8584), new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(9456), new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(9459), new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(9462), new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(9464), new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(9467), new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(9469), new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(9471), new DateTime(2024, 3, 30, 11, 59, 8, 476, DateTimeKind.Utc).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(75), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(77), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(79), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(81), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(84), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(85), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(178), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(185), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(188), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(190), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(192), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(196), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(195) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(198), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(200), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(202), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(204), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(587), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(589), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(591), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(593), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(595), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(597), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(598), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(600), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9223), new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9228), new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9230), new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9233), new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9235), new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9237), new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9239), new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(301), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(304), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(307), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(310), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(312), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(314), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(317), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(319), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(321), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(323), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(325), new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "0a8baeb0-7191-4731-b8f2-a8b22b5a8596",
                column: "ConcurrencyStamp",
                value: "91d0fd41-b032-4037-99f2-6edc33fc6e90");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "575759c6-e020-4c4b-888d-24e01ba62797",
                column: "ConcurrencyStamp",
                value: "aeaabffb-5c77-4ec0-a82c-1ff35d1f3518");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a173a5cc-3edc-4f49-979c-f423e044b202",
                column: "ConcurrencyStamp",
                value: "14cc0f2e-735e-4510-ad69-d0ab50adf8b3");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a1922985-be01-4762-a2b6-32d6f4f58235",
                column: "ConcurrencyStamp",
                value: "c49f2336-b3b7-41dc-8165-9fc40a34c697");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "4fa6351e-a7e4-47f5-b379-2bf3c7f193bc");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f0223225-0c52-413d-b188-0868ea111427",
                column: "ConcurrencyStamp",
                value: "ed909ec7-65f4-4e0c-be59-49bda8e47f7e");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f077ed29-51b7-4fe7-8136-c65b8e7b3f15",
                column: "ConcurrencyStamp",
                value: "0ab43e01-aeb4-4320-8c64-3ca864ab7bb7");

            migrationBuilder.UpdateData(
                table: "tblTransactionTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9130), new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "tblTransactionTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9136), new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "tblTransactionTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9140), new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9924), "4035a923-8dde-4187-b713-caf3cd692bfd", "AQAAAAEAACcQAAAAEPZXBPzXdQX4x+Xfd9jSiwfdGvYVlKqw9ghFQW2l1+8JNy5zpu4zv0iUEIqu+FWRIA==", "1eb4ee78-6b9d-469d-beef-11e78b13b473", new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9923) });
        }
    }
}
