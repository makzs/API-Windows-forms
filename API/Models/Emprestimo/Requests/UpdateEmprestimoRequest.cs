namespace API.Models.Emprestimo.Requests
{
    public record UpdateEmprestimoRequest(int pessoaId, Pessoa.Pessoa pessoa, int livroId, Livro.Livro livro)
    {
    }
}
