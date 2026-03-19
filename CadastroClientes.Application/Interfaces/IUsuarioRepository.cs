using CadastroClientes.Domain.Entities;

namespace CadastroClientes.Application.Interfaces;

/// <summary>
/// Interface que define o contrato para acesso a dados de Usuários.
///
/// MESMO PRINCÍPIO DO IClienteRepository:
/// - Definida na Application (quem PRECISA usar)
/// - Implementada na Infrastructure (quem SABE como acessar o banco)
/// - Inversão de Dependência: Application não depende de detalhes de banco de dados
/// </summary>
public interface IUsuarioRepository
{
    /// <summary>
    /// Busca um usuário pelo login (usado na autenticação) 
    /// </summary>
    Task<Usuario?> BuscarPorLoginAsync(string login);

    /// <summary>
    /// Adiciona um novo usuário ao banco
    /// </summary>
    Task AdicionarAsync(Usuario usuario);

    /// <summary>
    /// Verifica se já existe um usuário com o login informado
    /// </summary>
    Task<bool> LoginExisteAsync(string login);
}
