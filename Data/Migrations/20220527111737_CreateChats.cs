using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Megame_Admin.Migrations
{
    public partial class CreateChats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersChats");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "BaseUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 27, 11, 17, 35, 147, DateTimeKind.Utc).AddTicks(804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 25, 8, 15, 19, 205, DateTimeKind.Utc).AddTicks(1636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 27, 11, 17, 35, 70, DateTimeKind.Utc).AddTicks(7592),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 25, 8, 15, 19, 185, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.CreateTable(
                name: "ChatUserIdentity",
                columns: table => new
                {
                    ChatsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatUserIdentity", x => new { x.ChatsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ChatUserIdentity_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChatUserIdentity_Chats_ChatsId",
                        column: x => x.ChatsId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChatUserIdentity_UsersId",
                table: "ChatUserIdentity",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatUserIdentity");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "BaseUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 25, 8, 15, 19, 205, DateTimeKind.Utc).AddTicks(1636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 27, 11, 17, 35, 147, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 25, 8, 15, 19, 185, DateTimeKind.Utc).AddTicks(9775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 27, 11, 17, 35, 70, DateTimeKind.Utc).AddTicks(7592));

            migrationBuilder.CreateTable(
                name: "UsersChats",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersChats", x => new { x.UserId, x.ChatId });
                    table.ForeignKey(
                        name: "FK_UsersChats_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersChats_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersChats_ChatId",
                table: "UsersChats",
                column: "ChatId");
        }
    }
}
