using Microsoft.EntityFrameworkCore.Migrations;

namespace MarcotsContactApp.Migrations
{
    public partial class _0200516052925_contactStatusRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_ContactStatus",
                table: "Person");

            migrationBuilder.DropTable(
                name: "ContactStatus");

            migrationBuilder.DropIndex(
                name: "IX_Person_ContactStatusID",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "ContactStatusID",
                table: "Person");

            migrationBuilder.AddColumn<int>(
                name: "ContactStatus",
                table: "Person",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactStatus",
                table: "Person");

            migrationBuilder.AddColumn<int>(
                name: "ContactStatusID",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContactStatus",
                columns: table => new
                {
                    ContactStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactStatusDesc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactStatus", x => x.ContactStatusId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_ContactStatusID",
                table: "Person",
                column: "ContactStatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_ContactStatus",
                table: "Person",
                column: "ContactStatusID",
                principalTable: "ContactStatus",
                principalColumn: "ContactStatusId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
