namespace API.Models.Livro.Requests
{
    public record AddLivroRequest(string titulo, string autor, int ano)
    {
    }
}
