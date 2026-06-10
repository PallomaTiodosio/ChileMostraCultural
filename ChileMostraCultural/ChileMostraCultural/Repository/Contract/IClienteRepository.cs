using ChileMostraCultural.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChileMostraCultural.Repository.Contract
{
    public interface IClienteRepository
    {
        Cliente Login(string Email, string Senha);

        void Cadastrar(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Excluir(int Id);
        void ObterCliente(int Id);
        IEnumerable<Cliente> ObterTodosClientes();

        //IPagedList<Cliente> ObterTodosClientes(int? pagina, string pesquisa);



    }
}
