using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asptraining.Migrations
{
    /// <inheritdoc />
    public partial class NewAddedSeededDataDev : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 7,
                column: "HireDate",
                value: new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 8,
                column: "HireDate",
                value: new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 9,
                column: "HireDate",
                value: new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 10,
                column: "HireDate",
                value: new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2025, 9, 22, 10, 50, 15, 329, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2025, 9, 22, 10, 50, 15, 330, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2025, 9, 22, 10, 50, 15, 330, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2025, 9, 22, 10, 50, 15, 330, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2025, 9, 22, 10, 50, 15, 330, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2025, 9, 22, 10, 50, 15, 330, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 7,
                column: "HireDate",
                value: new DateTime(2025, 9, 22, 10, 50, 15, 330, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 8,
                column: "HireDate",
                value: new DateTime(2025, 9, 22, 10, 50, 15, 330, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 9,
                column: "HireDate",
                value: new DateTime(2025, 9, 22, 10, 50, 15, 330, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 10,
                column: "HireDate",
                value: new DateTime(2025, 9, 22, 10, 50, 15, 330, DateTimeKind.Local).AddTicks(4518));
        }
    }
}
