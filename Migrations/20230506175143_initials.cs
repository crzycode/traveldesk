using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace traveldesk.Migrations
{
    public partial class initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "amount",
                table: "multiples",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "authorized_by",
                table: "multiples",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "company_name",
                table: "multiples",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "created_by",
                table: "multiples",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "debited_to",
                table: "multiples",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "emp_id",
                table: "multiples",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "file_name",
                table: "multiples",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "file_size",
                table: "multiples",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "inv_rec_date",
                table: "multiples",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "invoice",
                table: "multiples",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "invoiceType",
                table: "multiples",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "invoice_number",
                table: "multiples",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "remark",
                table: "multiples",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "statement",
                table: "multiples",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "vendor_name",
                table: "multiples",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "amount",
                table: "multiples");

            migrationBuilder.DropColumn(
                name: "authorized_by",
                table: "multiples");

            migrationBuilder.DropColumn(
                name: "company_name",
                table: "multiples");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "multiples");

            migrationBuilder.DropColumn(
                name: "debited_to",
                table: "multiples");

            migrationBuilder.DropColumn(
                name: "emp_id",
                table: "multiples");

            migrationBuilder.DropColumn(
                name: "file_name",
                table: "multiples");

            migrationBuilder.DropColumn(
                name: "file_size",
                table: "multiples");

            migrationBuilder.DropColumn(
                name: "inv_rec_date",
                table: "multiples");

            migrationBuilder.DropColumn(
                name: "invoice",
                table: "multiples");

            migrationBuilder.DropColumn(
                name: "invoiceType",
                table: "multiples");

            migrationBuilder.DropColumn(
                name: "invoice_number",
                table: "multiples");

            migrationBuilder.DropColumn(
                name: "remark",
                table: "multiples");

            migrationBuilder.DropColumn(
                name: "statement",
                table: "multiples");

            migrationBuilder.DropColumn(
                name: "vendor_name",
                table: "multiples");
        }
    }
}
