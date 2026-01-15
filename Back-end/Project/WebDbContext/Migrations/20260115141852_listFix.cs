using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDbContext.Migrations
{
    /// <inheritdoc />
    public partial class listFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BaseEntityid",
                table: "moduleDbSet",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "BaseEntityid",
                table: "heroDbSet",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_moduleDbSet_BaseEntityid",
                table: "moduleDbSet",
                column: "BaseEntityid");

            migrationBuilder.CreateIndex(
                name: "IX_heroDbSet_BaseEntityid",
                table: "heroDbSet",
                column: "BaseEntityid");

            migrationBuilder.AddForeignKey(
                name: "FK_heroDbSet_baseEntityDbSet_BaseEntityid",
                table: "heroDbSet",
                column: "BaseEntityid",
                principalTable: "baseEntityDbSet",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_moduleDbSet_baseEntityDbSet_BaseEntityid",
                table: "moduleDbSet",
                column: "BaseEntityid",
                principalTable: "baseEntityDbSet",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_heroDbSet_baseEntityDbSet_BaseEntityid",
                table: "heroDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_moduleDbSet_baseEntityDbSet_BaseEntityid",
                table: "moduleDbSet");

            migrationBuilder.DropIndex(
                name: "IX_moduleDbSet_BaseEntityid",
                table: "moduleDbSet");

            migrationBuilder.DropIndex(
                name: "IX_heroDbSet_BaseEntityid",
                table: "heroDbSet");

            migrationBuilder.DropColumn(
                name: "BaseEntityid",
                table: "moduleDbSet");

            migrationBuilder.DropColumn(
                name: "BaseEntityid",
                table: "heroDbSet");
        }
    }
}
