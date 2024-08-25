
using API.Data;
using API.Models.Livro.Requests;
using System.Data.Entity;

namespace API.Models.Livro
{
    public static class LivroRotas
    {

        public static void adicionarRotasLivros(this WebApplication app)
        {
            var livroRotas = app.MapGroup("Livros");

            livroRotas.MapPost("", async (AddLivroRequest request, AppDbContext contexto) =>
            {
                var livro = new Livro(request.titulo, request.autor, request.ano);
                await contexto.Livros.AddAsync(livro);
                await contexto.SaveChangesAsync();
                return Results.Ok(livro);
            });

            livroRotas.MapGet("", async (AppDbContext contexto) =>
            {
                return await contexto.Livros.ToListAsync();
            });

            livroRotas.MapPut("{id}", async (int id, UpdateLivroRequest request, AppDbContext contexto) =>
            {
                var livro = await contexto.Livros.SingleOrDefaultAsync(x => x.Id == id);

                livro.Titulo = request.titulo;
                livro.Autor = request.autor;
                livro.Ano = request.ano;

                await contexto.SaveChangesAsync();
                return Results.Ok(livro);
            });

            livroRotas.MapDelete("{id}", async (int id, AppDbContext contexto) =>
            {
                var livro = await contexto.Livros.SingleOrDefaultAsync(x => x.Id == id);

                if (livro is null)
                {
                    return Results.NotFound();
                }

                contexto.Livros.Remove(livro);
                await contexto.SaveChangesAsync();
                return Results.Ok(livro);
            });
        }

    }
}
