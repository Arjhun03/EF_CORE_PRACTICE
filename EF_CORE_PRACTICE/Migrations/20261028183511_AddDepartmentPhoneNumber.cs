using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CORE_PRACTICE.Migrations
{
    /// <inheritdoc />
    public partial class AddDepartmentPhoneNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Departments");
        }
    }
}
