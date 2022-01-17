using LaBrasa.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBrasa.Shared.Interfaces
{
    public interface IProdutoRepo
    {
        Task<Produto> IncluirProduto(Produto produto);
        Task<Produto> AtualizarProduto(Produto produto);
        Task<List<Produto>> PegarTodos();
        Task<Produto> PegarPeloId(int id);
        Task<bool> ApagarProduto(int id);

    }
}
