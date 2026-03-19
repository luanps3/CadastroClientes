using CadastroClientes.Application.Interfaces;
using CadastroClientes.Domain.Entities;
using System.Runtime.InteropServices;

namespace CadastroClientes.Application.Services;

public class ClienteService
{
    private readonly IClienteRepository _clienteRepository;

    public ClienteService(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public async Task<(bool Sucesso, List<string> Erros, Cliente? Cliente)> CadastrarClienteAsync(Cliente cliente)
    {
        var erros = cliente.Validar();

        if (erros.Any())
        {
            return (false, erros, null);
        }

        try
        {
            var clienteSalvo = await _clienteRepository.AdicionarAsync(cliente);
            return (true, new List<string>(), clienteSalvo);
        }
        catch (Exception erro)
        {
            return (false, new List<string>() { $"Erro ao salvar cliente: {erro.Message}" }, null);
        }




    }

    public async Task<(bool Sucesso, List<string> Erros, Cliente? Cliente)> AtualizarClienteAsync(Cliente cliente)
    {
        var erros = cliente.Validar();

        if (erros.Any())
        {
            return (false, erros, null);
        }


        var clienteExistente = await _clienteRepository.BuscarPorIdAsync(cliente.Id);
        if (clienteExistente == null)
        {
            return (false, new List<string>() { "Cliente não encontrado." }, null);
        }

        try
        {
            var clienteSalvo = await _clienteRepository.AtualizarAsync(cliente);
            return (true, new List<string>(), clienteSalvo);
        }
        catch (Exception erro)
        {
            return (false, new List<string>() { $"Erro ao salvar cliente: {erro.Message}" }, null);
        }




    }

    public async Task<(bool Sucesso, string Mensagem)> ExcluirClienteAsync(int id)
    {
        try
        {
            var existente = await _clienteRepository.BuscarPorIdAsync(id);
            if (existente == null)
            {
                return (false, "Cliente não encontrado.");
            }

            //bool estaChovendo = true;

            //string resultado = estaChovendo ? "levar guarda chuva" : "deixar guarda chuva em casa";
          
            var removido = await _clienteRepository.ExcluirAsync(id);
            return removido ? 
                (true, "Cliente removido com sucesso") : (false, "não foi possivel excluir o cliente.");
           
        }
        catch (Exception erro)
        {
            return (false, $"Erro ao excluir o cliente, erro do externo: " +
                $"{erro.Message}\n erro interno: {erro.InnerException}");
        }
    }

    public async Task<Cliente?>  BuscarPorIdAsync(int id)
    {
        return await _clienteRepository.BuscarPorIdAsync(id);
    }

    public async Task<List<Cliente>> ListarTodosAsync()
    {
        return await _clienteRepository.ListarTodosAsync();
    }

    public async Task<List<Cliente>> ListarAtivosAsync()
    {
        return await _clienteRepository.ListarAtivosAsync();
    }



}

