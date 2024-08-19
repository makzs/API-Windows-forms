using AppWinForms.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppWinForms
{
    internal class OperacoesPessoa
    {
        private const string _URL = "http://localhost:5291/Pessoas";
        private static readonly HttpClient _client = new HttpClient();

        public async Task<List<Pessoa>> GetPessoasAsync()
        {
            var response = await _client.GetAsync(_URL);
            // certifica se foi um sucesso se nao, nao avança para a proxima linha
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Pessoa>>(responseBody);
        }

        public async Task CreatePessoaAsync(Pessoa pessoa)
        {
            var json = JsonConvert.SerializeObject(pessoa);
            var content = new StringContent (json,Encoding.UTF8,"application/json");
            var response = await _client.PostAsync(_URL, content);
            response.EnsureSuccessStatusCode ();
        }

        public async Task UpdatePessoaAsync(int id, Pessoa pessoa)
        {
            var json = JsonConvert.SerializeObject (pessoa);
            var content = new StringContent(json,Encoding.UTF8,"application/json");
            var response = await _client.PutAsync($"{_URL}/{id}", content);
            response.EnsureSuccessStatusCode ();
        }

        public async Task DeletePessoaAsync(int id)
        {
            var response = await _client.DeleteAsync($"{_URL}/{id}");
            response.EnsureSuccessStatusCode ();
        }
    }
}
