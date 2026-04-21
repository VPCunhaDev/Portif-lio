using ApiCatalogo.Context;
using ApiCatalogo.Models;
using ApiCatalogo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _repository;

        //Abaixo, gerando o construtor que irá acessar a interface com os métodos
        public ProdutosController(IProdutoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            var produtos = _repository.GetProdutos();
            return Ok(produtos);
        }
        /*Acima, utilizamos o ActionResult, que pode nos trazer dois tipos de retorno diferentes, no caso cima, sendo eles produtos como uma
         lista e também o tipo NotFound, caso contrário não poderíamos ter esses dois retornos de TIPOS diferentes*/

        [HttpGet("{id:int}", Name="ObterProduto")]
        public ActionResult<Produto> Get(int id)
        {
            var produto = _repository.GetProduto(id);
            if (produto is null)
            {
                return NotFound("Produto com ID informado não encontrado");
            }
            return Ok(produto);
        }

        [HttpPost] //Criando um novo produto
        public ActionResult<Produto> Post(Produto produto) //Action result indicando dois métodos de retorno
        {
            if (produto is null) {
                return NotFound("Valor não encontrado !");
            }
            var ProdutoCriado = _repository.Create(produto);

            return new CreatedAtRouteResult("ObterProduto", new { id = ProdutoCriado.ProdutoId }, ProdutoCriado);
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
                return BadRequest("Produto inválido !");
            }
            _repository.Update(produto);
            return Ok(produto);//retorna o status 200
        }


        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id) 
        {
            var produto = _repository.GetProduto(id);

            if (produto is null)
            {
                return NotFound("Produto não encontrado !");
            }
            var ExcluirCategoria = _repository.Delete(id);
            return Ok(produto);
        }
    }
}
