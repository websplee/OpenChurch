using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OC.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChurchProgramSessionsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ChurchProgramSessionId",
                table: "tblChurchProgramSessionAttendances",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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

            migrationBuilder.CreateIndex(
                name: "IX_tblChurchProgramSessionVistors_ChurchProgramSessionId",
                table: "tblChurchProgramSessionVistors",
                column: "ChurchProgramSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_tblChurchProgramSessionAttendances_ChurchProgramSessionId",
                table: "tblChurchProgramSessionAttendances",
                column: "ChurchProgramSessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblChurchProgramSessionAttendances_tblChurchProgramSessions_ChurchProgramSessionId",
                table: "tblChurchProgramSessionAttendances",
                column: "ChurchProgramSessionId",
                principalTable: "tblChurchProgramSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblChurchProgramSessionVistors_tblChurchProgramSessions_ChurchProgramSessionId",
                table: "tblChurchProgramSessionVistors",
                column: "ChurchProgramSessionId",
                principalTable: "tblChurchProgramSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblChurchProgramSessionAttendances_tblChurchProgramSessions_ChurchProgramSessionId",
                table: "tblChurchProgramSessionAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_tblChurchProgramSessionVistors_tblChurchProgramSessions_ChurchProgramSessionId",
                table: "tblChurchProgramSessionVistors");

            migrationBuilder.DropIndex(
                name: "IX_tblChurchProgramSessionVistors_ChurchProgramSessionId",
                table: "tblChurchProgramSessionVistors");

            migrationBuilder.DropIndex(
                name: "IX_tblChurchProgramSessionAttendances_ChurchProgramSessionId",
                table: "tblChurchProgramSessionAttendances");

            migrationBuilder.DropColumn(
                name: "ChurchProgramSessionId",
                table: "tblChurchProgramSessionAttendances");

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6884), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6897), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6901), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6905), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "tblBranches",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6915), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7937), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7943), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7945), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7947), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7949), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7951), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "tblChurchPrograms",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7953), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8594), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8604), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8606), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8622), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8623), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "tblContinents",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8625), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8751), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8754), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8757), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8759), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8760), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8762), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8765), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8767), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8770), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "tblCountries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8773), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3559), new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3565), new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3568), new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3571), new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3573), new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3575), new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "tblModules",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3578), new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8891), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8894), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8906), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8908), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8910), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8912), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8914), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8916), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8918), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8919), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "tblRegions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ApprovalDate", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 6, 15, 21, 48, 52, 756, DateTimeKind.Utc).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "0a8baeb0-7191-4731-b8f2-a8b22b5a8596",
                column: "ConcurrencyStamp",
                value: "34f5a6df-eea6-4320-ba53-94fda6cc70c8");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "575759c6-e020-4c4b-888d-24e01ba62797",
                column: "ConcurrencyStamp",
                value: "8db7de9e-9224-4240-928e-7246108f87ff");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a173a5cc-3edc-4f49-979c-f423e044b202",
                column: "ConcurrencyStamp",
                value: "00409068-d52f-482d-a086-314d51f5e216");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "a1922985-be01-4762-a2b6-32d6f4f58235",
                column: "ConcurrencyStamp",
                value: "7cde5505-82cc-420d-a419-663a68f1a404");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "bdf53b89-5034-4dfa-8d2b-7441ce66a535",
                column: "ConcurrencyStamp",
                value: "c11b44be-749b-42d6-911d-674a953566c5");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f0223225-0c52-413d-b188-0868ea111427",
                column: "ConcurrencyStamp",
                value: "1546395a-6aaf-4ffa-a1d5-800a309553d3");

            migrationBuilder.UpdateData(
                table: "tblRoles",
                keyColumn: "Id",
                keyValue: "f077ed29-51b7-4fe7-8136-c65b8e7b3f15",
                column: "ConcurrencyStamp",
                value: "83a2417f-73b2-4006-8566-cfdf00a0b0ab");

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: "8a4353dd-5496-4ffe-bfa3-db90afab6684",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "SubmissionDate" },
                values: new object[] { new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(4300), "0d9b7d92-c9cb-419c-a210-2664137d7775", "AQAAAAEAACcQAAAAEIe9LtbrYqizrv4qyCdXXdl3m3UCVo+KrIRHxP+JbayF2zvpzHAEqDFYt1Y4FukVWQ==", "3435ec5f-061a-4a48-bed1-b4f40173e807", new DateTime(2023, 6, 15, 21, 48, 52, 759, DateTimeKind.Utc).AddTicks(4298) });
        }
    }
}
