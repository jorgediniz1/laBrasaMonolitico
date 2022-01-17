using LaBrasa.Shared.Entities;
using LaBrasa.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaBrasa.Shared.Repository
{
    public class ProdutoRepository : IProdutoRepo
    {
        private readonly LaBrasaContext _context;
        public ProdutoRepository(LaBrasaContext context)
        {
            _context = context;
        }
        public async Task<Produto> IncluirProduto(Produto produto)
        {
            try
            {
                await _context.AddAsync(produto);
                await _context.SaveChangesAsync();

                return produto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> ApagarProduto(int id)
        {
            try
            {
                if (!Exists(id))
                {
                    return false;
                }

                try
                {
                    var prod = await _context.Produtos.FirstOrDefaultAsync(x => x.Id == id);

                    _context.Produtos.Remove(prod);

                    await _context.SaveChangesAsync();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<Produto> AtualizarProduto(Produto produto)
        {
            try
            {
                var prod = await _context.Produtos.FirstOrDefaultAsync(x => x.Id == produto.Id);

                _context.Update(produto);

                await _context.SaveChangesAsync();

                return prod;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<Produto> PegarPeloId(int id)
        {
            try
            {
                var prop = await _context.Produtos.FirstOrDefaultAsync(x => x.Id == id);

                return prop;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Produto>> PegarTodos()
        {
            try
            {
                var prodList = await _context.Produtos.ToListAsync();

                return prodList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool Exists(int id)
        {
            try
            {
                var func = _context.Funcionarios.FirstOrDefault(x => x.Id == id);

                return func != null ? true : false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
