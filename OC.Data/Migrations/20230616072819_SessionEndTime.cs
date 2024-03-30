using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OC.Data.Migrations
{
    /// <inheritdoc />
    public partial class SessionEndTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EndTimeTime",
                table: "tblChurchProgramSessions",
                newName: "EndTime");

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6134), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6141), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6144), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6147), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6149), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6932), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6935), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6937), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6939), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6941), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6943), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6945), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7566), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7571), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7573), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7572) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7585), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7587), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7588), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7696), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7699), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7702), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7704), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7706), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7707), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7709), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7712), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7714), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7716), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 889, DateTimeKind.Utc).AddTicks(3664), new DateTime(2023, 6, 16, 9, 28, 18, 889, DateTimeKind.Utc).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 889, DateTimeKind.Utc).AddTicks(3668), new DateTime(2023, 6, 16, 9, 28, 18, 889, DateTimeKind.Utc).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 889, DateTimeKind.Utc).AddTicks(3670), new DateTime(2023, 6, 16, 9, 28, 18, 889, DateTimeKind.Utc).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 889, DateTimeKind.Utc).AddTicks(3671), new DateTime(2023, 6, 16, 9, 28, 18, 889, DateTimeKind.Utc).AddTicks(3671) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 889, DateTimeKind.Utc).AddTicks(3679), new DateTime(2023, 6, 16, 9, 28, 18, 889, DateTimeKind.Utc).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 889, DateTimeKind.Utc).AddTicks(3680), new DateTime(2023, 6, 16, 9, 28, 18, 889, DateTimeKind.Utc).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 889, DateTimeKind.Utc).AddTicks(3682), new DateTime(2023, 6, 16, 9, 28, 18, 889, DateTimeKind.Utc).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7815), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7826), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7832), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7834), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7836), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7838), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7840), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7842), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7843), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7845), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7847), new DateTime(2023, 6, 16, 9, 28, 18, 887, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "0a8baeb0-7191-4731-b8f2-a8b22b5a8596",
                column: "ConcurrencyStamp",
                value: "4830dd71-1036-4904-a61e-1c6aab3c09b2");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "575759c6-e020-4c4b-888d-24e01ba62797",
                column: "ConcurrencyStamp",
                value: "c191e73c-262c-4b87-990e-8a713f8230c0");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a173a5cc-3edc-4f49-979c-f423e044b202",
                column: "ConcurrencyStamp",
                value: "c6250572-6b6b-4e48-b072-f7a895125d75");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a1922985-be01-4762-a2b6-32d6f4f58235",
                column: "ConcurrencyStamp",
                value: "fa0ed5f1-ebcc-46c5-a360-509efcd0b385");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "d2ee3525-2c00-4245-8bb9-8688d44d0e23");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f0223225-0c52-413d-b188-0868ea111427",
                column: "ConcurrencyStamp",
                value: "6e2ffbfc-d262-4696-a56b-adb4846c55aa");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f077ed29-51b7-4fe7-8136-c65b8e7b3f15",
                column: "ConcurrencyStamp",
                value: "8222014f-7a79-45e9-aaaf-76a987803267");

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 9, 28, 18, 889, DateTimeKind.Utc).AddTicks(4198), "b49d0092-1893-4ca5-8a1c-286ada094d3a", "AQAAAAEAACcQAAAAEH/DuKkAsu+t6K6/IQPQ4U9JY+FtnsORdxPHJNCRBa3kGukqL6wg2YNSH/1i3xRXkg==", "a7b52bfc-c122-40d7-a221-d3a109aa173f", new DateTime(2023, 6, 16, 9, 28, 18, 889, DateTimeKind.Utc).AddTicks(4197) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "tblChurchProgramSessions",
                newName: "EndTimeTime");

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(248), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(255), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(258), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(261), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(263), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1080), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1079) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1083), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1085), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1087), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1089), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1089) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1091), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1093), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1720), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1727), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1729), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1731), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1733), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1734), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1821), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1824), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1826), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1828), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1830), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1832), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1836), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1839), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1841), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1843), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 884, DateTimeKind.Utc).AddTicks(7393), new DateTime(2023, 6, 16, 7, 19, 31, 884, DateTimeKind.Utc).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 884, DateTimeKind.Utc).AddTicks(7397), new DateTime(2023, 6, 16, 7, 19, 31, 884, DateTimeKind.Utc).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 884, DateTimeKind.Utc).AddTicks(7400), new DateTime(2023, 6, 16, 7, 19, 31, 884, DateTimeKind.Utc).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 884, DateTimeKind.Utc).AddTicks(7405), new DateTime(2023, 6, 16, 7, 19, 31, 884, DateTimeKind.Utc).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 884, DateTimeKind.Utc).AddTicks(7410), new DateTime(2023, 6, 16, 7, 19, 31, 884, DateTimeKind.Utc).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 884, DateTimeKind.Utc).AddTicks(7413), new DateTime(2023, 6, 16, 7, 19, 31, 884, DateTimeKind.Utc).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 884, DateTimeKind.Utc).AddTicks(7416), new DateTime(2023, 6, 16, 7, 19, 31, 884, DateTimeKind.Utc).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1929), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1931), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1933), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1935), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1937), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1939), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1942), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1945), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1947), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1950), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1952), new DateTime(2023, 6, 16, 7, 19, 31, 883, DateTimeKind.Utc).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "0a8baeb0-7191-4731-b8f2-a8b22b5a8596",
                column: "ConcurrencyStamp",
                value: "8ce08ab6-f8cf-4b82-a77d-a282a7140955");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "575759c6-e020-4c4b-888d-24e01ba62797",
                column: "ConcurrencyStamp",
                value: "ed356cc7-e97f-41a7-b59a-774112a3d7c3");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a173a5cc-3edc-4f49-979c-f423e044b202",
                column: "ConcurrencyStamp",
                value: "09d98084-ed82-4629-83ce-04917e194cbe");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a1922985-be01-4762-a2b6-32d6f4f58235",
                column: "ConcurrencyStamp",
                value: "4d4baa54-f3b3-41a6-8097-d99e8f2a0615");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "bc625ba0-f688-4f12-83d0-22517d2d97fb");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f0223225-0c52-413d-b188-0868ea111427",
                column: "ConcurrencyStamp",
                value: "85cecdc6-9a21-4933-a1b6-459bc562aff9");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f077ed29-51b7-4fe7-8136-c65b8e7b3f15",
                column: "ConcurrencyStamp",
                value: "64a2b97c-fbd5-4d59-9630-19e0c7bb3242");

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 16, 7, 19, 31, 884, DateTimeKind.Utc).AddTicks(7923), "6f9cddec-fa1a-4922-9007-64100c479c64", "AQAAAAEAACcQAAAAEMnpNBXY3FU6kckN077KyqOLiq3Q1C59/rWX9Tnk9LFb210qvYL/G2+9fbCWwAfcHw==", "0f33df48-50b0-4b67-b314-3e1d6ad6aed9", new DateTime(2023, 6, 16, 7, 19, 31, 884, DateTimeKind.Utc).AddTicks(7922) });
        }
    }
}
