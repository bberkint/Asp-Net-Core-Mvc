using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "CreatedData", "FirstName", "Gender", "LastName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 5, 13, 18, 7, 423, DateTimeKind.Local).AddTicks(6725), "Veli", 0, "Kutay", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, new DateTime(2024, 11, 5, 13, 18, 7, 423, DateTimeKind.Local).AddTicks(7130), "Arda", 0, "Kaan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, new DateTime(2024, 11, 5, 13, 18, 7, 423, DateTimeKind.Local).AddTicks(7132), "Utku", 0, "Pirik", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, new DateTime(2024, 11, 5, 13, 18, 7, 423, DateTimeKind.Local).AddTicks(7133), "Nafiz", 0, "Balcı", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CreatedData", "ModifiedDate", "Password", "Role", "Status", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 5, 13, 18, 7, 421, DateTimeKind.Local).AddTicks(6325), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$O6e2Nk36t2JTk7a0hoQC2uDvX3XslHwafo3wGDeocELIy8viRQniS", 1, 0, "administrator" },
                    { 2, new DateTime(2024, 11, 5, 13, 18, 7, 422, DateTimeKind.Local).AddTicks(8345), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$f0slmAXidjUurLDcy5xDgOHnpLg6jtZbdWkjVFkroyYmWdWgDpiBi", 2, 0, "berkin" }
                });

            migrationBuilder.InsertData(
                table: "StudentDetail",
                columns: new[] { "ID", "BirthDay", "CreatedData", "ModifiedDate", "PhoneNumber", "SchoolNumber", "Status", "StudentID" },
                values: new object[,]
                {
                    { 1, new DateTime(1999, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 13, 18, 7, 423, DateTimeKind.Local).AddTicks(7400), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "100", 0, 1 },
                    { 2, new DateTime(2000, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 13, 18, 7, 423, DateTimeKind.Local).AddTicks(7712), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "200", 0, 2 },
                    { 3, new DateTime(2000, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 13, 18, 7, 423, DateTimeKind.Local).AddTicks(7714), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "300", 0, 3 },
                    { 4, new DateTime(2000, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 13, 18, 7, 423, DateTimeKind.Local).AddTicks(7715), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "400", 0, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
