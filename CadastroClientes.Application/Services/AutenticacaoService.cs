using System.Security.Cryptography;
using System.Text;
using CadastroClientes.Application.Interfaces;
using CadastroClientes.Domain.Entities;

namespace CadastroClientes.Application.Services;

/// <summary>
/// Service responsável pela autenticação de usuários.
///
/// CAMADA APPLICATION:
/// - Orquestra o caso de uso de "fazer login"
/// - Contém a lógica de hash de senha (decisão de segurança)
/// - NÃO acessa o banco diretamente (usa IUsuarioRepository)
///
/// FLUXO DE AUTENTICAÇÃO:
/// 1. UI envia login e senha para AutenticacaoService.AutenticarAsync()
/// 2. Service busca o usuário pelo login (via Repository)
/// 3. Service gera o hash da senha informada
/// 4. Service compara com o hash salvo no banco
/// 5. Retorna sucesso ou falha
///
/// O QUE NÃO FAZER AQUI:
/// - Não exibir mensagens visuais (isso é da UI)
/// - Não acessar o banco de dados diretamente (isso é da Infrastructure)
/// </summary>
public class AutenticacaoService
{
    private readonly IUsuarioRepository _usuarioRepository;

    /// <summary>
    /// Usuário logado atualmente (null se não autenticado)
    ///
    /// POR QUE GUARDAR O USUÁRIO LOGADO?
    /// - Para saber quem está usando o sistema
    /// - Para futuras funcionalidades (ex: logs de auditoria)
    /// </summary>
    public Usuario? UsuarioLogado { get; private set; }

    public AutenticacaoService(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    /// <summary>
    /// Autentica um usuário com login e senha.
    ///
    /// FLUXO:
    /// 1. Busca usuário pelo login
    /// 2. Verifica se existe e está ativo
    /// 3. Compara o hash da senha informada com o hash salvo
    /// 4. Retorna (sucesso, mensagem)
    /// </summary>
    public async Task<(bool Sucesso, string Mensagem)> AutenticarAsync(string login, string senha)
    {
        // Validações básicas
        if (string.IsNullOrWhiteSpace(login))
            return (false, "Informe o login.");

        if (string.IsNullOrWhiteSpace(senha))
            return (false, "Informe a senha.");

        // Buscar usuário no banco (via Repository)
        var usuario = await _usuarioRepository.BuscarPorLoginAsync(login);

        if (usuario == null)
            return (false, "Usuário não encontrado.");

        if (!usuario.Ativo)
            return (false, "Usuário inativo. Contate o administrador.");

        // Comparar senhas (hash da senha informada vs hash salvo)
        var hashInformado = GerarHash(senha);
        if (hashInformado != usuario.SenhaHash)
            return (false, "Senha incorreta.");

        // Login bem-sucedido!
        UsuarioLogado = usuario;
        return (true, $"Bem-vindo, {usuario.Nome}!");
    }

    /// <summary>
    /// Registra um novo usuário no sistema.
    /// </summary>
    public async Task<(bool Sucesso, string Mensagem)> RegistrarUsuarioAsync(string nome, string login, string senha)
    {
        // Validar senha ANTES de gerar o hash
        if (string.IsNullOrWhiteSpace(senha) || senha.Length < 4)
            return (false, "A senha deve ter pelo menos 4 caracteres.");

        // Verificar se o login já existe
        if (await _usuarioRepository.LoginExisteAsync(login))
            return (false, "Já existe um usuário com esse login.");

        // Criar entidade e gerar hash
        var usuario = new Usuario
        {
            Nome = nome,
            Login = login.ToLower().Trim(),
            SenhaHash = GerarHash(senha)
        };

        // Validar regras de negócio do Domain
        var erros = usuario.Validar();
        if (erros.Count > 0)
            return (false, string.Join("\n", erros));

        // Persistir via Repository
        await _usuarioRepository.AdicionarAsync(usuario);
        return (true, "Usuário registrado com sucesso!");
    }

    /// <summary>
    /// Faz logout do usuário atual.
    /// </summary>
    public void Logout()
    {
        UsuarioLogado = null;
    }

    /// <summary>
    /// Gera um hash SHA-256 da senha.
    ///
    /// POR QUE SHA-256?
    /// - Simplicidade didática (fácil de entender)
    /// - Em produção, use BCrypt ou Argon2 (mais seguros contra ataques)
    /// - O importante é NUNCA armazenar senha em texto puro
    ///
    /// NOTA EDUCACIONAL:
    /// SHA-256 é uma função de hash criptográfico que transforma
    /// qualquer texto em uma sequência fixa de 64 caracteres hexadecimais.
    /// É uma operação de mão única: não é possível "desfazer" o hash.
    /// </summary>
    private static string GerarHash(string senha)
    {
        var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(senha));
        return Convert.ToHexString(bytes).ToLower();
    }
}
