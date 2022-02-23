﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagmentRefactored.Migrations.FrontendReservationRefMigrations
{
    public partial class totalbillDataTypeChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "total_bill",
                table: "reservations",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "total_bill",
                table: "reservations",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
