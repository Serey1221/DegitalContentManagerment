using Microsoft.EntityFrameworkCore.Migrations;

namespace DegitalContentManagerment.Migrations
{
    public partial class addLeturer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageFile",
                table: "Leturers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFile",
                table: "Leturers");
        }
    }
}
