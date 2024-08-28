using AppWinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinForms
{
    public partial class Form1 : Form
    {
        private readonly OperacoesPessoa _operacoesPessoa;
        private readonly OperacoesLivro _operacoesLivro;
        private Pessoa _pessoaSelecionada {  get; set; }
        private Livro _livroSelecionado { get; set; }
        public Form1()
        {
            InitializeComponent();
            this._operacoesPessoa = new OperacoesPessoa();
            this._operacoesLivro = new OperacoesLivro();
        }


        // Layout entidade Pessoa
        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            await _operacoesPessoa.CreatePessoaAsync(new Pessoa()
            {
                Nome = txtNomeCompleto.Text,
                Telefone = txtTelefone.Text,
                Documento = txtDocumento.Text
            });
            await LoadPessoasAsync();
        }

        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            await _operacoesPessoa.UpdatePessoaAsync(_pessoaSelecionada.Id, new Pessoa()
            {
                Nome = txtNomeCompleto.Text,
                Telefone = txtTelefone.Text,
                Documento = txtDocumento.Text
            });
            await LoadPessoasAsync();
        }

        private async void btnDeletar_Click(object sender, EventArgs e)
        {
            await _operacoesPessoa.DeletePessoaAsync(_pessoaSelecionada.Id);
            await LoadPessoasAsync();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private async Task LoadPessoasAsync()
        {
            var pessoas = await _operacoesPessoa.GetPessoasAsync();
            dataGridView1.DataSource = pessoas;
        }

        private void Limpar()
        {
            this.txtNomeCompleto.Text = string.Empty;
            this.txtTelefone.Text = string.Empty;
            this.txtDocumento.Text = string.Empty;
            _pessoaSelecionada = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // verifica se realmente tem uma linha selecionada
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                this._pessoaSelecionada = row.DataBoundItem as Pessoa;

                this.txtNomeCompleto.Text = this._pessoaSelecionada.Nome;
                this.txtTelefone.Text = this._pessoaSelecionada.Telefone;
                this.txtDocumento.Text = this._pessoaSelecionada.Documento;
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadPessoasAsync();
            await LoadLivrosAsync();
        }

        // Layout Livro

        private async Task LoadLivrosAsync()
        {
            var livros = await _operacoesLivro.GetLivrosAsync();
            dataGridView2.DataSource = livros;
        }

        private void LimparLivros()
        {
            this.txtTitulo.Text = string.Empty;
            this.txtAutor.Text = string.Empty;
            this.txtAno.Text = string.Empty;
            _livroSelecionado = null;
        }

        private async void btnAdicionarLivro_Click(object sender, EventArgs e)
        {
            await _operacoesLivro.CreateLivroAsync(new Livro()
            {
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                Ano = int.Parse(txtAno.Text)
            });
            await LoadLivrosAsync();
        }

        private async void btnAtualizarLivro_Click(object sender, EventArgs e)
        {
            await _operacoesLivro.UpdateLivroAsync(_livroSelecionado.Id, new Livro()
            {
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                Ano = int.Parse(txtAno.Text)
            });
            await LoadLivrosAsync();
        }

        private async void btnDeletarLivro_Click(object sender, EventArgs e)
        {
            await _operacoesLivro.DeleteLivroAsync(_livroSelecionado.Id);
            await LoadLivrosAsync();
        }

        private void btnLimparLivros_Click(object sender, EventArgs e)
        {
            LimparLivros();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // verifica se realmente tem uma linha selecionada
            if (e.RowIndex >= 0)
            {
                var row = dataGridView2.Rows[e.RowIndex];
                this._livroSelecionado = row.DataBoundItem as Livro;

                this.txtTitulo.Text = this._livroSelecionado.Titulo;
                this.txtAutor.Text = this._livroSelecionado.Autor;
                this.txtAno.Text = this._livroSelecionado.Ano.ToString();
            }
        }

    }
}
