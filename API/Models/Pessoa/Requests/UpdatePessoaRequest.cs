using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Pessoa.Requests
{
    public record UpdatePessoaRequest(string nome, string telefone, string documento)
    {
        
    }
}