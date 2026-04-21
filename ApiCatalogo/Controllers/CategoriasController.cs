using ApiCatalogo.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiCatalogo.Models;
using Microsoft.EntityFrameworkCore;
using ApiCatalogo.Repositories;

namespace ApiCatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaRepository _repository;

        public CategoriasController(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            /*Com o ActionResult, nós conseguimos retornar para o usuário código de status HTTP, como podemos ver abaixo
             assim que executarmos o método Action GET e ele nos retornar as categorias, também irá nos retornar o código
            HTTP 200, ou seja, que nossa requisição foi atendida com sucesso.*/
            var categorias = _repository.GetCategorias();
            return Ok(categorias);
        }

        //[HttpGet("CategoriasProdutos")]
        //public ActionResult<IEnumerable<Categoria>> GetCategoriaProdutos()
        //{
        //    var  _context.Categoria.Include(p => p.Produtos).ToList();

        //    /*O método get acima irá apresentar um erro que iremos solucionar na próxima aula, porém foi construído para que o método
        //     GET inclua a lista de produtos junto a sua requisição, por isso utilizamos a função .Include(lambda).*/
        //}

        [HttpGet("{id:int}", Name = "ObterCategoria")]
        public ActionResult<Categoria> Get(int id) 
        {
            var categoria = _repository.GetCategoria(id);

            if (categoria == null) 
            {
                return NotFound("Categoria não encontrada !");
            }

            return Ok(categoria);
        }

        [HttpPost]
        public ActionResult Post (Categoria categoria) 
        {
            if (categoria is null) 
            {
                return BadRequest("Insira um valor de categoria válido !");
            }

            var CategoriaCriada = _repository.Create(categoria);

            return new CreatedAtRouteResult("ObterCategoria", new { id = CategoriaCriada.CategoriaId }, CategoriaCriada);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Categoria categoria) 
        {
            if (id != categoria.CategoriaId) 
            {
                return BadRequest("Categoria invalida !");
            }

            _repository.Update(categoria);
            return Ok(categoria);
        }

        [HttpDelete("{id:int}")]
        public ActionResult<Categoria> Delete(int id) 
        {
            var categoria = _repository.GetCategoria(id);

            if (categoria is null) 
            {
                return NotFound("Categoria não encontrada !");
            }

            var ExcluirCategoria = _repository.Delete(id);
            return Ok(categoria);
        }
    }
}
