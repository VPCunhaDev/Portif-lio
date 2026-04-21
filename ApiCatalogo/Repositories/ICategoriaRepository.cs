using ApiCatalogo.Models;

namespace ApiCatalogo.Repositories
{
    public interface ICategoriaRepository
    {
        //Todos os membros de uma interface são públicos, e por isso não iremos definir abaixo eles com o public

        IEnumerable<Categoria> GetCategorias();
        Categoria GetCategoria(int id);
        //Acima temos um parâmetro ID, que vai ser o ID da categoria que queremos retornar, ou seja, um objeto do tipo categoria que irá ser
        //selecionado por conta do ID que iremos inserir


        /*Como sabemos que estamos lidando com a manipulação de alguns objetos, iremos criar o Create sem referenciar Categoria, como 
         realizamos no objeto acima por exemplo, pois sabemos que estamos criando um objeto do tipo Categoria, e é importante seguirmos um
        padrão em todo o projeto, seja definindo todos os membros com o sufixo categoria ou não, e utilizá-los de forma implícita.
        
         Realizando a configuração abaixo, Create do tipo Categoria recebe um parâmetro categoria do tipo Categoria.*/
        Categoria Create(Categoria categoria);

        //O mesmo informado acima para o update
        Categoria Update(Categoria categoria);

        //Para realizarmos o delete, precisamos de um parâmetro com o ID para referência
        Categoria Delete(int id);

        //Após a definição da interface acima, iremos criar a classe concreta CategoriaRepository
    }
}
