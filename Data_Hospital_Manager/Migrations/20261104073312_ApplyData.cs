using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data_Hospital_Manager.Migrations
{
    /// <inheritdoc />
    public partial class ApplyData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "FirstName", "HospitalId", "LastName", "PhoneNumber", "Specialty" },
                values: new object[,]
                {
                    { 1, "ivan.petrov@gmail.com", "Иван", 1, "Петров", "0887563458", "Кардиолог" },
                    { 2, "mariq.georgieva@gmail.com", "Мария", 2, "Георгиева", "08889641491", "Невролог" },
                    { 3, "petur.dimitrov@gmail.com", "Петър", 1, "Димитров", "0887456123", "Хирург" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "aleks.ivanov@gmail.com", "Александър", "Иванов", "0887456163" },
                    { 2, "antoaneta.markova@gmail.com", "Антоанета", "Маркова", "0887456623" },
                    { 3, "georgi.petrov@gmail.com", "Георги", "Петров", "0887446125" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
