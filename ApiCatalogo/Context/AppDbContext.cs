using Microsoft.EntityFrameworkCore;
using ApiCatalogo.Models;

namespace ApiCatalogo.Context;

public class AppDbContext : DbContext
{
    /*Abaixo, iremos definir um construtor  com um parâmetro (DbContextOptions <tipo de dado que é o AppDbContext> options
     
     OBS: options é utilizado para configurar o contexto do banco de dados, como string de conexão e outras configurações específicas*/

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
            
    }

    public DbSet<Categoria> Categoria { get; set; } //Objeto do tipo DbSet do tipo Categoria 
    public DbSet <Produto> Produto { get; set; } //Objeto do tipo DbSet do tipo Produto 

    //OBS: DbSet é a representação de uma tabela no BD.
}