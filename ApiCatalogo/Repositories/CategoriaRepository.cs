using ApiCatalogo.Context;
using ApiCatalogo.Models;
using ApiCatalogo.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        //Acima, definimos a herança dos métodos/membros da interface que definimos anteriormente.

        /*Abaixo, iremos configurar a lógica de acesso a dados trazendo a propriedade do AppDbContext para a nossa classe concreta,
         após inserirmos o _context, iremos inserir também o seu construtor (abaixo).*/
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context) //Construtor criado
        {
            _context = context;
        }

        public IEnumerable<Categoria> GetCategorias()
        {
            return _context.Categoria.ToList();
            /*Acima, acessando o DB (_context), na tabela Categoria (criada na pasta Models), com a função ToList para adicionar
             * os dados retornados a uma lista.*/
        }
        public Categoria GetCategoria(int id)
        {
            return _context.Categoria.FirstOrDefault(c => c.CategoriaId == id);
            //Acima, se o FirstOrDefault não encontrar o valor pelo ID, irá nos retornar null
        }
        public Categoria Create(Categoria categoria)
        {
            //Comparando o valor de categoria
            if(categoria is null)
            {
                throw new ArgumentNullException(nameof(categoria));
                //Acima, lançando uma excessão de maneira explicita (ArgumentNullException(nameof(categoria));, indicando que o argumento
                //que estou recendo é nulo e nomeando o mesmo.
            }

            /*Abaixo, trabalhando com o contexto do EF Core
             
             O _context que criamos acima, ele gerencia o contexto na memória, ou seja, ele carrega primeiro os objetos na memória
            e para persistir os dados que estamos tratando no BD temos de realizar os seguintes passos a seguir:*/

            _context.Categoria.Add(categoria);
            //Acima, informando o EF Core que estamos adicionando na memória através do _context o objeto do tipo categoria da tabela Categoria

            //Abaixo, iremos persistir o objeto inserido acima no banco de dados
            _context.SaveChanges();

            return categoria; //Retornando categoria que acabamos de criar
        }
        public Categoria Update(Categoria categoria)
        {
            if (categoria is null)
            {
                throw new ArgumentNullException(nameof(categoria));
            }
            /*Abaixo, como já temos um objeto salvo no banco de dados, utilizamos a função Entry para avisar o EF Core que iremos mudar o 
             estado desse objeto já salvo para que ele possa ser alterado, exemplo:*/
            _context.Entry(categoria).State = EntityState.Modified;
            _context.SaveChanges();//Salvando as mudanças que realizamos em um objeto já existente no BD novamente.

            return categoria;//Retornando o objeto categoria que editamos.
        }
        public Categoria Delete(int id)
        {
            var categoria = _context.Categoria.Find(id);
            /*Acima, utilizamos a função Find, pois ele sempre busca na memória o parâmetro que estamos inserindo.
             OBS: ele busca apenas por chave primária, por isso acaba sendo utilizado para encontrar um objeto.
            
             OBS2: Criamos uma variável para obter o valor que procuramos com o Find.*/

            if (categoria is null)
            {
                throw new ArgumentNullException(nameof(categoria));//Configurando excessão
            }
            _context.Categoria.Remove(categoria);
            //Acima, informando para o EF Core o objeto que queremos remover

            _context.SaveChanges();
            //Persistindo a mudança do objeto no banco de dados

            return categoria;//Retornando o objeto que excluímos
        }
    }
}
