using CadastroClientes.Application.Services;
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

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar clientes: " +
                    $"{ex.Message}","Erro", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private async void frmPrincipal_Load(object sender, EventArgs e)
        {
            await CarregarClientes();
        }
    }
}
