using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OC.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChurchSettingsModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
