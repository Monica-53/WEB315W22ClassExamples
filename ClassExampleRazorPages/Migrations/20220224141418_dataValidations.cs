using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassExampleRazorPages.Migrations
{
    public partial class dataValidations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Car",
                type: "TEXT",
                maxLength: 31,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CarModel",
                table: "Car",
                type: "TEXT",
                maxLength: 63,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CarMake",
                table: "Car",
                type: "TEXT",
                maxLength: 31,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Car",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 31);

            migrationBuilder.AlterColumn<string>(
                name: "CarModel",
                table: "Car",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 63);

            migrationBuilder.AlterColumn<string>(
                name: "CarMake",
                table: "Car",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 31);
        }
    }
}
