using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CentralizedDatabaseManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Distributors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistributorCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistributorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommissioningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KYCUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgreementValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AgreementValidUpto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmergencyContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsuranceExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GSTIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNGOperatorsAvailable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNGFirmName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transporter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoOfVehicles = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distributors", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Distributors");
        }
    }
}
