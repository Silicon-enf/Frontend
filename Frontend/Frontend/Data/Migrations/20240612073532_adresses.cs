using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frontend.Migrations
{
    /// <inheritdoc />
    public partial class Adresses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AdressEntity_AdressId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdressEntity",
                table: "AdressEntity");

            migrationBuilder.RenameTable(
                name: "AdressEntity",
                newName: "Adresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adresses",
                table: "Adresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Adresses_AdressId",
                table: "AspNetUsers",
                column: "AdressId",
                principalTable: "Adresses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Adresses_AdressId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adresses",
                table: "Adresses");

            migrationBuilder.RenameTable(
                name: "Adresses",
                newName: "AdressEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdressEntity",
                table: "AdressEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AdressEntity_AdressId",
                table: "AspNetUsers",
                column: "AdressId",
                principalTable: "AdressEntity",
                principalColumn: "Id");
        }
    }
}
