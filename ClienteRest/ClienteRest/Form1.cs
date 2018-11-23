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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Carregar();
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridFornecedores.SelectedRows.Count > 0)
            {
                var forn = (Fornecedor)dataGridFornecedores.SelectedRows[0].DataBoundItem;

                Excluir(forn);
            }
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
                MessageBox.Show("Não foi possível conectar.","Alerta!");
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
