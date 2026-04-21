using Microsoft.EntityFrameworkCore;
using ApiCatalogo.Repositories;
using ApiCatalogo.Context;
using ApiCatalogo.Models;

namespace ApiCatalogo.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context) 
        {
            _context = context;
        }

        public IEnumerable<Produto> GetProdutos() 
        {
            return _context.Produto.ToList();
            //Acessando a tabela 'PRODUTO' através do construtor criado do tipo AppDbContext, e selecionando todos os produtos dela para uma lista
        }

        public Produto GetProduto(int id) 
        {
            return _context.Produto.FirstOrDefault(p => p.ProdutoId == id);
            //Acima, realizando a verificação no nosso BD com o ID do produto que inserimos acima (se existe), se não null será retornado
            //condição aplicada pelo FirstOrDefault (primeiro valor retornado ou um valor padrão (nulo).
        }

        public Produto Create(Produto produto)
        {
            if (produto is null) 
            {
                throw new ArgumentNullException(nameof(produto));
                /*Acima, verificando se o valor é nulo ou não, se positivo irá lançar uma exception pois o atributo 'produto' está nulo*/
            }

            _context.Produto.Add(produto);
            //Utilizando o EF Core e adicionando através do _context no nosso BD o valor inserido no atributo
            _context.SaveChanges();
            //Acima, persistindo no BD os dados.
            return produto;
        }

        public Produto Update(Produto produto)
        {
            if (produto is null)
            {
                throw new ArgumentException(nameof(produto));
            }

            _context.Entry(produto).State = EntityState.Modified;
            //Mudando o status do objeto selecionado em memória com o '....State = EntityState.Modified;'
            _context.SaveChanges();//Persistindo as alterações em BD

            return produto;
        }

        public Produto Delete (int id)
        {
            var produto = _context.Produto.Find(id);
            //Acima,criamos uma variável buscará a PK da tabela produto correspondente ao parâmetro ID quer iremos inserir

            if (produto is null)
            {
                throw new ArgumentException(nameof(produto));
            }
            _context.Produto.Remove(produto);
            //Carregando em memória o produto que iremos remover.
            _context.SaveChanges();
            //Persistindo no BD as modificações.
            return produto;
        }
    }
}
