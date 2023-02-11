using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalMenegment.DAL.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    appointment_number = table.Column<int>(type: "int", nullable: false),
                    appointment_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    appointment_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    appointment_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doctor_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    doctor_speciast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    doctor_mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    doctor_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    doctor_username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    doctor_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    doctor_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "hospitals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hospital_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hospital_place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hospital_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hospital_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hospital_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hospitals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "medicines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    medicine_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    medicine_company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    medicine_composition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    medicine_cost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    medicine_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    medicine_dose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    medicine_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nurses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nurse_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nurse_duty_hour = table.Column<int>(type: "int", nullable: false),
                    nurse_mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nurse_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nurse_username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nurse_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nurse_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nurses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patient_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    patient_mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    patient_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    patient_username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    patient_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    patient_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    patient_blood_group = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appointments");

            migrationBuilder.DropTable(
                name: "doctors");

            migrationBuilder.DropTable(
                name: "hospitals");

            migrationBuilder.DropTable(
                name: "medicines");

            migrationBuilder.DropTable(
                name: "nurses");

            migrationBuilder.DropTable(
                name: "patients");
        }
    }
}
