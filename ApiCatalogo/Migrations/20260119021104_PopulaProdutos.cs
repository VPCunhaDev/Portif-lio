using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO produto (Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "VALUES ('Coca Cola Zero','Refrigerante Coca 350ml',5.45,'COCACOLA.JPG',50,now(),1)");
            mb.Sql("INSERT INTO produto (Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "VALUES ('Lanche de Atum','Lanche Atum c/ Maionese',8.50,'ATUM.JPG',10,now(),2)");
            mb.Sql("INSERT INTO produto (Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "VALUES ('Pudim 100g','Pudim Leite Condensado 100g',6.75,'PUDIM.JPG',20,now(),3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM produto");
        }
    }
}
