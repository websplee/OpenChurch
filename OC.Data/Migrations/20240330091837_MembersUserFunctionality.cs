using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OC.Data.Migrations
{
    /// <inheritdoc />
    public partial class MembersUserFunctionality : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "0a8baeb0-7191-4731-b8f2-a8b22b5a8596");

            migrationBuilder.DeleteData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "575759c6-e020-4c4b-888d-24e01ba62797");

            migrationBuilder.DeleteData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a173a5cc-3edc-4f49-979c-f423e044b202");

            migrationBuilder.DeleteData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a1922985-be01-4762-a2b6-32d6f4f58235");

            migrationBuilder.DeleteData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f0223225-0c52-413d-b188-0868ea111427");

            migrationBuilder.DeleteData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f077ed29-51b7-4fe7-8136-c65b8e7b3f15");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "tblMembers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(4742), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(4750), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(4754), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(4757), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(4760), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(5793), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(5797), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(5802), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(5805), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(5807), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(5810), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6510), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6517), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6519), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6529), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6531), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6533), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6662), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6665), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6667), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6670), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6672), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6675), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6677), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6679), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6681), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6683), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 126, DateTimeKind.Utc).AddTicks(7646), new DateTime(2024, 3, 30, 11, 18, 37, 126, DateTimeKind.Utc).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 126, DateTimeKind.Utc).AddTicks(7653), new DateTime(2024, 3, 30, 11, 18, 37, 126, DateTimeKind.Utc).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 126, DateTimeKind.Utc).AddTicks(7658), new DateTime(2024, 3, 30, 11, 18, 37, 126, DateTimeKind.Utc).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 126, DateTimeKind.Utc).AddTicks(7662), new DateTime(2024, 3, 30, 11, 18, 37, 126, DateTimeKind.Utc).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 126, DateTimeKind.Utc).AddTicks(7665), new DateTime(2024, 3, 30, 11, 18, 37, 126, DateTimeKind.Utc).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 126, DateTimeKind.Utc).AddTicks(7668), new DateTime(2024, 3, 30, 11, 18, 37, 126, DateTimeKind.Utc).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 126, DateTimeKind.Utc).AddTicks(7671), new DateTime(2024, 3, 30, 11, 18, 37, 126, DateTimeKind.Utc).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6805), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6809), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6816), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6818), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6820), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6822), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6824), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6827), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6829), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6831), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6833), new DateTime(2024, 3, 30, 11, 18, 37, 124, DateTimeKind.Utc).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "31174db2-a9f0-4d03-8641-7d7e6e286d31");

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 18, 37, 126, DateTimeKind.Utc).AddTicks(8284), "73e3e99b-6c12-495c-b6d4-5aabd21dccb1", "AQAAAAEAACcQAAAAEBS4Jxq+KI4UyB+GJZyS7BAV5pRwUz/O2Uky6Ex0rR9BgQzx2vnmkX0XR1eVnHcYcw==", "0bd9ff2d-c99a-44f0-96f6-d668b186cf90", new DateTime(2024, 3, 30, 11, 18, 37, 126, DateTimeKind.Utc).AddTicks(8282) });

            migrationBuilder.CreateIndex(
                name: "IX_tblMembers_UserId",
                table: "tblMembers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblMembers_tblUsers_UserId",
                table: "tblMembers",
                column: "UserId",
                principalTable: "tblUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblMembers_tblUsers_UserId",
                table: "tblMembers");

            migrationBuilder.DropIndex(
                name: "IX_tblMembers_UserId",
                table: "tblMembers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "tblMembers");

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
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "675981fd-9f94-45fb-b41a-d361cc9c23d9");

            migrationBuilder.InsertData(
                table: "tblRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a8baeb0-7191-4731-b8f2-a8b22b5a8596", "c4341e64-2cac-4fae-8399-98652ef6d9e9", "FourthApprover", "FOURTHAPPROVER" },
                    { "575759c6-e020-4c4b-888d-24e01ba62797", "62770f6f-ebef-4367-8fa5-b4f195d1ea31", "ThirdApprover", "THIRDAPPROVER" },
                    { "a173a5cc-3edc-4f49-979c-f423e044b202", "c3a75704-2852-4370-91ef-877d5d826cec", "FirstApprover", "FIRSTAPPROVER" },
                    { "a1922985-be01-4762-a2b6-32d6f4f58235", "77668e01-73ea-4b16-9c29-95b8623ebe9e", "FifthApprover", "FIFTHAPPROVER" },
                    { "f0223225-0c52-413d-b188-0868ea111427", "8e6e24c8-83f7-4b10-863b-04d426d9bd2a", "SecondApprover", "SECONDAPPROVER" },
                    { "f077ed29-51b7-4fe7-8136-c65b8e7b3f15", "7e6df0a1-cf33-402a-97c9-23766cebde89", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 2, 22, 19, 17, 12, 883, DateTimeKind.Utc).AddTicks(2434), "a61e64ba-85f5-43fb-b6bb-81dfe316ddce", "AQAAAAEAACcQAAAAEP5Qp0aQydrKlIrGbCI8BUGLo2epWRxCG+8ybQKzGpkpTOD02DoifvahJ56JE0RYxQ==", "e9695ec2-7f71-4704-ba71-f4a0dccf93f0", new DateTime(2024, 2, 22, 19, 17, 12, 883, DateTimeKind.Utc).AddTicks(2432) });
        }
    }
}
