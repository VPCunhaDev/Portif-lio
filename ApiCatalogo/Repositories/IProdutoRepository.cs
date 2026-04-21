using ApiCatalogo.Models;

namespace ApiCatalogo.Repositories
{
    public interface IProdutoRepository
    {
        //Todos os membros de uma interface são públicos, não há necessidade de definir os métodos a seguir com 'PUBLIC'

        IEnumerable<Produto> GetProdutos();
        //Buscando todos os produtos ao mesmo tempo.

        Produto GetProduto(int id);
        //Buscando um produto por um ID específico

        Produto Create(Produto produto);
        //Acima, método Create recebe um parâmetro 'produto' do tipo Produto

        Produto Update(Produto produto);
        //Atualizando um produto

        Produto Delete(int id);
        //Deletando um produto
    }
}
