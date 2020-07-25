using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarcotsContactApp.Data.Migrations
{
    public partial class initialappDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adddress",
                columns: table => new
                {
                    AddrId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adddress", x => x.AddrId);
                });

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    DayId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayNum = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.DayId);
                });

            migrationBuilder.CreateTable(
                name: "MarStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Months",
                columns: table => new
                {
                    MonthId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Months", x => x.MonthId);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    MyPicture = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    MidName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    NickName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Kids = table.Column<int>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    StatusId = table.Column<int>(nullable: true),
                    BirthDay = table.Column<int>(nullable: true),
                    BirthMonth = table.Column<int>(nullable: true),
                    InsertedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ContactStatus = table.Column<int>(nullable: false),
                    BirthDayNavigationDayId = table.Column<int>(nullable: true),
                    BirthMonthNavigationMonthId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Contact_Days_BirthDayNavigationDayId",
                        column: x => x.BirthDayNavigationDayId,
                        principalTable: "Days",
                        principalColumn: "DayId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contact_Months_BirthMonthNavigationMonthId",
                        column: x => x.BirthMonthNavigationMonthId,
                        principalTable: "Months",
                        principalColumn: "MonthId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contact_MarStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "MarStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FamAddress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddrId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FamAddress_Adddress_AddrId",
                        column: x => x.AddrId,
                        principalTable: "Adddress",
                        principalColumn: "AddrId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FamAddress_Contact_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Contact",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FamilyPhoto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(nullable: true),
                    PhotoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyPhoto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FamilyPhoto_Contact_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Contact",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FamilyPhoto_Photo_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_BirthDayNavigationDayId",
                table: "Contact",
                column: "BirthDayNavigationDayId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_BirthMonthNavigationMonthId",
                table: "Contact",
                column: "BirthMonthNavigationMonthId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_StatusId",
                table: "Contact",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_FamAddress_AddrId",
                table: "FamAddress",
                column: "AddrId");

            migrationBuilder.CreateIndex(
                name: "IX_FamAddress_PersonId",
                table: "FamAddress",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyPhoto_PersonId",
                table: "FamilyPhoto",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyPhoto_PhotoId",
                table: "FamilyPhoto",
                column: "PhotoId");
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
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "Months");

            migrationBuilder.DropTable(
                name: "MarStatus");
        }
    }
}
