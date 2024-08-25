using API.Models.Pessoa;
using System.Text.Json.Serialization;

namespace API.Models.Emprestimo
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }

        [JsonIgnore]
        public Pessoa.Pessoa? Pessoa { get; set; }
        public int LivroId { get; set; }

        [JsonIgnore]
        public Livro.Livro? Livro { get; set; }
        public DateTime EmprestimoData { get; set; }
        public DateTime DevolucaoData { get; set; }

        public Emprestimo(int pessoaId, Pessoa.Pessoa pessoa, int livroId, Livro.Livro livro)
        {
            PessoaId = pessoaId;
            Pessoa = pessoa;
            LivroId = livroId;
            Livro = livro;
            EmprestimoData = DateTime.Now;
            DevolucaoData = EmprestimoData.AddDays(14);
        }

        public Emprestimo()
        {
            EmprestimoData = DateTime.Now;
            DevolucaoData = EmprestimoData.AddDays(14);
        }
    }
}
