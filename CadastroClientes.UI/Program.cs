using CadastroClientes.Application.Interfaces;
using CadastroClientes.Application.Services;
using CadastroClientes.Infrastructure.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace CadastroClientes.UI;

internal static class Program
{

    public static ServiceProvider? ServiceProvider { get; private set; }

    private static readonly string ConnectionString =
        @"Server=(localdb)\MSSQLLocalDB;Database=CadastroClientesDB;Integrated Security=True;TrustServerCertificate=True;";

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // Chamar uma única vez e antes de criar qualquer formulário/controle
        ApplicationConfiguration.Initialize();

        ConfigurarServicos();
        InicializarBancoDeDados();

        var FrmLogin = ServiceProvider!.GetRequiredService<frmLogin>();
        System.Windows.Forms.Application.Run(FrmLogin);

        if (FrmLogin.LoginBemSucedido)
        {
            var FrmPrincipal = ServiceProvider!.GetRequiredService<frmPrincipal>();
            System.Windows.Forms.Application.Run(FrmPrincipal);
        }
    }

    static void ConfigurarServicos()
    {
        var services = new ServiceCollection();

        services.AddScoped<IClienteRepository>(_ => new ClienteRepository(ConnectionString));
        services.AddScoped<IUsuarioRepository>(_ => new UsuarioRepository(ConnectionString));

        services.AddScoped<ClienteService>();
        services.AddScoped<AutenticacaoService>();

        services.AddTransient<frmLogin>();
        services.AddTransient<frmPrincipal>();
        services.AddTransient<frmCliente>();

        ServiceProvider = services.BuildServiceProvider();
    }

    static void InicializarBancoDeDados()
    {
        try
        {
            using var connection = new SqlConnection(ConnectionString);
            connection.Open();

            using var cmdVerificar = new SqlCommand("SELECT COUNT(*) FROM Usuarios", connection);
            var count = Convert.ToInt32(cmdVerificar.ExecuteScalar());

            if (count == 0)
            {
                var senhaHash = GerarHash("admin123");

                const string sqlInsert = @"INSERT INTO Usuarios(Nome, Login, SenhaHash, DataCadastro, Ativo) VALUES (@Nome, @Login, @SenhaHash, @DataCadastro, @Ativo)";

                using var cmdInsert = new SqlCommand(sqlInsert, connection);

                cmdInsert.Parameters.AddWithValue("@Nome", "Administrador");
                cmdInsert.Parameters.AddWithValue("@Login", "admin");
                cmdInsert.Parameters.AddWithValue("@SenhaHash", senhaHash);
                cmdInsert.Parameters.AddWithValue("@DataCadastro", DateTime.Now);
                cmdInsert.Parameters.AddWithValue("@Ativo", true);

                cmdInsert.ExecuteNonQuery(); 

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao inicializar banco de dados: \n\n{ex.Message}", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private static string GerarHash(string senha)
    {
        var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(senha));
        return Convert.ToHexString(bytes).ToLower();
    }

}