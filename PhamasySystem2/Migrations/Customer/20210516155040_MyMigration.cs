using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhamasySystem2.Migrations.Customer
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CId = table.Column<Guid>(nullable: false),
                    CName = table.Column<string>(nullable: true),
                    PNum = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    NIC = table.Column<string>(nullable: true),
                    AllergyMedicines = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
