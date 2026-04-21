using ApiCatalogo.Context;
using ApiCatalogo.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Abaixo, configurando a serialização em JSON para que ignore uma referência ciclica
builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Abaixo, configurando o sistema de injeção de dependência DI do projeto
builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
//builder.Services.AddScoped<IProdutoRepository, ProdutoRepository > ();
/*Acima, utilizamos o AddScoped pois a cada tipo de requisição ele irá criar uma única instância, ou seja, dentro da mesma
 requisição todo mundo irá utilizar a mesma instância. Em outra requisição, ele irá criar uma nova (GET,POST, PUT e DELETE.)*/

builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
//Acima, funciona da mesma forma que a configuração do serviço anterior.

/*Abaixo, realizaremos as configurações para acesso ao BD*/
string mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext> (options =>
options.UseMySql(mySqlConnection,ServerVersion.AutoDetect(mySqlConnection)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
