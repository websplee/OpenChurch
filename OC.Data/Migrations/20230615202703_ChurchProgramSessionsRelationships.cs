using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OC.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChurchProgramSessionsRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ChurchProgramSessionId",
                table: "tblPledges",
                type: "bigint",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_tblPledges_ChurchProgramSessionId",
                table: "tblPledges",
                column: "ChurchProgramSessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblPledges_tblChurchProgramSessions_ChurchProgramSessionId",
                table: "tblPledges",
                column: "ChurchProgramSessionId",
                principalTable: "tblChurchProgramSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblPledges_tblChurchProgramSessions_ChurchProgramSessionId",
                table: "tblPledges");

            migrationBuilder.DropIndex(
                name: "IX_tblPledges_ChurchProgramSessionId",
                table: "tblPledges");

            migrationBuilder.DropColumn(
                name: "ChurchProgramSessionId",
                table: "tblPledges");

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(8765), new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(8772), new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(8775), new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(8777), new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(8779), new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(9562), new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(9569), new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(9572), new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(9574), new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(9575), new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(9577), new DateTime(2023, 6, 15, 22, 3, 13, 7, DateTimeKind.Utc).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(101), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(103), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(105), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(104) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(106), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(107), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(109), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(182), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(184), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(183) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(186), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(187), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(189), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(190), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(193), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(195), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(196), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(197), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 9, DateTimeKind.Utc).AddTicks(4644), new DateTime(2023, 6, 15, 22, 3, 13, 9, DateTimeKind.Utc).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 9, DateTimeKind.Utc).AddTicks(4647), new DateTime(2023, 6, 15, 22, 3, 13, 9, DateTimeKind.Utc).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 9, DateTimeKind.Utc).AddTicks(4649), new DateTime(2023, 6, 15, 22, 3, 13, 9, DateTimeKind.Utc).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 9, DateTimeKind.Utc).AddTicks(4651), new DateTime(2023, 6, 15, 22, 3, 13, 9, DateTimeKind.Utc).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 9, DateTimeKind.Utc).AddTicks(4653), new DateTime(2023, 6, 15, 22, 3, 13, 9, DateTimeKind.Utc).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 9, DateTimeKind.Utc).AddTicks(4654), new DateTime(2023, 6, 15, 22, 3, 13, 9, DateTimeKind.Utc).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 9, DateTimeKind.Utc).AddTicks(4657), new DateTime(2023, 6, 15, 22, 3, 13, 9, DateTimeKind.Utc).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(270), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(274), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(275), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(277), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(279), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(280), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(281), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(283), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(285), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(288), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(289), new DateTime(2023, 6, 15, 22, 3, 13, 8, DateTimeKind.Utc).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "0a8baeb0-7191-4731-b8f2-a8b22b5a8596",
                column: "ConcurrencyStamp",
                value: "145c3026-564b-4830-9c75-8e818d4b9b9f");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "575759c6-e020-4c4b-888d-24e01ba62797",
                column: "ConcurrencyStamp",
                value: "b6af75f8-cef0-410d-9392-7af43bcd6935");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a173a5cc-3edc-4f49-979c-f423e044b202",
                column: "ConcurrencyStamp",
                value: "1dbdc740-a865-447c-9790-add775188ac6");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a1922985-be01-4762-a2b6-32d6f4f58235",
                column: "ConcurrencyStamp",
                value: "326623f1-c74a-4973-84b0-5176411edf09");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "5e6d0b88-6cb6-498d-92c4-26cee03dd306");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f0223225-0c52-413d-b188-0868ea111427",
                column: "ConcurrencyStamp",
                value: "13417a7f-c4ab-4089-be3b-35bf72183a12");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f077ed29-51b7-4fe7-8136-c65b8e7b3f15",
                column: "ConcurrencyStamp",
                value: "70e7c2cd-4086-4c82-92ac-9d61b6ecda82");

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 22, 3, 13, 9, DateTimeKind.Utc).AddTicks(5240), "fa58a4da-4014-45f3-84ad-50bc7d71695a", "AQAAAAEAACcQAAAAEFWVW64XLgHeyMQdXRxmjuRm6Ej3xYZzdqKzyZUcU8d5hNn3puT0GlvGz64y8SjEMg==", "66a18004-f21d-4580-a57d-676c02e1e64c", new DateTime(2023, 6, 15, 22, 3, 13, 9, DateTimeKind.Utc).AddTicks(5238) });
        }
    }
}
