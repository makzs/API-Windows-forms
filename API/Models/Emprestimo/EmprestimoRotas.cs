
using API.Data;
using API.Models.Emprestimo.Requests;
using Microsoft.EntityFrameworkCore;

namespace API.Models.Emprestimo
{
    public static class EmprestimoRotas
    {

        public static void adicionarRotasEmprestimos(this WebApplication app)
        {
            var emprestimoRotas = app.MapGroup("Emprestimos");

            emprestimoRotas.MapPost("", async (AddEmprestimoRequest request, AppDbContext contexto) =>
            {
                var existe = await contexto.Emprestimos.AnyAsync(x => x.PessoaId == request.pessoaId && x.LivroId == request.livroId);

                if (existe)
                    return Results.Conflict("Esse emprestimo ja foi registrado");

                var emprestimo = new Emprestimo(request.pessoaId, request.pessoa, request.livroId, request.livro);
                await contexto.AddAsync(emprestimo);
                await contexto.SaveChangesAsync();
                return Results.Ok(emprestimo);
            });

            emprestimoRotas.MapGet("", async (AppDbContext contexto) =>
            {
                return await contexto.Emprestimos.ToListAsync();
            });

            emprestimoRotas.MapPut("{id}", async (int id, UpdateEmprestimoRequest request, AppDbContext contexto) =>
            {
                var emprestimo = await contexto.Emprestimos.SingleOrDefaultAsync(x => x.Id == id);

                if (emprestimo == null)
                {
                    return Results.Conflict("Emprestimo não encontrado");
                }

                emprestimo.DevolucaoData = emprestimo.DevolucaoData.AddDays(14);

                await contexto.SaveChangesAsync();
                return Results.Ok("emprestimo prorrogado com sucesso");
            });

            emprestimoRotas.MapDelete("{id}", async (int id, AppDbContext contexto) =>
            {
                var emprestimo = await contexto.Emprestimos.SingleOrDefaultAsync(x => x.Id == id);

                if (emprestimo == null)
                {
                    return Results.Conflict("Emprestimo não encontrado");
                }

                contexto.Emprestimos.Remove(emprestimo);
                await contexto.SaveChangesAsync();
                return Results.Ok("emprestimo Encerrado com sucesso");
            });
        }
    }
}
