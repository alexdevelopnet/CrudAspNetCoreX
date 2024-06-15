using CrudAspNetCoreX.Data;
using CrudAspNetCoreX.Models;
using System.Collections.Generic;
using System.Linq;

namespace CrudAspNetCoreX.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContent _context;

        public ContatoRepositorio(BancoContent context)
        {
            _context = context;
        }

        public List<ContatoModel> BuscarTodos()
        {
           return _context.Contatos.ToList();
        }
        public ContatoModel BuscarPorID(int id)
        {
            throw new System.NotImplementedException();
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            throw new System.NotImplementedException();
        }

        public bool Apagar(int id)
        {
            throw new System.NotImplementedException();
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            throw new System.NotImplementedException();
        }


    }
}
