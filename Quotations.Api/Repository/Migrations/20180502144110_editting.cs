using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Repository.Migrations
{
    public partial class editting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Quotes",
                newName: "SourceInfo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Quotes",
                newName: "QuoteId");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Quotes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    AuthorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.AuthorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_AuthorId",
                table: "Quotes",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Author_AuthorId",
                table: "Quotes",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Author_AuthorId",
                table: "Quotes");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Quotes_AuthorId",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Quotes");

            migrationBuilder.RenameColumn(
                name: "SourceInfo",
                table: "Quotes",
                newName: "Author");

            migrationBuilder.RenameColumn(
                name: "QuoteId",
                table: "Quotes",
                newName: "Id");
        }
    }
}
