using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OC.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChurchProgramData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblChurchProgramSessions_ChurchProgram_ChurchProgramId",
                table: "tblChurchProgramSessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChurchProgram",
                table: "ChurchProgram");

            migrationBuilder.RenameTable(
                name: "ChurchProgram",
                newName: "tblChurchPrograms");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblChurchPrograms",
                table: "tblChurchPrograms",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6884), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6897), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6901), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6905), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6915), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6915) });

            migrationBuilder.InsertData(
                table: "tblChurchPrograms",
                columns: new[] { "Id", "ApprovalDate", "CheckerId", "Description", "IsActive", "MakerId", "Name", "RejectionDate", "SubmissionDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7937), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Sunday First Service", true, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Sunday First Service", null, new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7936) },
                    { 2L, new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7943), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Sunday Second Service", true, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Sunday Second Service", null, new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7942) },
                    { 3L, new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7945), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Sunday Youth Service", true, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Sunday Youth Service", null, new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7944) },
                    { 4L, new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7947), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Sunday Local Language Service", true, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Sunday Local Language Service", null, new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7947) },
                    { 5L, new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7949), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Mid-week Service", true, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Mid-week Service", null, new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7949) },
                    { 6L, new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7951), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "3 Days of Power conference", true, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "3 Days of Power", null, new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7951) },
                    { 7L, new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7953), "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Easter Conference", true, "8a4353dd-5496-4ffe-bfa3-db90afab6684", "Easter Conference", null, new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7953) }
                });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8594), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8604), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8606), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8622), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8623), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8625), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8751), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8754), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8757), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8759), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8760), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8762), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8765), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8767), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8770), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8773), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3559), new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3565), new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3568), new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3571), new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3573), new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3575), new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3578), new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8891), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8894), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8906), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8908), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8910), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8912), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8914), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8916), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8918), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8919), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "0a8baeb0-7191-4731-b8f2-a8b22b5a8596",
                column: "ConcurrencyStamp",
                value: "34f5a6df-eea6-4320-ba53-94fda6cc70c8");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "575759c6-e020-4c4b-888d-24e01ba62797",
                column: "ConcurrencyStamp",
                value: "8db7de9e-9224-4240-928e-7246108f87ff");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a173a5cc-3edc-4f49-979c-f423e044b202",
                column: "ConcurrencyStamp",
                value: "00409068-d52f-482d-a086-314d51f5e216");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a1922985-be01-4762-a2b6-32d6f4f58235",
                column: "ConcurrencyStamp",
                value: "7cde5505-82cc-420d-a419-663a68f1a404");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "c11b44be-749b-42d6-911d-674a953566c5");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f0223225-0c52-413d-b188-0868ea111427",
                column: "ConcurrencyStamp",
                value: "1546395a-6aaf-4ffa-a1d5-800a309553d3");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f077ed29-51b7-4fe7-8136-c65b8e7b3f15",
                column: "ConcurrencyStamp",
                value: "83a2417f-73b2-4006-8566-cfdf00a0b0ab");

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(4300), "0d9b7d92-c9cb-419c-a210-2664137d7775", "AQAAAAEAACcQAAAAEIe9LtbrYqizrv4qyCdXXdl3m3UCVo+KrIRHxP+JbayF2zvpzHAEqDFYt1Y4FukVWQ==", "3435ec5f-061a-4a48-bed1-b4f40173e807", new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(4298) });

            migrationBuilder.AddForeignKey(
                name: "FK_tblChurchProgramSessions_tblChurchPrograms_ChurchProgramId",
                table: "tblChurchProgramSessions",
                column: "ChurchProgramId",
                principalTable: "tblChurchPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblChurchProgramSessions_tblChurchPrograms_ChurchProgramId",
                table: "tblChurchProgramSessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblChurchPrograms",
                table: "tblChurchPrograms");

            migrationBuilder.DeleteData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.RenameTable(
                name: "tblChurchPrograms",
                newName: "ChurchProgram");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChurchProgram",
                table: "ChurchProgram",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_tblChurchProgramSessions_ChurchProgram_ChurchProgramId",
                table: "tblChurchProgramSessions",
                column: "ChurchProgramId",
                principalTable: "ChurchProgram",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
