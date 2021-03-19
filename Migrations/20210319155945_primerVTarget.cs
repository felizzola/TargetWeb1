using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TargetWeb1.Migrations
{
    public partial class primerVTarget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "datetime", nullable: false),
                    UrlImagen = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: false),
                    Codigo = table.Column<string>(type: "varchar(8) CHARACTER SET utf8mb4", maxLength: 8, nullable: false),
                    Nombre = table.Column<string>(type: "varchar(30) CHARACTER SET utf8mb4", maxLength: 30, nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(120) CHARACTER SET utf8mb4", maxLength: 120, nullable: false),
                    StockUnidades = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    StockEnBulto = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    PrecioSugMinorista = table.Column<decimal>(type: "decimal(65,30)", maxLength: 30, nullable: false),
                    PrecioSugMayorista = table.Column<decimal>(type: "decimal(65,30)", maxLength: 30, nullable: false),
                    PrecioSugMeLi = table.Column<decimal>(type: "decimal(65,30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "Idx_Name",
                table: "UserGroups",
                column: "Codigo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserGroups");
        }
    }
}
