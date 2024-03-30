using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OC.Data.Migrations
{
    /// <inheritdoc />
    public partial class CountryContinentNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(4477), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(4486), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(4490), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(4494), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(4497), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(4496) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(5476), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(5479), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(5482), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(5484), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(5484) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(5487), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(5489), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(5491), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6154), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6160), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6163), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6162) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6171), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6173), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6180), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6293), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6297), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6296) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6300), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6302), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6304), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6307), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6310), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6313), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6315), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6318), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 266, DateTimeKind.Utc).AddTicks(7450), new DateTime(2024, 1, 28, 12, 56, 7, 266, DateTimeKind.Utc).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 266, DateTimeKind.Utc).AddTicks(7456), new DateTime(2024, 1, 28, 12, 56, 7, 266, DateTimeKind.Utc).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 266, DateTimeKind.Utc).AddTicks(7459), new DateTime(2024, 1, 28, 12, 56, 7, 266, DateTimeKind.Utc).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 266, DateTimeKind.Utc).AddTicks(7461), new DateTime(2024, 1, 28, 12, 56, 7, 266, DateTimeKind.Utc).AddTicks(7461) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 266, DateTimeKind.Utc).AddTicks(7463), new DateTime(2024, 1, 28, 12, 56, 7, 266, DateTimeKind.Utc).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 266, DateTimeKind.Utc).AddTicks(7465), new DateTime(2024, 1, 28, 12, 56, 7, 266, DateTimeKind.Utc).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 266, DateTimeKind.Utc).AddTicks(7468), new DateTime(2024, 1, 28, 12, 56, 7, 266, DateTimeKind.Utc).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6432), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6436), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6441), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6443), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6445), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6445) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6447), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6451), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6454), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6456), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6458), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6460), new DateTime(2024, 1, 28, 12, 56, 7, 264, DateTimeKind.Utc).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "0a8baeb0-7191-4731-b8f2-a8b22b5a8596",
                column: "ConcurrencyStamp",
                value: "f4fb3ae1-c396-4584-8335-7a17a45d7c59");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "575759c6-e020-4c4b-888d-24e01ba62797",
                column: "ConcurrencyStamp",
                value: "23c93964-53e5-4b7b-93ce-94a4cc3a9010");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a173a5cc-3edc-4f49-979c-f423e044b202",
                column: "ConcurrencyStamp",
                value: "b6c164eb-d3e2-40f0-b8f0-80eeb33183d9");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a1922985-be01-4762-a2b6-32d6f4f58235",
                column: "ConcurrencyStamp",
                value: "5cad14b0-904a-4589-a03d-377736da6db4");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "bc2e0697-befc-4f14-89e9-b64c2bab698f");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f0223225-0c52-413d-b188-0868ea111427",
                column: "ConcurrencyStamp",
                value: "8bf7e73e-0380-433a-8711-9c5a2c1694cf");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f077ed29-51b7-4fe7-8136-c65b8e7b3f15",
                column: "ConcurrencyStamp",
                value: "1bcd658d-45a8-4594-b924-ac75c83b3640");

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 266, DateTimeKind.Utc).AddTicks(8167), "5bc11dc6-b7d6-41e3-843b-b20b8b676382", "AQAAAAEAACcQAAAAEJQygK4MQEpgLPpj1So9Y1VoMky6wnOerA0+XpTRjNLRvqDlLBGAloCHuJrmmmEX+A==", "08d3673d-66b7-4183-830a-07ff70bd3344", new DateTime(2024, 1, 28, 12, 56, 7, 266, DateTimeKind.Utc).AddTicks(8166) });
        }
    }
}
