using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdentityCard = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CellPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "VaccineManufacturers",
                columns: table => new
                {
                    ManufacturerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufacturerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VaccineM__357E5CA1514B7D65", x => x.ManufacturerID);
                });

            migrationBuilder.CreateTable(
                name: "SickWithCorona",
                columns: table => new
                {
                    SickID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    PositiveResultDate = table.Column<DateTime>(type: "date", nullable: true),
                    RecoveryDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SickWith__1F450E983E26633A", x => x.SickID);
                    table.ForeignKey(
                        name: "FK__SickWithC__UserI__3A81B327",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "VaccinationDetails",
                columns: table => new
                {
                    VaccinationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    VaccineDate = table.Column<DateTime>(type: "date", nullable: true),
                    VaccineManufacturerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Vaccinat__466BCFA7BDBBF83E", x => x.VaccinationID);
                    table.ForeignKey(
                        name: "FK__Vaccinati__UserI__3F466844",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK__Vaccinati__Vacci__403A8C7D",
                        column: x => x.VaccineManufacturerID,
                        principalTable: "VaccineManufacturers",
                        principalColumn: "ManufacturerID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SickWithCorona_UserID",
                table: "SickWithCorona",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "UQ__Users__DA5B2F6DCDC44573",
                table: "Users",
                column: "IdentityCard",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VaccinationDetails_UserID",
                table: "VaccinationDetails",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_VaccinationDetails_VaccineManufacturerID",
                table: "VaccinationDetails",
                column: "VaccineManufacturerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SickWithCorona");

            migrationBuilder.DropTable(
                name: "VaccinationDetails");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "VaccineManufacturers");
        }
    }
}
