using API.Data;
using API.Models.Pessoa.Requests;
using Microsoft.EntityFrameworkCore;

namespace API.Models.Pessoa
{
    public static class PessoasRotas
    {
        public static void AdicionarRotasPessoas(this WebApplication app)
        {
            var pessoasRotas = app.MapGroup("Pessoas");

            pessoasRotas.MapPost("", async (AddPessoaRequest request, AppDbContext contexto) =>
            {
                var existe = await contexto.Pessoas.AnyAsync(x => x.Documento == request.documento);

                if (existe)
                    return Results.Conflict("Esse documento ja foi registrado");

                var pessoa = new Pessoa(request.nome, request.telefone, request.documento);
                await contexto.Pessoas.AddAsync(pessoa);
                await contexto.SaveChangesAsync();
                return Results.Ok(pessoa);
            });

            pessoasRotas.MapGet("", async (AppDbContext contexto) =>
            {
                return await contexto.Pessoas.ToListAsync();
            });

            pessoasRotas.MapPut("{id}", async(int id, UpdatePessoaRequest request, AppDbContext contexto) =>
            {
                var pessoa = await contexto.Pessoas.SingleOrDefaultAsync(x => x.Id == id);

                if (pessoa is null)
                    return Results.NotFound();

                pessoa.Documento = request.documento;
                pessoa.Telefone = request.telefone;
                pessoa.Nome = request.nome;

                await contexto.SaveChangesAsync();
                return Results.Ok(pessoa);
            });

            pessoasRotas.MapDelete("{id}", async(int id, AppDbContext contexto) =>
            {
                var pessoa = await contexto.Pessoas.SingleOrDefaultAsync(x => x.Id == id);

                if (pessoa is null)
                    return Results.NotFound();

                contexto.Pessoas.Remove(pessoa);
                await contexto.SaveChangesAsync();
                return Results.Ok(pessoa);
            });
        }
    }
}
