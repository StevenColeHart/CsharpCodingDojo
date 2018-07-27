using Microsoft.EntityFrameworkCore.Migrations;

namespace Login.Migrations
{
    public partial class ConfirmPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "confirm_password",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "confirm_password",
                table: "User");
        }
    }
}
