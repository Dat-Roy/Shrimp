using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShrimpPond.Persistant.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alarms_Farms_Id",
                table: "Alarms");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Alarms",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Alarms_FarmID",
                table: "Alarms",
                column: "FarmID");

            migrationBuilder.AddForeignKey(
                name: "FK_Alarms_Farms_FarmID",
                table: "Alarms",
                column: "FarmID",
                principalTable: "Farms",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alarms_Farms_FarmID",
                table: "Alarms");

            migrationBuilder.DropIndex(
                name: "IX_Alarms_FarmID",
                table: "Alarms");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Alarms",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_Alarms_Farms_Id",
                table: "Alarms",
                column: "Id",
                principalTable: "Farms",
                principalColumn: "Id");
        }
    }
}
