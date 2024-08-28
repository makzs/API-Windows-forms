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
    internal class OperacoesLivro
    {
        private const string _URL = "http://localhost:5291/Livros";
        private static readonly HttpClient _client = new HttpClient();

        public async Task<List<Livro>> GetLivrosAsync()
        {
            var response = await _client.GetAsync(_URL);
            // certifica se foi um sucesso se nao, nao avança para a proxima linha
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Livro>>(responseBody);
        }

        public async Task CreateLivroAsync(Livro livro)
        {
            var json = JsonConvert.SerializeObject(livro);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(_URL, content);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateLivroAsync(int id, Livro livro)
        {
            var json = JsonConvert.SerializeObject(livro);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_URL}/{id}", content);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteLivroAsync(int id)
        {
            var response = await _client.DeleteAsync($"{_URL}/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
