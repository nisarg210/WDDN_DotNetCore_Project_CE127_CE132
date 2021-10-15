using Microsoft.EntityFrameworkCore.Migrations;

namespace BookBorrow.Migrations
{
    public partial class bookissuemanytomanyaddname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookName",
                table: "BookIssue",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BookIssue",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookName",
                table: "BookIssue");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "BookIssue");
        }
    }
}
