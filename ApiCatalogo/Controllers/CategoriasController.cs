using ApiCatalogo.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiCatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            return _context.Categoria.ToList();
        }

        [HttpGet("CategoriasProdutos")]
        public ActionResult<IEnumerable<Categoria>> GetCategoriaProdutos()
        {
            return _context.Categoria.Include(p => p.Produtos).ToList();

            /*O método get acima irá apresentar um erro que iremos solucionar na próxima aula, porém foi construído para que o método
             GET inclua a lista de produtos junto a sua requisição, por isso utilizamos a função .Include(lambda).*/
        }

        [HttpGet("{id:int}", Name = "ObterCategoria")]
        public ActionResult<Categoria> Get(int id) 
        {
            var categoria = _context.Categoria.FirstOrDefault(p => p.CategoriaId == id);

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

            _context.Categoria.Add(categoria);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterCategoria", new { id = categoria.CategoriaId }, categoria);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Categoria categoria) 
        {
            if (id != categoria.CategoriaId) 
            {
                return BadRequest("Categoria invalida !");
            }

            _context.Entry(categoria).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(categoria);
        }

        [HttpDelete("{id:int}")]
        public ActionResult<Categoria> Delete(int id) 
        {
            var categoria = _context.Categoria.FirstOrDefault(p => p.CategoriaId == id);
            if (categoria is null) 
            {
                return NotFound("Categoria não encontrada !");
            }

            _context.Categoria.Remove(categoria);
            _context.SaveChanges();
            return Ok(categoria);
        }
    }
}
