using LaBrasa.Shared.Entities;
using LaBrasa.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaBrasa.Shared.Repository
{
    public class FuncionarioRepository : IFuncionarioRepo
    {
        private readonly LaBrasaContext _context;
        public FuncionarioRepository(LaBrasaContext context)
        {
            _context = context;
        }
        public async Task<Funcionario> IncluirFuncionario(Funcionario funcionario)
        {
            try
            {
                await _context.AddAsync(funcionario);
                await _context.SaveChangesAsync();

                return funcionario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> ApagarFuncionario(int id)
        {
            try
            {
                if (!Exists(id))
                {
                    return false;
                }

                try
                {
                    var func = await _context.Funcionarios.FirstOrDefaultAsync(x => x.Id == id);

                    _context.Funcionarios.Remove(func);

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

        public async Task<Funcionario> AtualizarFuncionario(Funcionario funcionario)
        {
            try
            {
                var Func = await _context.Funcionarios.FirstOrDefaultAsync(x => x.Id == funcionario.Id);

                _context.Update(funcionario);

                await _context.SaveChangesAsync();

                return Func;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<Funcionario> PegarPeloId(int id)
        {
            try
            {
                var Func = await _context.Funcionarios.FirstOrDefaultAsync(x => x.Id == id);

                return Func;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Funcionario>> PegarTodos()
        {
            try
            {
                var FuncList = await _context.Funcionarios.ToListAsync();

                return FuncList;
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
