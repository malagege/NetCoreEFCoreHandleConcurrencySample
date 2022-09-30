using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreEFCoreHandleConcurrencySample.Migrations
{
    public partial class AddStudentAge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentAge",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentAge",
                table: "Students");
        }
    }
}
