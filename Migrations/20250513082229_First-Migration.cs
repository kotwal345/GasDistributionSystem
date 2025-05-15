using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CentralizedDatabaseManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Records",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "AgreementValidFrom",
                table: "Records",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AgreementValidUpto",
                table: "Records",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Records",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CommissioningDate",
                table: "Records",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DistributorCode",
                table: "Records",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DistributorName",
                table: "Records",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContact",
                table: "Records",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GSTIN",
                table: "Records",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsuranceExpiryDate",
                table: "Records",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KYCUpdated",
                table: "Records",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "Records",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NoOfVehicles",
                table: "Records",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OwnerName",
                table: "Records",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PNGFirmName",
                table: "Records",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PNGOperatorsAvailable",
                table: "Records",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pin",
                table: "Records",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Records",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Transporter",
                table: "Records",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "AgreementValidFrom",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "AgreementValidUpto",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "CommissioningDate",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "DistributorCode",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "DistributorName",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "EmergencyContact",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "GSTIN",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "InsuranceExpiryDate",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "KYCUpdated",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "NoOfVehicles",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "OwnerName",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "PNGFirmName",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "PNGOperatorsAvailable",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Pin",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Transporter",
                table: "Records");
        }
    }
}
