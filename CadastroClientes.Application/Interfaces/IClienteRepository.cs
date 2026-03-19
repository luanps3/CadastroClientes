using CadastroClientes.Domain.Entities;

namespace CadastroClientes.Application.Interfaces;

public interface IClienteRepository
{
    ///<summary>
    /// Adiciona um cliente no banco de dados
    /// </summary>
    Task<Cliente> AdicionarAsync(Cliente cliente);

    ///<summary>
    /// Atualiza um cliente no banco de dados
    /// </summary>
    Task<Cliente> AtualizarAsync(Cliente cliente);

    ///<summary>
    /// Exclui um cliente no banco de dados
    /// </summary>
    Task<bool> ExcluirAsync(int id);

    ///<summary>
    /// Busca um cliente no banco de dados por ID específico
    /// </summary>
    Task<Cliente?> BuscarPorIdAsync(int id);

    ///<summary>
    /// Lista todos os clientes do banco de dados
    /// </summary>
    Task<List<Cliente>> ListarTodosAsync();

    ///<summary>
    /// Lista apenas clientes ativos
    /// </summary>
    Task<List<Cliente>> ListarAtivosAsync();
}

