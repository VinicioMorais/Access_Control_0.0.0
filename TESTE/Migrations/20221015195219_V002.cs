using Microsoft.EntityFrameworkCore.Migrations;

namespace TESTE.Migrations
{
    public partial class V002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Edificios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    CNPJ = table.Column<string>(nullable: true),
                    Blocos = table.Column<int>(nullable: false),
                    Apartamentos = table.Column<int>(nullable: false),
                    Endereço = table.Column<string>(nullable: false),
                    Bairro = table.Column<string>(nullable: false),
                    Cidade = table.Column<string>(nullable: false),
                    Pais = table.Column<string>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(nullable: false),
                    CEP = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edificios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Edificios");
        }
    }
}
