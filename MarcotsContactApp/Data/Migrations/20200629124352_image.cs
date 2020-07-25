using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarcotsContactApp.Data.Migrations
{
    public partial class image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_MarStatus_StatusId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_FamAddress_Adddress_AddrId",
                table: "FamAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adddress",
                table: "Adddress");

            migrationBuilder.RenameTable(
                name: "Adddress",
                newName: "Address");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Contact",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contact",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Kids",
                table: "Contact",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Contact",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Contact",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageContentType",
                table: "Contact",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "AddrId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_MarStatus_StatusId",
                table: "Contact",
                column: "StatusId",
                principalTable: "MarStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FamAddress_Address_AddrId",
                table: "FamAddress",
                column: "AddrId",
                principalTable: "Address",
                principalColumn: "AddrId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_MarStatus_StatusId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_FamAddress_Address_AddrId",
                table: "FamAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "ImageContentType",
                table: "Contact");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Adddress");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Contact",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "Kids",
                table: "Contact",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adddress",
                table: "Adddress",
                column: "AddrId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_MarStatus_StatusId",
                table: "Contact",
                column: "StatusId",
                principalTable: "MarStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FamAddress_Adddress_AddrId",
                table: "FamAddress",
                column: "AddrId",
                principalTable: "Adddress",
                principalColumn: "AddrId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
