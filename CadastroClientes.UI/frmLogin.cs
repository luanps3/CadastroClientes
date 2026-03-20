using CadastroClientes.Application.Services;
using static Guna.UI2.Native.WinApi;

namespace CadastroClientes.UI
{
    public partial class frmLogin : Form
    {
        private readonly AutenticacaoService _autenticacaoService; //váriavel privada recebe todos os parametros da classe AutenticacaoService

        /// <summary>
        /// Indica se o login foi bem-sucedido.
        /// O Program.cs verifica essa propriedade para decidir se abre o sistema.
        /// </summary>
        public bool LoginBemSucedido { get; private set; }


        //Injeta dependencia da autenticação através do parametro passado via metodo construtor.
        public frmLogin(AutenticacaoService autenticacaoService)
        {
            _autenticacaoService = autenticacaoService;
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private async Task btnEntrar_Click(object sender, EventArgs e)
        {
            btnEntrar.Enabled = false;
            lblMensagem.Text = "Autenticando...";
            lblMensagem.ForeColor = Color.Gray;

            try
            {
                //chama o service (Application)
                // a UI ela apenas passa os dados, ela não sabe como a autenticação funciona
                var (sucesso, mensagem) = await _autenticacaoService.AutenticarAsync(
                    txtEmail.Text.Trim(),
                    txtSenha.Text
                    );


                if (sucesso)
                {
                    LoginBemSucedido = true;
                    lblMensagem.ForeColor = Color.Green;
                    lblMensagem.Text = mensagem;

                    await Task.Delay(800); // 0.8 segundos
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    lblMensagem.ForeColor = Color.Red;
                    lblMensagem.Text = mensagem;
                    txtSenha.Clear();
                    txtSenha.Focus();
                }
            }
            catch (Exception ex)
            {
                lblMensagem.ForeColor = Color.Red;
                lblMensagem.Text = "Erro ao conectar. Verifique o banco de dados.";
                MessageBox.Show($"Erro de conexão: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnEntrar.Enabled = true;
            }

        }

        private void lblCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
