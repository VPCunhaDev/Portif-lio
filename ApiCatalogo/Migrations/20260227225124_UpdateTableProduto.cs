using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Produto",
                newName: "categoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto",
                newName: "IX_Produto_categoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_categoriaId",
                table: "Produto",
                column: "categoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Categoria_categoriaId",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "categoriaId",
                table: "Produto",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_categoriaId",
                table: "Produto",
                newName: "IX_Produto_CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
