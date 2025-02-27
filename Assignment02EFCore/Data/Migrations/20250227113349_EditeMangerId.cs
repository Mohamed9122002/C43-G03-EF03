using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment02EFCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditeMangerId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_MangerId",
                schema: "dbo",
                table: "Departments");

            migrationBuilder.AlterColumn<int>(
                name: "MangerId",
                schema: "dbo",
                table: "Departments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_MangerId",
                schema: "dbo",
                table: "Departments",
                column: "MangerId",
                unique: true,
                filter: "[MangerId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_MangerId",
                schema: "dbo",
                table: "Departments");

            migrationBuilder.AlterColumn<int>(
                name: "MangerId",
                schema: "dbo",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_MangerId",
                schema: "dbo",
                table: "Departments",
                column: "MangerId",
                unique: true);
        }
    }
}
