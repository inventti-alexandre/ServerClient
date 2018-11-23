using ClienteRest.Model;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace ClienteRest
{
    public partial class Form1 : Form
    {
        private HttpClient HttpClient { get; set; }

        public Form1()
        {
            InitializeComponent();
            HttpClient = new HttpClient();
            btnConfAlterar.Hide();
            btnCancAlterar.Hide();
            txtId.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Carregar();
        }
        public async void Carregar()
        {
            var resposta = await HttpClient.PostAsync("http://localhost:32403/api/Estoque/Fornecedores", null);

            if (resposta.IsSuccessStatusCode)
            {
                var fornsObj = await resposta.Content.ReadAsStringAsync();
                var fornecedores = JsonConvert.DeserializeObject<Fornecedor[]>(fornsObj).ToList();

                dataGridFornecedores.DataSource = fornecedores;
            }
            else
            {
                MessageBox.Show("Não foi possível conectar.", "Alerta!");
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtCidade.Text != "" && txtEstado.Text != "")
            {
                var forn = new Fornecedor()
                {
                    Nome = txtNome.Text,
                    Cidade = txtCidade.Text,
                    Estado = txtEstado.Text
                };

                Gravar(forn);
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Alerta!");
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridFornecedores.SelectedRows.Count > 0)
            {
                var forn = (Fornecedor)dataGridFornecedores.SelectedRows[0].DataBoundItem;

                txtId.Text = forn.Id.ToString();
                txtNome.Text = forn.Nome;
                txtCidade.Text = forn.Cidade;
                txtEstado.Text = forn.Estado;

                btnGravar.Hide();
                btnExcluir.Hide();
                btnConfAlterar.Show();
                btnCancAlterar.Show();
            }
        }

        private void btnConfAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtCidade.Text != "" && txtEstado.Text != "")
            {
                var forn = new Fornecedor()
                {
                    Id = Convert.ToInt32(txtId.Text),
                    Nome = txtNome.Text,
                    Cidade = txtCidade.Text,
                    Estado = txtEstado.Text
                };

                Atualizar(forn);
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Alerta!");
            }
        }        

        private void btnCancAlterar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNome.Clear();
            txtCidade.Clear();
            txtEstado.Clear();

            btnGravar.Show();
            btnExcluir.Show();
            btnConfAlterar.Hide();
            btnCancAlterar.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridFornecedores.SelectedRows.Count > 0)
            {
                var forn = (Fornecedor)dataGridFornecedores.SelectedRows[0].DataBoundItem;

                Excluir(forn);
            }
        }              

        public async void Gravar(Fornecedor fornecedor)
        {
            var jsonFornecedor = JsonConvert.SerializeObject(fornecedor);

            var resposta = await HttpClient.PostAsync(
                "http://localhost:32403/api/Estoque/GravarFornecedor", 
                new StringContent (jsonFornecedor, UnicodeEncoding.UTF8, "application/json")
            );

            if (resposta.IsSuccessStatusCode)
            {
                txtId.Clear();
                txtNome.Clear();
                txtCidade.Clear();
                txtEstado.Clear();
                Carregar();
                MessageBox.Show("Fornecedor inserido com sucesso", "Sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possível conectar.","Alerta!");
            }
        }

        private async void Atualizar(Fornecedor fornecedor)
        {
            var jsonFornecedor = JsonConvert.SerializeObject(fornecedor);

            var resposta = await HttpClient.PostAsync(
                "http://localhost:32403/api/Estoque/EditarFornecedor",
                new StringContent(jsonFornecedor, UnicodeEncoding.UTF8, "application/json")
            );

            if (resposta.IsSuccessStatusCode)
            {
                txtId.Clear();
                txtNome.Clear();
                txtCidade.Clear();
                txtEstado.Clear();

                btnGravar.Show();
                btnExcluir.Show();
                btnConfAlterar.Hide();
                btnCancAlterar.Hide();

                Carregar();
                MessageBox.Show("Fornecedor alterado com sucesso", "Sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possível conectar.", "Alerta!");
            }
        }

        public async void Excluir(Fornecedor fornecedor)
        {
            var jsonFornecedor = JsonConvert.SerializeObject(fornecedor);

            var resposta = await HttpClient.PostAsync(
                "http://localhost:32403/api/Estoque/ApagarFornecedor",
                new StringContent(jsonFornecedor, UnicodeEncoding.UTF8, "application/json")
            );

            if (resposta.IsSuccessStatusCode)
            {
                Carregar();
                MessageBox.Show("Fornecedor excluido com sucesso!", "Sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possível conectar.", "Alerta!");
            }
        }
    }
}
