using Microsoft.EntityFrameworkCore.Migrations;

namespace Keith_Advanced_deel2.Migrations
{
    public partial class houseInContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_House_HouseId",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_House",
                table: "House");

            migrationBuilder.RenameTable(
                name: "House",
                newName: "Houses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Houses",
                table: "Houses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Houses_HouseId",
                table: "Persons",
                column: "HouseId",
                principalTable: "Houses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Houses_HouseId",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Houses",
                table: "Houses");

            migrationBuilder.RenameTable(
                name: "Houses",
                newName: "House");

            migrationBuilder.AddPrimaryKey(
                name: "PK_House",
                table: "House",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_House_HouseId",
                table: "Persons",
                column: "HouseId",
                principalTable: "House",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
