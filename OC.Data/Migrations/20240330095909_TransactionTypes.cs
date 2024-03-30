using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OC.Data.Migrations
{
    /// <inheritdoc />
    public partial class TransactionTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EducationLevel",
                table: "tblMembers");

            migrationBuilder.AddColumn<long>(
                name: "EducationLevelId",
                table: "tblMembers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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

            migrationBuilder.InsertData(
                table: "tblEducationLevels",
                columns: new[] { "Id", "ApprovalDate", "CheckerId", "IsActive", "MakerId", "Name", "RejectionDate", "SubmissionDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(587), "8a4353dd-5496-4ffe-bfa3-db90afab6684", null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "None", null, new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(586) },
                    { 2L, new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(589), "8a4353dd-5496-4ffe-bfa3-db90afab6684", null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Doctorate (PhD)", null, new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(589) },
                    { 3L, new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(591), "8a4353dd-5496-4ffe-bfa3-db90afab6684", null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Masters", null, new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(591) },
                    { 4L, new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(593), "8a4353dd-5496-4ffe-bfa3-db90afab6684", null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Degree", null, new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(592) },
                    { 5L, new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(595), "8a4353dd-5496-4ffe-bfa3-db90afab6684", null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Diploma", null, new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(594) },
                    { 6L, new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(597), "8a4353dd-5496-4ffe-bfa3-db90afab6684", null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Certificate", null, new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(596) },
                    { 7L, new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(598), "8a4353dd-5496-4ffe-bfa3-db90afab6684", null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Secondary Ed.", null, new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(598) },
                    { 8L, new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(600), "8a4353dd-5496-4ffe-bfa3-db90afab6684", null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Primary Ed.", null, new DateTime(2024, 3, 30, 11, 59, 8, 477, DateTimeKind.Utc).AddTicks(600) }
                });

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

            migrationBuilder.InsertData(
                table: "tblTransactionTypes",
                columns: new[] { "Id", "ApprovalDate", "CheckerId", "IsActive", "MakerId", "Name", "RejectionDate", "SubmissionDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9130), "8a4353dd-5496-4ffe-bfa3-db90afab6684", null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Cash", null, new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9127) },
                    { 2L, new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9136), "8a4353dd-5496-4ffe-bfa3-db90afab6684", null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Mobile Money", null, new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9134) },
                    { 3L, new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9140), "8a4353dd-5496-4ffe-bfa3-db90afab6684", null, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Card", null, new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9139) }
                });

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9924), "4035a923-8dde-4187-b713-caf3cd692bfd", "AQAAAAEAACcQAAAAEPZXBPzXdQX4x+Xfd9jSiwfdGvYVlKqw9ghFQW2l1+8JNy5zpu4zv0iUEIqu+FWRIA==", "1eb4ee78-6b9d-469d-beef-11e78b13b473", new DateTime(2024, 3, 30, 11, 59, 8, 478, DateTimeKind.Utc).AddTicks(9923) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "tblEducationLevels",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "tblTransactionTypes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "tblTransactionTypes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "tblTransactionTypes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DropColumn(
                name: "EducationLevelId",
                table: "tblMembers");

            migrationBuilder.AddColumn<string>(
                name: "EducationLevel",
                table: "tblMembers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2439), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2447), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2451), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2454), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2456), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3406), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3410), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3412), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3415), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3417), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3419), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3421), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3972), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3974), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3976), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3978), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3980), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3981), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4065), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4068), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4070), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4072), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4072) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4074), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4073) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4076), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4078), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4080), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4079) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4082), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4083), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(202), new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(207), new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(209), new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(211), new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(213), new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(215), new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(217), new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4169), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4171), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4174), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4176), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4178), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4179), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4181), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4183), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4185), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4187), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4188), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "0a8baeb0-7191-4731-b8f2-a8b22b5a8596",
                column: "ConcurrencyStamp",
                value: "e76d7c3c-23c1-4c72-93b1-53f6088df559");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "575759c6-e020-4c4b-888d-24e01ba62797",
                column: "ConcurrencyStamp",
                value: "2e55b085-b44b-4feb-8bb2-c9d34d66a58e");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a173a5cc-3edc-4f49-979c-f423e044b202",
                column: "ConcurrencyStamp",
                value: "009714a0-dfda-4953-af94-71be6ee786e8");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a1922985-be01-4762-a2b6-32d6f4f58235",
                column: "ConcurrencyStamp",
                value: "d14d5251-902a-4263-8870-f7fe603330ed");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "8d6f00e5-9739-4ba0-99e7-81cf2c822cd7");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f0223225-0c52-413d-b188-0868ea111427",
                column: "ConcurrencyStamp",
                value: "860c6196-1d6c-45e5-aaa4-ed08f9c27404");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f077ed29-51b7-4fe7-8136-c65b8e7b3f15",
                column: "ConcurrencyStamp",
                value: "ff22bbaa-d7d7-46bf-afeb-a47f3356a6fe");

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(700), "5530a179-650d-4b0f-8bb1-e5833fd4fa19", "AQAAAAEAACcQAAAAELjdAgKsirzUE/pQ4rsdlVas42Do9rbc1p363k0TMaSr9hULiuhDHOmiUcxr0eKI5Q==", "6992ffaf-0211-49bb-a13a-8d3a7c22ec40", new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(699) });
        }
    }
}
