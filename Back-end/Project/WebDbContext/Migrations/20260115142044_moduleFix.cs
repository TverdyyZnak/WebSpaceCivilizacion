using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDbContext.Migrations
{
    /// <inheritdoc />
    public partial class moduleFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BusterModuleEntityid",
                table: "heroDbSet",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "EnergyModuleEntityid",
                table: "heroDbSet",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "MedicalModuleEntityid",
                table: "heroDbSet",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_heroDbSet_BusterModuleEntityid",
                table: "heroDbSet",
                column: "BusterModuleEntityid");

            migrationBuilder.CreateIndex(
                name: "IX_heroDbSet_EnergyModuleEntityid",
                table: "heroDbSet",
                column: "EnergyModuleEntityid");

            migrationBuilder.CreateIndex(
                name: "IX_heroDbSet_MedicalModuleEntityid",
                table: "heroDbSet",
                column: "MedicalModuleEntityid");

            migrationBuilder.AddForeignKey(
                name: "FK_heroDbSet_moduleDbSet_BusterModuleEntityid",
                table: "heroDbSet",
                column: "BusterModuleEntityid",
                principalTable: "moduleDbSet",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_heroDbSet_moduleDbSet_EnergyModuleEntityid",
                table: "heroDbSet",
                column: "EnergyModuleEntityid",
                principalTable: "moduleDbSet",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_heroDbSet_moduleDbSet_MedicalModuleEntityid",
                table: "heroDbSet",
                column: "MedicalModuleEntityid",
                principalTable: "moduleDbSet",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_heroDbSet_moduleDbSet_BusterModuleEntityid",
                table: "heroDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_heroDbSet_moduleDbSet_EnergyModuleEntityid",
                table: "heroDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_heroDbSet_moduleDbSet_MedicalModuleEntityid",
                table: "heroDbSet");

            migrationBuilder.DropIndex(
                name: "IX_heroDbSet_BusterModuleEntityid",
                table: "heroDbSet");

            migrationBuilder.DropIndex(
                name: "IX_heroDbSet_EnergyModuleEntityid",
                table: "heroDbSet");

            migrationBuilder.DropIndex(
                name: "IX_heroDbSet_MedicalModuleEntityid",
                table: "heroDbSet");

            migrationBuilder.DropColumn(
                name: "BusterModuleEntityid",
                table: "heroDbSet");

            migrationBuilder.DropColumn(
                name: "EnergyModuleEntityid",
                table: "heroDbSet");

            migrationBuilder.DropColumn(
                name: "MedicalModuleEntityid",
                table: "heroDbSet");
        }
    }
}
