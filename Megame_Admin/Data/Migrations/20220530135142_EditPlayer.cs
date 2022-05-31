using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Megame_Admin.Migrations
{
    public partial class EditPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MessageType",
                table: "PlayerMessages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "PlayerMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "BaseUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 30, 13, 51, 40, 378, DateTimeKind.Utc).AddTicks(7472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 30, 13, 13, 39, 976, DateTimeKind.Utc).AddTicks(3474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 30, 13, 51, 40, 321, DateTimeKind.Utc).AddTicks(1419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 30, 13, 13, 39, 962, DateTimeKind.Utc).AddTicks(569));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageType",
                table: "PlayerMessages");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "PlayerMessages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "BaseUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 30, 13, 13, 39, 976, DateTimeKind.Utc).AddTicks(3474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 30, 13, 51, 40, 378, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 30, 13, 13, 39, 962, DateTimeKind.Utc).AddTicks(569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 30, 13, 51, 40, 321, DateTimeKind.Utc).AddTicks(1419));
        }
    }
}
