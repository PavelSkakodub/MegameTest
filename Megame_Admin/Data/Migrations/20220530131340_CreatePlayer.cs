using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Megame_Admin.Migrations
{
    public partial class CreatePlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "Players",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "BaseUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 30, 13, 13, 39, 976, DateTimeKind.Utc).AddTicks(3474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 27, 11, 17, 35, 147, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 30, 13, 13, 39, 962, DateTimeKind.Utc).AddTicks(569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 27, 11, 17, 35, 70, DateTimeKind.Utc).AddTicks(7592));

            migrationBuilder.CreateTable(
                name: "PlayerMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerMessages_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_Token",
                table: "Players",
                column: "Token");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerMessages_PlayerId",
                table: "PlayerMessages",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerMessages");

            migrationBuilder.DropIndex(
                name: "IX_Players_Token",
                table: "Players");

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "Players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "BaseUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 27, 11, 17, 35, 147, DateTimeKind.Utc).AddTicks(804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 30, 13, 13, 39, 976, DateTimeKind.Utc).AddTicks(3474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 27, 11, 17, 35, 70, DateTimeKind.Utc).AddTicks(7592),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 30, 13, 13, 39, 962, DateTimeKind.Utc).AddTicks(569));
        }
    }
}
