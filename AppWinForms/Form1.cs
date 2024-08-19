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
        private Pessoa _pessoaSelecionada {  get; set; }
        public Form1()
        {
            InitializeComponent();
            this._operacoesPessoa = new OperacoesPessoa();
        }

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
        }
    }
}
