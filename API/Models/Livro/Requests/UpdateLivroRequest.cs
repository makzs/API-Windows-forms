namespace API.Models.Livro.Requests
{
    public record UpdateLivroRequest(string titulo, string autor, int ano)
    {
    }
}
