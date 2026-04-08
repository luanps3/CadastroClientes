using CadastroClientes.Application.Services;
using CadastroClientes.Domain.Entities;
using Guna.UI2.WinForms.Enums;
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

        public void CarregarCliente(int id)
        {
            _clienteIdParaEditar = id;
        }

        private void PreencherCampos()
        {
            if (_clienteAtual == null) return;

            txtNome.Text = _clienteAtual.Nome;
            txtEmail.Text = _clienteAtual.Email;
            txtTelefone.Text = _clienteAtual.Telefone;
            chkAtivo.Checked = _clienteAtual.Ativo;
        }






        private async void frmCliente_Load(object sender, EventArgs e)
        {
            if (_clienteIdParaEditar.HasValue)
            {
                _clienteAtual = await _clienteService.BuscarPorIdAsync(_clienteIdParaEditar.Value);

                if (_clienteAtual != null)
                {
                    _modoEdicao = true;
                    this.Text = "Editar Cliente";
                    PreencherCampos();
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                _clienteAtual = new Cliente();
                _modoEdicao = false;
                this.Text = "Novo Cliente";
            }
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o cliente: {ex.Message}",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();   
        }
    }
}
