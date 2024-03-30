using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OC.Data.Migrations
{
    /// <inheritdoc />
    public partial class InsertChurchRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(3369), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(3377), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(3388), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(3391), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(3395), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(4390), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(4393), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(4396), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(4398), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(4400), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(4407), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(4410), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5098), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5105), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5108), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5118), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5120), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5122), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5240), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5244), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5246), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5248), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5251), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5256), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5259), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5263), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5265), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5267), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 132, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 3, 30, 11, 19, 30, 132, DateTimeKind.Utc).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 132, DateTimeKind.Utc).AddTicks(5436), new DateTime(2024, 3, 30, 11, 19, 30, 132, DateTimeKind.Utc).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 132, DateTimeKind.Utc).AddTicks(5439), new DateTime(2024, 3, 30, 11, 19, 30, 132, DateTimeKind.Utc).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 132, DateTimeKind.Utc).AddTicks(5441), new DateTime(2024, 3, 30, 11, 19, 30, 132, DateTimeKind.Utc).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 132, DateTimeKind.Utc).AddTicks(5443), new DateTime(2024, 3, 30, 11, 19, 30, 132, DateTimeKind.Utc).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 132, DateTimeKind.Utc).AddTicks(5446), new DateTime(2024, 3, 30, 11, 19, 30, 132, DateTimeKind.Utc).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 132, DateTimeKind.Utc).AddTicks(5448), new DateTime(2024, 3, 30, 11, 19, 30, 132, DateTimeKind.Utc).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5390), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5393), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5403), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5405), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5409), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5413), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5417), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5419), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5421), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5423), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5425), new DateTime(2024, 3, 30, 11, 19, 30, 130, DateTimeKind.Utc).AddTicks(5425) });

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "e399e55a-9408-4042-bf1e-7a10edc6aa70");

            migrationBuilder.InsertData(
                table: "tblRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a8baeb0-7191-4731-b8f2-a8b22b5a8596", "51910a00-2be7-4a72-9e0c-03f6b943a75c", "CellGroupLeader", "CELLGROUPLEADER" },
                    { "575759c6-e020-4c4b-888d-24e01ba62797", "4d0d4dac-527e-4911-8c5f-b77e99ef2ea7", "Pastor", "PASTOR" },
                    { "a173a5cc-3edc-4f49-979c-f423e044b202", "754a7cc5-ea50-4bd1-9f6c-b42b2cb4a213", "Member", "MEMBER" },
                    { "a1922985-be01-4762-a2b6-32d6f4f58235", "d9bcaf1b-f4f6-4c55-8d3f-3cd5231f273a", "MinistryLeader", "MINISTRYLEADER" },
                    { "f0223225-0c52-413d-b188-0868ea111427", "a23323d6-7880-40c7-a575-e23364c956f1", "Visitor", "VISITOR" },
                    { "f077ed29-51b7-4fe7-8136-c65b8e7b3f15", "8fa2c409-f65a-4470-83cc-0914f1264efb", "BranchUser", "BRANCHUSER" }
                });

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 132, DateTimeKind.Utc).AddTicks(6061), "3e9f8a65-3e0f-4e49-8bf6-3d4f2af67fd6", "AQAAAAEAACcQAAAAEDI8nAFJ8nzUmSgnk+ppVj3P4lrbflyRAXXve80dQPjIOr8KCtPOms96Vb8sy2GVmA==", "059ab969-ceb1-494f-a051-e75bb55304b0", new DateTime(2024, 3, 30, 11, 19, 30, 132, DateTimeKind.Utc).AddTicks(6059) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
