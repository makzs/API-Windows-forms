namespace API.Models.Pessoa
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Documento { get; set; }


        public Pessoa(string nome, string telefone, string documento)
        {
            Nome = nome;
            Telefone = telefone;
            Documento = documento;
        }


    }
}
