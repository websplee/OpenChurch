using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OC.Data.Migrations
{
    /// <inheritdoc />
    public partial class BranchNullableValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 879, DateTimeKind.Utc).AddTicks(9193), new DateTime(2024, 2, 22, 19, 17, 12, 879, DateTimeKind.Utc).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 879, DateTimeKind.Utc).AddTicks(9206), new DateTime(2024, 2, 22, 19, 17, 12, 879, DateTimeKind.Utc).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 879, DateTimeKind.Utc).AddTicks(9212), new DateTime(2024, 2, 22, 19, 17, 12, 879, DateTimeKind.Utc).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 879, DateTimeKind.Utc).AddTicks(9216), new DateTime(2024, 2, 22, 19, 17, 12, 879, DateTimeKind.Utc).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 879, DateTimeKind.Utc).AddTicks(9220), new DateTime(2024, 2, 22, 19, 17, 12, 879, DateTimeKind.Utc).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(689), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(693), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(698), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(701), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(704), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(707), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(710), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1721), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1730), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1733), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1744), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1752), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1757), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1925), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1931), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1937), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1940), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1943), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1947), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1950), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1955), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1958), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1961), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 883, DateTimeKind.Utc).AddTicks(1044), new DateTime(2024, 2, 22, 19, 17, 12, 883, DateTimeKind.Utc).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 883, DateTimeKind.Utc).AddTicks(1053), new DateTime(2024, 2, 22, 19, 17, 12, 883, DateTimeKind.Utc).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 883, DateTimeKind.Utc).AddTicks(1058), new DateTime(2024, 2, 22, 19, 17, 12, 883, DateTimeKind.Utc).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 883, DateTimeKind.Utc).AddTicks(1061), new DateTime(2024, 2, 22, 19, 17, 12, 883, DateTimeKind.Utc).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 883, DateTimeKind.Utc).AddTicks(1065), new DateTime(2024, 2, 22, 19, 17, 12, 883, DateTimeKind.Utc).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 883, DateTimeKind.Utc).AddTicks(1068), new DateTime(2024, 2, 22, 19, 17, 12, 883, DateTimeKind.Utc).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 883, DateTimeKind.Utc).AddTicks(1071), new DateTime(2024, 2, 22, 19, 17, 12, 883, DateTimeKind.Utc).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2130), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2135), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2142), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2145), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2148), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2151), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2154), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2157), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2160), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2169), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2174), new DateTime(2024, 2, 22, 19, 17, 12, 880, DateTimeKind.Utc).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "0a8baeb0-7191-4731-b8f2-a8b22b5a8596",
                column: "ConcurrencyStamp",
                value: "c4341e64-2cac-4fae-8399-98652ef6d9e9");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "575759c6-e020-4c4b-888d-24e01ba62797",
                column: "ConcurrencyStamp",
                value: "62770f6f-ebef-4367-8fa5-b4f195d1ea31");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a173a5cc-3edc-4f49-979c-f423e044b202",
                column: "ConcurrencyStamp",
                value: "c3a75704-2852-4370-91ef-877d5d826cec");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a1922985-be01-4762-a2b6-32d6f4f58235",
                column: "ConcurrencyStamp",
                value: "77668e01-73ea-4b16-9c29-95b8623ebe9e");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "675981fd-9f94-45fb-b41a-d361cc9c23d9");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f0223225-0c52-413d-b188-0868ea111427",
                column: "ConcurrencyStamp",
                value: "8e6e24c8-83f7-4b10-863b-04d426d9bd2a");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f077ed29-51b7-4fe7-8136-c65b8e7b3f15",
                column: "ConcurrencyStamp",
                value: "7e6df0a1-cf33-402a-97c9-23766cebde89");

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 883, DateTimeKind.Utc).AddTicks(2434), "a61e64ba-85f5-43fb-b6bb-81dfe316ddce", "AQAAAAEAACcQAAAAEP5Qp0aQydrKlIrGbCI8BUGLo2epWRxCG+8ybQKzGpkpTOD02DoifvahJ56JE0RYxQ==", "e9695ec2-7f71-4704-ba71-f4a0dccf93f0", new DateTime(2024, 2, 22, 19, 17, 12, 883, DateTimeKind.Utc).AddTicks(2432) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(1611), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(1629), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(1637), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(1642), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(1648), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(3074), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(3079), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(3083), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(3087), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(3090), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(3093), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(3096), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4083), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4092), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4102), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4117), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4120), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4122), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4279), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4284), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4288), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4291), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4294), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4334), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4337), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4340), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4343), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4346), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 921, DateTimeKind.Utc).AddTicks(7503), new DateTime(2024, 2, 19, 9, 53, 37, 921, DateTimeKind.Utc).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 921, DateTimeKind.Utc).AddTicks(7512), new DateTime(2024, 2, 19, 9, 53, 37, 921, DateTimeKind.Utc).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 921, DateTimeKind.Utc).AddTicks(7517), new DateTime(2024, 2, 19, 9, 53, 37, 921, DateTimeKind.Utc).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 921, DateTimeKind.Utc).AddTicks(7520), new DateTime(2024, 2, 19, 9, 53, 37, 921, DateTimeKind.Utc).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 921, DateTimeKind.Utc).AddTicks(7523), new DateTime(2024, 2, 19, 9, 53, 37, 921, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 921, DateTimeKind.Utc).AddTicks(7527), new DateTime(2024, 2, 19, 9, 53, 37, 921, DateTimeKind.Utc).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 921, DateTimeKind.Utc).AddTicks(7530), new DateTime(2024, 2, 19, 9, 53, 37, 921, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4534), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4540), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4548), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4552), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4557), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4561), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4565), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4568), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4572), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4577), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4581), new DateTime(2024, 2, 19, 9, 53, 37, 918, DateTimeKind.Utc).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "0a8baeb0-7191-4731-b8f2-a8b22b5a8596",
                column: "ConcurrencyStamp",
                value: "8718dc6e-e98c-47fc-bf8a-04ac61bec218");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "575759c6-e020-4c4b-888d-24e01ba62797",
                column: "ConcurrencyStamp",
                value: "82da13e0-3e29-4d1c-a011-424062d7ff9c");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a173a5cc-3edc-4f49-979c-f423e044b202",
                column: "ConcurrencyStamp",
                value: "f3c0e592-b150-4e18-8842-5b2da8f483bb");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a1922985-be01-4762-a2b6-32d6f4f58235",
                column: "ConcurrencyStamp",
                value: "ceadeac0-fcd0-4499-a393-1a9e50fb53ac");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "3b351283-108e-49d2-92d4-459c2c29fab4");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f0223225-0c52-413d-b188-0868ea111427",
                column: "ConcurrencyStamp",
                value: "65f62ce2-0b34-4782-9c59-326d829c192f");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f077ed29-51b7-4fe7-8136-c65b8e7b3f15",
                column: "ConcurrencyStamp",
                value: "15292417-ad68-4542-b266-e813d9d656b9");

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 19, 9, 53, 37, 921, DateTimeKind.Utc).AddTicks(8515), "81de13e5-3717-430e-b134-56b4d7edf329", "AQAAAAEAACcQAAAAEFzU7NB5tLAs0Wgh3ruOZcYhC98vmJPWR4aS7DD6ZK3RdyfYzP0X2Z3teBFthWUu+A==", "4bcbf254-99c6-401a-a675-e1226780df1d", new DateTime(2024, 2, 19, 9, 53, 37, 921, DateTimeKind.Utc).AddTicks(8513) });
        }
    }
}
