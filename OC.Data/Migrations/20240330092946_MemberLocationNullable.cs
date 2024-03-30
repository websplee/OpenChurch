using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OC.Data.Migrations
{
    /// <inheritdoc />
    public partial class MemberLocationNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "tblMembers",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "tblMembers",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2439), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2447), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2451), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2454), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2456), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3406), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3410), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3412), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3415), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3417), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3419), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3421), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3972), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3974), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3976), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3978), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3980), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3981), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4065), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4068), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4070), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4072), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4072) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4074), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4073) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4076), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4078), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4080), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4079) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4082), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4083), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(202), new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(207), new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(209), new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(211), new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(213), new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(215), new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(217), new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4169), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4171), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4174), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4176), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4178), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4179), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4181), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4183), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4185), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4187), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4188), new DateTime(2024, 3, 30, 11, 29, 45, 534, DateTimeKind.Utc).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "0a8baeb0-7191-4731-b8f2-a8b22b5a8596",
                column: "ConcurrencyStamp",
                value: "e76d7c3c-23c1-4c72-93b1-53f6088df559");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "575759c6-e020-4c4b-888d-24e01ba62797",
                column: "ConcurrencyStamp",
                value: "2e55b085-b44b-4feb-8bb2-c9d34d66a58e");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a173a5cc-3edc-4f49-979c-f423e044b202",
                column: "ConcurrencyStamp",
                value: "009714a0-dfda-4953-af94-71be6ee786e8");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a1922985-be01-4762-a2b6-32d6f4f58235",
                column: "ConcurrencyStamp",
                value: "d14d5251-902a-4263-8870-f7fe603330ed");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "8d6f00e5-9739-4ba0-99e7-81cf2c822cd7");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f0223225-0c52-413d-b188-0868ea111427",
                column: "ConcurrencyStamp",
                value: "860c6196-1d6c-45e5-aaa4-ed08f9c27404");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f077ed29-51b7-4fe7-8136-c65b8e7b3f15",
                column: "ConcurrencyStamp",
                value: "ff22bbaa-d7d7-46bf-afeb-a47f3356a6fe");

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(700), "5530a179-650d-4b0f-8bb1-e5833fd4fa19", "AQAAAAEAACcQAAAAELjdAgKsirzUE/pQ4rsdlVas42Do9rbc1p363k0TMaSr9hULiuhDHOmiUcxr0eKI5Q==", "6992ffaf-0211-49bb-a13a-8d3a7c22ec40", new DateTime(2024, 3, 30, 11, 29, 45, 536, DateTimeKind.Utc).AddTicks(699) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "tblMembers",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "tblMembers",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

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
                keyValue: "0a8baeb0-7191-4731-b8f2-a8b22b5a8596",
                column: "ConcurrencyStamp",
                value: "51910a00-2be7-4a72-9e0c-03f6b943a75c");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "575759c6-e020-4c4b-888d-24e01ba62797",
                column: "ConcurrencyStamp",
                value: "4d0d4dac-527e-4911-8c5f-b77e99ef2ea7");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a173a5cc-3edc-4f49-979c-f423e044b202",
                column: "ConcurrencyStamp",
                value: "754a7cc5-ea50-4bd1-9f6c-b42b2cb4a213");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a1922985-be01-4762-a2b6-32d6f4f58235",
                column: "ConcurrencyStamp",
                value: "d9bcaf1b-f4f6-4c55-8d3f-3cd5231f273a");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "e399e55a-9408-4042-bf1e-7a10edc6aa70");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f0223225-0c52-413d-b188-0868ea111427",
                column: "ConcurrencyStamp",
                value: "a23323d6-7880-40c7-a575-e23364c956f1");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f077ed29-51b7-4fe7-8136-c65b8e7b3f15",
                column: "ConcurrencyStamp",
                value: "8fa2c409-f65a-4470-83cc-0914f1264efb");

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 19, 30, 132, DateTimeKind.Utc).AddTicks(6061), "3e9f8a65-3e0f-4e49-8bf6-3d4f2af67fd6", "AQAAAAEAACcQAAAAEDI8nAFJ8nzUmSgnk+ppVj3P4lrbflyRAXXve80dQPjIOr8KCtPOms96Vb8sy2GVmA==", "059ab969-ceb1-494f-a051-e75bb55304b0", new DateTime(2024, 3, 30, 11, 19, 30, 132, DateTimeKind.Utc).AddTicks(6059) });
        }
    }
}
