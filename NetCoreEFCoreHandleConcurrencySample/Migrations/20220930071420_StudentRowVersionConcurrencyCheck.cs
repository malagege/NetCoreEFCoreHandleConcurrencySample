using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreEFCoreHandleConcurrencySample.Migrations
{
    public partial class StudentRowVersionConcurrencyCheck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RowVersion",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Students");
        }
    }
}
