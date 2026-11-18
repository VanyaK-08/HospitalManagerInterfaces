using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Hospital_Manager.Migrations
{
    /// <inheritdoc />
    public partial class NewThings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber", "Specialty" },
                values: new object[] { "john.doe@example.com", "John", "Doe", "0983211345", "Cardiology" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber", "Specialty" },
                values: new object[] { "jane.smith@example.com", "Jane", "Smith", "0983211346", "Neurology" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "alice.johnson@example.com", "Alice", "Johnson", "0896754321" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "bob.smith@example.com", "Bob", "Smith", "0891234567" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "charlie.brown@example.com", "Charlie", "Brown", "0899876543" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber", "Specialty" },
                values: new object[] { "ivan.petrov@gmail.com", "Иван", "Петров", "0887563458", "Кардиолог" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber", "Specialty" },
                values: new object[] { "mariq.georgieva@gmail.com", "Мария", "Георгиева", "08889641491", "Невролог" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "FirstName", "HospitalId", "LastName", "PhoneNumber", "Specialty" },
                values: new object[] { 3, "petur.dimitrov@gmail.com", "Петър", 1, "Димитров", "0887456123", "Хирург" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "aleks.ivanov@gmail.com", "Александър", "Иванов", "0887456163" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "antoaneta.markova@gmail.com", "Антоанета", "Маркова", "0887456623" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "georgi.petrov@gmail.com", "Георги", "Петров", "0887446125" });
        }
    }
}
