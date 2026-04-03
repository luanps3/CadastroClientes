using CadastroClientes.Application.Services;
using CadastroClientes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadastroClientes.UI
{
    public partial class frmCliente : Form
    {

        private readonly ClienteService _clienteService;
        private Cliente? _clienteAtual;
        private bool _modoEdicao = false;
        private int? _clienteIdParaEditar;

        public frmCliente(ClienteService clienteService)
        {
            _clienteService = clienteService;
            InitializeComponent();
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do cliente.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Informe o email do cliente.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }

            try
            {
                if (_clienteAtual == null)
                {
                    _clienteAtual = new Cliente();

                    _clienteAtual.Nome = txtNome.Text;
                    _clienteAtual.Email = txtEmail.Text;
                    _clienteAtual.Telefone =
                        string.IsNullOrWhiteSpace(txtTelefone.Text)
                        ? null : txtTelefone.Text.Trim();
                    _clienteAtual.Ativo = chkAtivo.Checked;

                    bool sucesso;
                    List<string> erros;
                    Cliente? clienteSalvo;

                    if (_modoEdicao)
                    {
                        (sucesso, erros, clienteSalvo) = await _clienteService.AtualizarClienteAsync(_clienteAtual);
                    }
                    else
                    {
                        (sucesso, erros, clienteSalvo) = await _clienteService.CadastrarClienteAsync(_clienteAtual);
                    }

                    if (sucesso)
                    {
                        MessageBox.Show("Cliente salvo com sucesso.",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        var mensagemErros = string.Join("\n", erros);
                        MessageBox.Show(mensagemErros,
                        "Erro de validação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o cliente: {ex.Message}",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

        }
    }
}
