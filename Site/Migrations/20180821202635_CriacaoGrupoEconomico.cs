using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Site.Migrations
{
    public partial class CriacaoGrupoEconomico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GruposEconomicos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CNPJ = table.Column<string>(nullable: true),
                    CodigoMunicipio = table.Column<int>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataFundacao = table.Column<DateTime>(nullable: false),
                    InscricaoMunicipal = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    NomeFantasia = table.Column<string>(nullable: true),
                    Situacao = table.Column<string>(nullable: true),
                    Uf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GruposEconomicos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GruposEconomicos");
        }
    }
}
