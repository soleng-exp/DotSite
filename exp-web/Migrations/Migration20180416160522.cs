using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace exp_web.Migrations
{
    public class Migration20180416160522 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false).Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Users");
        }
    }
}