using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpass_Profilling.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Applicants",
                columns: table => new
                {
                    kiosk_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fullName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type_Applicant = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type_Carpass = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name_Student = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Grade = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    app_Relation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    home_Ad = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    app_Contact = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_Owner = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_Relation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_PlateNO = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_Brand = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_Type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_Series = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_Color = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    schoolyear = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    facefile_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Doc1 = table.Column<byte[]>(type: "longblob", nullable: true),
                    Doc2 = table.Column<byte[]>(type: "longblob", nullable: true),
                    Doc3 = table.Column<byte[]>(type: "longblob", nullable: true),
                    Doc4 = table.Column<byte[]>(type: "longblob", nullable: true),
                    Doc5 = table.Column<byte[]>(type: "longblob", nullable: true),
                    Doc6 = table.Column<byte[]>(type: "longblob", nullable: true),
                    Doc7 = table.Column<byte[]>(type: "longblob", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants", x => x.kiosk_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Syear",
                columns: table => new
                {
                    Sy_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Year = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syear", x => x.Sy_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Gender = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Birthday = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Role = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image = table.Column<byte[]>(type: "longblob", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Email);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pendings",
                columns: table => new
                {
                    pending_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    kiosk_Id = table.Column<int>(type: "int", nullable: true),
                    fullName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type_Applicant = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type_Carpass = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name_Student = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_Grade = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    app_Relation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    home_Ad = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    app_Contact = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_Owner = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_Relation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_PlateNO = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_Brand = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_Type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_Series = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_Color = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    schoolyear = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    facefile_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    IsDoc1Submitted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDoc2Submitted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDoc3Submitted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDoc4Submitted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDoc5Submitted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDoc6Submitted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDoc7Submitted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Doc1 = table.Column<byte[]>(type: "longblob", nullable: true),
                    Doc2 = table.Column<byte[]>(type: "longblob", nullable: true),
                    Doc3 = table.Column<byte[]>(type: "longblob", nullable: true),
                    Doc4 = table.Column<byte[]>(type: "longblob", nullable: true),
                    Doc5 = table.Column<byte[]>(type: "longblob", nullable: true),
                    Doc6 = table.Column<byte[]>(type: "longblob", nullable: true),
                    Doc7 = table.Column<byte[]>(type: "longblob", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pendings", x => x.pending_ID);
                    table.ForeignKey(
                        name: "FK_Pendings_Applicants_kiosk_Id",
                        column: x => x.kiosk_Id,
                        principalTable: "Applicants",
                        principalColumn: "kiosk_Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Central_Datas",
                columns: table => new
                {
                    central_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pending_ID = table.Column<int>(type: "int", nullable: true),
                    fullname = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type_applicant = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type_carpass = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name_student = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    course_grade = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    app_relation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    home_ad = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    app_contact = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_owner = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_relation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_plateno = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_brand = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_series = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ve_color = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    carpass_no = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ref_number = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issued_by = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    schoolyear = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sub_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    app_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    expiration_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Doc1 = table.Column<byte[]>(type: "longblob", nullable: true),
                    Doc2 = table.Column<byte[]>(type: "longblob", nullable: true),
                    Doc3 = table.Column<byte[]>(type: "longblob", nullable: true),
                    Doc4 = table.Column<byte[]>(type: "longblob", nullable: true),
                    Doc5 = table.Column<byte[]>(type: "longblob", nullable: true),
                    Doc6 = table.Column<byte[]>(type: "longblob", nullable: true),
                    Doc7 = table.Column<byte[]>(type: "longblob", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Central_Datas", x => x.central_Id);
                    table.ForeignKey(
                        name: "FK_Central_Datas_Pendings_pending_ID",
                        column: x => x.pending_ID,
                        principalTable: "Pendings",
                        principalColumn: "pending_ID",
                        onDelete: ReferentialAction.SetNull);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Applicants",
                columns: new[] { "kiosk_Id", "Doc1", "Doc2", "Doc3", "Doc4", "Doc5", "Doc6", "Doc7", "app_Contact", "app_Relation", "course_Grade", "facefile_Date", "fullName", "home_Ad", "name_Student", "schoolyear", "type_Applicant", "type_Carpass", "ve_Brand", "ve_Color", "ve_Owner", "ve_PlateNO", "ve_Relation", "ve_Series", "ve_Type" },
                values: new object[] { 1, null, null, null, null, null, null, null, "09456544096", "Student", "BSCS-3", new DateOnly(2024, 5, 28), "Allen Miguel L. Vargas", "Mandurriao", null, "2023-2024", "CPU Student", null, "Toyota", "Orange", "Allen Miguel L. Vargas", "FAJ9228", "Owner", "Wigo", "Hatchback" });

            migrationBuilder.InsertData(
                table: "Pendings",
                columns: new[] { "pending_ID", "Doc1", "Doc2", "Doc3", "Doc4", "Doc5", "Doc6", "Doc7", "IsDoc1Submitted", "IsDoc2Submitted", "IsDoc3Submitted", "IsDoc4Submitted", "IsDoc5Submitted", "IsDoc6Submitted", "IsDoc7Submitted", "app_Contact", "app_Relation", "course_Grade", "facefile_Date", "fullName", "home_Ad", "kiosk_Id", "name_Student", "schoolyear", "type_Applicant", "type_Carpass", "ve_Brand", "ve_Color", "ve_Owner", "ve_PlateNO", "ve_Relation", "ve_Series", "ve_Type" },
                values: new object[] { 1, null, null, null, null, null, null, null, false, false, false, false, false, false, false, "09454564096", "Student", "BSCS-3", new DateOnly(2024, 5, 28), "Allen Miguel L. Vargas", "Mandurriao", null, null, "2023-2024", "CPU Student", null, "Toyota", "Orange", "Allen Miguel L. Vargas", "FAJ9117", "Owner", "Wigo", "Hatchback" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Email", "Birthday", "Gender", "Image", "Name", "Password", "Role" },
                values: new object[] { "admin@cpu.edu.ph", "1980-01-01", "Male", null, "CPU Admin", "admin123", "Admin" });

            migrationBuilder.InsertData(
                table: "Central_Datas",
                columns: new[] { "central_Id", "Doc1", "Doc2", "Doc3", "Doc4", "Doc5", "Doc6", "Doc7", "app_Date", "app_contact", "app_relation", "carpass_no", "course_grade", "expiration_Date", "fullname", "home_ad", "issued_by", "name_student", "pending_ID", "ref_number", "schoolyear", "sub_Date", "type_applicant", "type_carpass", "ve_brand", "ve_color", "ve_owner", "ve_plateno", "ve_relation", "ve_series", "ve_type" },
                values: new object[] { 1, null, null, null, null, null, null, null, new DateOnly(2023, 1, 1), "123-456-7890", "Self", null, "BSCS-3", new DateOnly(2024, 1, 1), "John Doe", "123 Main St", null, null, 1, null, "2023-2024", new DateOnly(2023, 1, 1), "CPU Student", null, "Toyota", "Blue", "John Doe", "ABC123", "Owner", "Corolla", "Sedan" });

            migrationBuilder.CreateIndex(
                name: "IX_Central_Datas_pending_ID",
                table: "Central_Datas",
                column: "pending_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Pendings_kiosk_Id",
                table: "Pendings",
                column: "kiosk_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Central_Datas");

            migrationBuilder.DropTable(
                name: "Syear");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Pendings");

            migrationBuilder.DropTable(
                name: "Applicants");
        }
    }
}
