using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiCatalogo.Models;

public class Produto
{
    public int ProdutoId { get; set; } //Nome do método + sufixo Id para o EF Core entender que é uma PK

    [Required]
    [StringLength(80)]
    public required string Nome { get; set; }
    [Required]
    [StringLength(300)]
    public required string Descricao { get; set; }
    [Required]
    [Column(TypeName="decimal(10,2)")]
    public required decimal Preco { get; set; }
    [Required]
    [StringLength(300)]
    public required string ImagemUrl { get; set; }
    public required float Estoque { get; set; }
    public required DateTime DataCadastro { get; set; }

    public int categoriaId { get; set; }//Mapear a coluna CategoriaId que será criada na tabela Produto

    [JsonIgnore]
    public Categoria? Categoria { get; set; }
    /*-Definindo relacionamento entre as tabelas produto e categoria, onde cada produto tem uma categoria.
     *-Utilizando o [JsonIgnore] para essa propriedade acima ser ignorada na serialização/desserialização (para que os atributos da classe
     *'Categoria' não sejam inseridos no método 'POST' de produtos).*/
}