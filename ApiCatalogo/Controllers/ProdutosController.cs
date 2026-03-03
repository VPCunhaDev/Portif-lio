using ApiCatalogo.Context;
using ApiCatalogo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;

        //Abaixo, gerando o construtor que irá inserir a classe de contexto 
        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            var produtos = _context.Produto.ToList();
            if (produtos is null)
            {
                return NotFound("Produto não encontrado !");
            }
            return produtos;
        }
        /*Acima, utilizamos o ActionResult, que pode nos trazer dois tipos de retorno diferentes, no caso cima, sendo eles produtos como uma
         lista e também o tipo NotFound, caso contrário não poderíamos ter esses dois retornos de TIPOS diferentes*/

        [HttpGet("{id:int}", Name="ObterProduto")]
        public ActionResult<Produto> Get(int id)
        {
            var produto = _context.Produto.FirstOrDefault(p => p.ProdutoId == id);
            if (produto is null)
            {
                return NotFound("Produto com ID informado não encontrado");
            }
            return produto;
        }

        [HttpPost] //Criando um novo produto
        public ActionResult<Produto> Post(Produto produto) //Action result indicando dois métodos de retorno
        {
            if (produto is null) {
                return NotFound("Valor não encontrado !");
            }
            _context.Produto.Add(produto); //Método ADD vai incluir o produto no contexto do EF Core (na memória por enquanto)
            _context.SaveChanges();//Salvando as alterações que foram realizadas (novo produto sendo inserido, persiste os dados na tabela)

            return new CreatedAtRouteResult("ObterProduto", new { id = produto.ProdutoId }, produto);
            /*O objeto acima 'CreatedAtRouteResult é derivado do tipo ActionResult (tipo do método action),ele retorna o 201 no header,
             * indicando que o produto foi inserido com sucesso na tabela. Na sua definição, colocamos o nome da rota para obter esse produto
             seguido do ID que iremos incluir e informamos o objeto produto.
            
             Para acessarmos a rota definida acima, teremos que realizar a alteração no método HTTP GET por ID que construímos anteriormente,
            definindo nele uma rota nomeada, da seguinte forma:
            
            [HttpGet("{id:int}", Name="ObterProduto")]
             */
        }

        [HttpPut("{id:int}")]//Atualizar algum registro no BD
        public ActionResult Put(int id, Produto produto)
        {
            if (id != produto.ProdutoId)
            {
                return BadRequest();
            }

            /*Como estamos trabalhadno em um estado offline, o contexto precisa ser informado de que a entidade produto está em um estado
             modificado, utilizando o método entry definido abaixo*/

            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();
            //Para que essa entidade acima seja persistida (as alterações sejam salvas), utilizamos o método SaveChanges() aplicado no contexto acima

            return Ok(produto);//retorna o status 200
        }


        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id) 
        {
            var produto = _context.Produto.FirstOrDefault(p => p.ProdutoId == id);

            if (produto is null)
            {
                return NotFound("Produto não encontrado !");
            }

            _context.Produto.Remove(produto);
            _context.SaveChanges();

            return Ok(produto);
        }
    }
}
