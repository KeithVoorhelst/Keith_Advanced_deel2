using Microsoft.EntityFrameworkCore.Migrations;

namespace Keith_Advanced_deel2.Migrations
{
    public partial class houseidinperson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Persons_PersonId",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Persons",
                newName: "BirthDate");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Pets",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Persons_PersonId",
                table: "Pets",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Persons_PersonId",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Persons",
                newName: "DateOfBirth");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Pets",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Persons_PersonId",
                table: "Pets",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
