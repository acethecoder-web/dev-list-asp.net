using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace asptraining.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDev : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Developer",
                columns: new[] { "DevID", "DevFirstName", "DevLastName", "DevMiddleName", "HireDate", "Specialty" },
                values: new object[,]
                {
                    { 1, "Aces", "Hapiz", "Sumalinog", new DateTime(2025, 9, 22, 10, 50, 15, 329, DateTimeKind.Local).AddTicks(3069), "Full Stack Developer" },
                    { 2, "Maria", "Lopez", "Cruz", new DateTime(2025, 9, 22, 10, 50, 15, 330, DateTimeKind.Local).AddTicks(4498), "Backend Developer" },
                    { 3, "John", "Smith", "Alexander", new DateTime(2025, 9, 22, 10, 50, 15, 330, DateTimeKind.Local).AddTicks(4509), "Frontend Developer" },
                    { 4, "Sophia", "Johnson", "Grace", new DateTime(2025, 9, 22, 10, 50, 15, 330, DateTimeKind.Local).AddTicks(4511), "Mobile App Developer" },
                    { 5, "David", "Kim", "Lee", new DateTime(2025, 9, 22, 10, 50, 15, 330, DateTimeKind.Local).AddTicks(4512), "Database Administrator" },
                    { 6, "Emma", "Brown", "Claire", new DateTime(2025, 9, 22, 10, 50, 15, 330, DateTimeKind.Local).AddTicks(4513), "UI/UX Designer" },
                    { 7, "Michael", "Garcia", "Jose", new DateTime(2025, 9, 22, 10, 50, 15, 330, DateTimeKind.Local).AddTicks(4515), "DevOps Engineer" },
                    { 8, "Olivia", "Martinez", "Rose", new DateTime(2025, 9, 22, 10, 50, 15, 330, DateTimeKind.Local).AddTicks(4516), "AI/ML Engineer" },
                    { 9, "James", "Anderson", "Paul", new DateTime(2025, 9, 22, 10, 50, 15, 330, DateTimeKind.Local).AddTicks(4517), "Cybersecurity Specialist" },
                    { 10, "Liam", "Wilson", "Thomas", new DateTime(2025, 9, 22, 10, 50, 15, 330, DateTimeKind.Local).AddTicks(4518), "Cloud Solutions Architect" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Developer",
                keyColumn: "DevID",
                keyValue: 10);
        }
    }
}
