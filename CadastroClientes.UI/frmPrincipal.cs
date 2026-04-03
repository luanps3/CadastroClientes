using CadastroClientes.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadastroClientes.UI
{
    public partial class frmPrincipal : Form
    {
        private readonly ClienteService _clienteService;
        public frmPrincipal(ClienteService clienteService)
        {
            _clienteService = clienteService;
            InitializeComponent();
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private async Task CarregarClientes()
        {
            try
            {
                var clientes = await _clienteService.ListarTodosAsync();
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = clientes;
                ConfigurarGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar clientes: " +
                    $"{ex.Message}", "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrid()
        {
            if (dgvClientes.Columns.Count == 0) return;

            dgvClientes.Columns["Id"].HeaderText = "Código";
            dgvClientes.Columns["Id"].Width = 80;

            dgvClientes.Columns["Nome"].HeaderText = "Nome";
            dgvClientes.Columns["Nome"].Width = 250;

            dgvClientes.Columns["Email"].HeaderText = "E-mail";
            dgvClientes.Columns["Email"].Width = 200;

            dgvClientes.Columns["Telefone"].HeaderText = "Telefone";
            dgvClientes.Columns["Telefone"].Width = 120;

            dgvClientes.Columns["DataCadastro"].HeaderText = "Data Cadastro";
            dgvClientes.Columns["DataCadastro"].Width = 120;
            dgvClientes.Columns["DataCadastro"].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvClientes.Columns["Ativo"].HeaderText = "Ativo";
            dgvClientes.Columns["Ativo"].Width = 60;

            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = false;
        }

        private async void frmPrincipal_Load(object sender, EventArgs e)
        {
            await CarregarClientes();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var frmCadastro = Program.ServiceProvider!.GetRequiredService<frmCliente>();
            frmCadastro.ShowDialog();  
        }
    }
}
