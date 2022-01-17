using LaBrasa.Shared.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaBrasa.Shared.Interfaces
{
    public interface IFuncionarioRepo
    {
        Task<Funcionario> IncluirFuncionario(Funcionario funcionario);
        Task<Funcionario> AtualizarFuncionario(Funcionario funcionario);
        Task<List<Funcionario>> PegarTodos();
        Task<Funcionario> PegarPeloId(int id);
        Task<bool> ApagarFuncionario(int id);    
    }
}
