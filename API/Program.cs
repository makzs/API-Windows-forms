using API.Data;
using API.Models.Livro;
using API.Models.Pessoa;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(
    options => options.AddPolicy("Acesso Total", configs => configs.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod())
);

builder.Services.AddScoped<AppDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.AdicionarRotasPessoas();
app.adicionarRotasLivros();
app.UseCors("Acesso Total");
app.Run();

