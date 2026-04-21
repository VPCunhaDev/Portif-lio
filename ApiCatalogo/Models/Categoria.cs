using System.Collections.ObjectModel;//Para inicializar a coleção de produtos
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiCatalogo.Models;

public class Categoria
{
    //Inicializando a coleção
    public Categoria()
    {
         Produtos = new Collection<Produto>();
    }


    //Ao digitar prop + tab tab ele já gera um método get e set public do tipo int que só precisaremos alterar o nome
    public int CategoriaId { get; set; }
    //Ao adicionar o nome do método + Id, o EF Core entende que esse método é um atributo identificador quando for criar a tabela

    [Required]
    [StringLength(80)]
    public required string Nome { get; set; }

    [Required]
    [StringLength(300)]
    public required string ImagemUrl { get; set; }


    [JsonIgnore]
    public ICollection<Produto> Produtos { get; set; }
    /*Definindo que uma categoria terá uma coleção de produtos
     
    Quando definimos uma coleção em uma classe, é uma boa prática inicializar a coleção (inicializado no início da classe),
    pois é de responsabilidade da classe onde definimos a coleção inicializá-la..
     */
}
