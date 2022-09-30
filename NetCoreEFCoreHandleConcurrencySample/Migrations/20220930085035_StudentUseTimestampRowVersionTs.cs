using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreEFCoreHandleConcurrencySample.Migrations
{
    public partial class StudentUseTimestampRowVersionTs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Students");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersionTs",
                table: "Students",
                type: "rowversion",
                rowVersion: true,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowVersionTs",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "RowVersion",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
