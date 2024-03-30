using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OC.Data.Migrations
{
    /// <inheritdoc />
    public partial class UsersUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFirstLogin",
                table: "tblUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CanDownload",
                table: "tblRoleModules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanExport",
                table: "tblRoleModules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanUpload",
                table: "tblRoleModules",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "IsFirstLogin", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 56, 7, 266, DateTimeKind.Utc).AddTicks(8167), "5bc11dc6-b7d6-41e3-843b-b20b8b676382", false, "AQAAAAEAACcQAAAAEJQygK4MQEpgLPpj1So9Y1VoMky6wnOerA0+XpTRjNLRvqDlLBGAloCHuJrmmmEX+A==", "08d3673d-66b7-4183-830a-07ff70bd3344", new DateTime(2024, 1, 28, 12, 56, 7, 266, DateTimeKind.Utc).AddTicks(8166) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFirstLogin",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "CanDownload",
                table: "tblRoleModules");

            migrationBuilder.DropColumn(
                name: "CanExport",
                table: "tblRoleModules");

            migrationBuilder.DropColumn(
                name: "CanUpload",
                table: "tblRoleModules");

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
    }
}
