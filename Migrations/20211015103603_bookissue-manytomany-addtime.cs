using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookBorrow.Migrations
{
    public partial class bookissuemanytomanyaddtime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "End",
                table: "BookIssue",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Start",
                table: "BookIssue",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "End",
                table: "BookIssue");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "BookIssue");
        }
    }
}
