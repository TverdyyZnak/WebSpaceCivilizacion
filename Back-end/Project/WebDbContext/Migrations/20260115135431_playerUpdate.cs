using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDbContext.Migrations
{
    /// <inheritdoc />
    public partial class playerUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_heroDbSet_armorDbSet_armorid",
                table: "heroDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_heroDbSet_weaponDbSet_weaponid",
                table: "heroDbSet");

            migrationBuilder.DropTable(
                name: "armorDbSet");

            migrationBuilder.DropTable(
                name: "materialDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_weaponDbSet",
                table: "weaponDbSet");

            migrationBuilder.RenameTable(
                name: "weaponDbSet",
                newName: "ItemEntity");

            migrationBuilder.AlterColumn<int>(
                name: "minStrong",
                table: "ItemEntity",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "addDmg",
                table: "ItemEntity",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "ItemEntity",
                type: "varchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "PlayerEntityid",
                table: "ItemEntity",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<int>(
                name: "addHp",
                table: "ItemEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "countOfMaterials",
                table: "ItemEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "materialType",
                table: "ItemEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "minAgility",
                table: "ItemEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemEntity",
                table: "ItemEntity",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemEntity_PlayerEntityid",
                table: "ItemEntity",
                column: "PlayerEntityid");

            migrationBuilder.AddForeignKey(
                name: "FK_heroDbSet_ItemEntity_armorid",
                table: "heroDbSet",
                column: "armorid",
                principalTable: "ItemEntity",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_heroDbSet_ItemEntity_weaponid",
                table: "heroDbSet",
                column: "weaponid",
                principalTable: "ItemEntity",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemEntity_playerDbSet_PlayerEntityid",
                table: "ItemEntity",
                column: "PlayerEntityid",
                principalTable: "playerDbSet",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_heroDbSet_ItemEntity_armorid",
                table: "heroDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_heroDbSet_ItemEntity_weaponid",
                table: "heroDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemEntity_playerDbSet_PlayerEntityid",
                table: "ItemEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemEntity",
                table: "ItemEntity");

            migrationBuilder.DropIndex(
                name: "IX_ItemEntity_PlayerEntityid",
                table: "ItemEntity");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "ItemEntity");

            migrationBuilder.DropColumn(
                name: "PlayerEntityid",
                table: "ItemEntity");

            migrationBuilder.DropColumn(
                name: "addHp",
                table: "ItemEntity");

            migrationBuilder.DropColumn(
                name: "countOfMaterials",
                table: "ItemEntity");

            migrationBuilder.DropColumn(
                name: "materialType",
                table: "ItemEntity");

            migrationBuilder.DropColumn(
                name: "minAgility",
                table: "ItemEntity");

            migrationBuilder.RenameTable(
                name: "ItemEntity",
                newName: "weaponDbSet");

            migrationBuilder.AlterColumn<int>(
                name: "minStrong",
                table: "weaponDbSet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "addDmg",
                table: "weaponDbSet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_weaponDbSet",
                table: "weaponDbSet",
                column: "id");

            migrationBuilder.CreateTable(
                name: "armorDbSet",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    addHp = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    minAgility = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_armorDbSet", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "materialDbSet",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    countOfMaterials = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    materialType = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materialDbSet", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_heroDbSet_armorDbSet_armorid",
                table: "heroDbSet",
                column: "armorid",
                principalTable: "armorDbSet",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_heroDbSet_weaponDbSet_weaponid",
                table: "heroDbSet",
                column: "weaponid",
                principalTable: "weaponDbSet",
                principalColumn: "id");
        }
    }
}
