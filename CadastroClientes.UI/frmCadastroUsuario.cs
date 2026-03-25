using CadastroClientes.Application.Services;

namespace CadastroClientes.UI;

public partial class frmCadastroUsuario : Form
{
    private readonly AutenticacaoService _autenticacaoService;

    public string LoginCadastrado { get; private set; } = string.Empty;

    public frmCadastroUsuario(AutenticacaoService autenticacaoService)
    {
        _autenticacaoService = autenticacaoService;
        InitializeComponent();
    }

    private void frmCadastroUsuario_Load(object sender, EventArgs e)
    {
        txtNome.Focus();
        lblMensagem.Text = string.Empty;
    }

    private async void btnCadastrar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNome.Text))
        {
            MostrarErro("O campo Nome é obrigatório.");
        }

        if (string.IsNullOrWhiteSpace(txtLogin.Text))
        {
            MostrarErro("O campo Login é obrigatório.");
        }

        if (string.IsNullOrWhiteSpace(txtSenha.Text))
        {
            MostrarErro("O campo Senha é obrigatório.");
        }

        if (txtSenha.Text != txtConfirmarSenha.Text)
        {
            MostrarErro("As senhas não conferem. Tente novamente.");
            txtConfirmarSenha.Clear();
            txtConfirmarSenha.Focus();
            return;
        }

        btnCadastrar.Enabled = false;
        lblMensagem.ForeColor = Color.Green;
        lblMensagem.Text = "Cadastrando...";

        try
        {
            var (sucesso, mensagem) = await _autenticacaoService.RegistrarUsuarioAsync(
                txtNome.Text.Trim(),
                txtLogin.Text.Trim(),
                txtSenha.Text
                );

            if (sucesso)
            {
                LoginCadastrado = txtLogin.Text.ToLower().Trim();

                MessageBox.Show(
                    $"Usuário: '{LoginCadastrado}' cadastrado com sucesso!\n\nAgora faça login com suas credenciais.",
                    "Cadastro Realizado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MostrarErro(mensagem);
            }
        }
        catch (Exception ex)
        {
            MostrarErro("Erro ao cadastrar, verifique o banco de dados.");
            MessageBox.Show($"Erro: {ex.Message}",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            btnCadastrar.Enabled = true;
        }

    }

    private void MostrarErro(string mensagem)
    {
        lblMensagem.ForeColor = Color.Red;
        lblMensagem.Text = mensagem;
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }
}

