using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Repository.Migrations
{
    public partial class AddUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Quotes");

            migrationBuilder.AddColumn<int>(
                name: "UsersUserId",
                table: "Quotes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_UsersUserId",
                table: "Quotes",
                column: "UsersUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_User_UsersUserId",
                table: "Quotes",
                column: "UsersUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_User_UsersUserId",
                table: "Quotes");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Quotes_UsersUserId",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "Quotes");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Quotes",
                nullable: true);
        }
    }
}
