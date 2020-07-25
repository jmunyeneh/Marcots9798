using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarcotsContactApp.Migrations
{
    public partial class contactStatusRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adddress",
                columns: table => new
                {
                    AddrID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address1 = table.Column<string>(maxLength: 50, nullable: true),
                    Address2 = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    State = table.Column<string>(maxLength: 50, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: true),
                    PostalCode = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adddress", x => x.AddrID);
                });

            migrationBuilder.CreateTable(
                name: "ContactStatus",
                columns: table => new
                {
                    ContactStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactStatusDesc = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactStatus", x => x.ContactStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    DayID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayNum = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.DayID);
                });

            migrationBuilder.CreateTable(
                name: "MarStatus",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarStatus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Months",
                columns: table => new
                {
                    MonthID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Months", x => x.MonthID);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    MyPicture = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerID = table.Column<string>(maxLength: 100, nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    MidName = table.Column<string>(maxLength: 3, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    NickName = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    Telephone = table.Column<string>(maxLength: 14, nullable: true),
                    Kids = table.Column<int>(nullable: true),
                    Email = table.Column<string>(maxLength: 40, nullable: true),
                    Occupation = table.Column<string>(maxLength: 100, nullable: true),
                    StatusID = table.Column<int>(nullable: true),
                    BirthDay = table.Column<int>(nullable: true),
                    BirthMonth = table.Column<int>(nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ContactStatusID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonID);
                    table.ForeignKey(
                        name: "FK_Person_Days",
                        column: x => x.BirthDay,
                        principalTable: "Days",
                        principalColumn: "DayID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Months",
                        column: x => x.BirthMonth,
                        principalTable: "Months",
                        principalColumn: "MonthID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_ContactStatus",
                        column: x => x.ContactStatusID,
                        principalTable: "ContactStatus",
                        principalColumn: "ContactStatusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_MarStatus",
                        column: x => x.StatusID,
                        principalTable: "MarStatus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FamAddress",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddrID = table.Column<int>(nullable: false),
                    PersonID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamAddress", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FamAddress_Adddress",
                        column: x => x.AddrID,
                        principalTable: "Adddress",
                        principalColumn: "AddrID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FamAddress_Person",
                        column: x => x.PersonID,
                        principalTable: "Person",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FamilyPhoto",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonID = table.Column<int>(nullable: true),
                    PhotoID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyPhoto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FamilyPhoto_Person",
                        column: x => x.PersonID,
                        principalTable: "Person",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FamilyPhoto_Photo",
                        column: x => x.PhotoID,
                        principalTable: "Photo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FamAddress_AddrID",
                table: "FamAddress",
                column: "AddrID");

            migrationBuilder.CreateIndex(
                name: "IX_FamAddress_PersonID",
                table: "FamAddress",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyPhoto_PersonID",
                table: "FamilyPhoto",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyPhoto_PhotoID",
                table: "FamilyPhoto",
                column: "PhotoID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_BirthDay",
                table: "Person",
                column: "BirthDay");

            migrationBuilder.CreateIndex(
                name: "IX_Person_BirthMonth",
                table: "Person",
                column: "BirthMonth");

            migrationBuilder.CreateIndex(
                name: "IX_Person_ContactStatusID",
                table: "Person",
                column: "ContactStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_StatusID",
                table: "Person",
                column: "StatusID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FamAddress");

            migrationBuilder.DropTable(
                name: "FamilyPhoto");

            migrationBuilder.DropTable(
                name: "Adddress");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "Months");

            migrationBuilder.DropTable(
                name: "ContactStatus");

            migrationBuilder.DropTable(
                name: "MarStatus");
        }
    }
}
