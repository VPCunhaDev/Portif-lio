using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)//mb é apenas o nome que estamos dando para uma instância do tipo MigrationBuilder
        {
            mb.Sql("INSERT INTO categoria (Nome, ImagemUrl) VALUES ('BEBIDAS','BEBIDAS.JPG')");
            mb.Sql("INSERT INTO categoria (Nome, ImagemUrl) VALUES ('LANCHES','LANCHES.JPG')");
            mb.Sql("INSERT INTO categoria (Nome, ImagemUrl) VALUES ('SOBREMESAS','SOBREMESAS.JPG')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM categoria");
        }
    }
}
