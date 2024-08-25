namespace API.Models.Emprestimo.Requests
{
    public record AddEmprestimoRequest(int pessoaId, Pessoa.Pessoa pessoa, int livroId, Livro.Livro livro)
    {
    }
}
