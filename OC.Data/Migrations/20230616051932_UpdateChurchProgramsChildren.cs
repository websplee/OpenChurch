using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OC.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateChurchProgramsChildren : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FollowedUp",
                table: "tblChurchProgramSessionVistors",
                type: "bit",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FollowedUp",
                table: "tblChurchProgramSessionVistors");

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(3494), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(3503), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(3507), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(3510), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(3512), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(4379), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(4383), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(4385), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(4387), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(4389), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(4391), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(4392), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5065), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5068), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5070), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5071), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5073), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5075), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5156), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5159), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5162), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5164), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5165), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5167), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5170), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5176), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5178), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5180), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 239, DateTimeKind.Utc).AddTicks(2410), new DateTime(2023, 6, 15, 22, 27, 3, 239, DateTimeKind.Utc).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 239, DateTimeKind.Utc).AddTicks(2416), new DateTime(2023, 6, 15, 22, 27, 3, 239, DateTimeKind.Utc).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 239, DateTimeKind.Utc).AddTicks(2418), new DateTime(2023, 6, 15, 22, 27, 3, 239, DateTimeKind.Utc).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 239, DateTimeKind.Utc).AddTicks(2420), new DateTime(2023, 6, 15, 22, 27, 3, 239, DateTimeKind.Utc).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 239, DateTimeKind.Utc).AddTicks(2422), new DateTime(2023, 6, 15, 22, 27, 3, 239, DateTimeKind.Utc).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 239, DateTimeKind.Utc).AddTicks(2424), new DateTime(2023, 6, 15, 22, 27, 3, 239, DateTimeKind.Utc).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 239, DateTimeKind.Utc).AddTicks(2426), new DateTime(2023, 6, 15, 22, 27, 3, 239, DateTimeKind.Utc).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5268), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5271), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5273), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5275), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5277), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5281), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5283), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5285), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5287), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5288), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5290), new DateTime(2023, 6, 15, 22, 27, 3, 237, DateTimeKind.Utc).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "0a8baeb0-7191-4731-b8f2-a8b22b5a8596",
                column: "ConcurrencyStamp",
                value: "8cdd4821-bb14-424c-aa9a-44ddc9e73705");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "575759c6-e020-4c4b-888d-24e01ba62797",
                column: "ConcurrencyStamp",
                value: "ba42bdf1-5098-495f-8fea-8b7a7ff3e06b");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a173a5cc-3edc-4f49-979c-f423e044b202",
                column: "ConcurrencyStamp",
                value: "ffb839ed-7c3e-49a5-800c-0996d156097f");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a1922985-be01-4762-a2b6-32d6f4f58235",
                column: "ConcurrencyStamp",
                value: "edcc83d2-db8b-4e18-a736-4675fee8dbf3");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "f50e3c85-86ed-4023-b90a-c0c60cd137df");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f0223225-0c52-413d-b188-0868ea111427",
                column: "ConcurrencyStamp",
                value: "856ad3b9-d6b4-4d68-9db7-7adc817a5eba");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f077ed29-51b7-4fe7-8136-c65b8e7b3f15",
                column: "ConcurrencyStamp",
                value: "b16dcb61-d655-483b-ba2c-dd9b1b960a65");

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 27, 3, 239, DateTimeKind.Utc).AddTicks(3058), "46e3d0cf-5f64-4442-831b-017db4302c5a", "AQAAAAEAACcQAAAAEKbi3hZb8MMMw/+m814Y/ON0s7qQMW5mePoq63S/+wDIwZezQIn/0i7wktl949AjZQ==", "9280aef0-4c92-4ccb-a076-7525c6873cd5", new DateTime(2023, 6, 15, 22, 27, 3, 239, DateTimeKind.Utc).AddTicks(3057) });
        }
    }
}
