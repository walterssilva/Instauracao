using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Corregedoria.Infra.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Instauracoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    CNPJCPF = table.Column<string>(type: "varchar(100)", nullable: true),
                    RG = table.Column<string>(type: "varchar(100)", nullable: true),
                    Orgao = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Procedimento = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Protocolo = table.Column<string>(type: "varchar(100)", nullable: true),
                    Objeto = table.Column<string>(type: "varchar(100)", nullable: true),
                    AtoNormativo = table.Column<string>(type: "varchar(100)", nullable: true),
                    DataPublicacao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    NumeroDIOE = table.Column<int>(type: "int", nullable: true),
                    AtoNormativoDecisao = table.Column<string>(type: "varchar(100)", nullable: true),
                    DataPublicacaoDecisao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    NumeroDIOEDecisao = table.Column<int>(type: "int", nullable: true),
                    Decisao = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    InfoAdd = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instauracoes", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instauracoes");
        }
    }
}
