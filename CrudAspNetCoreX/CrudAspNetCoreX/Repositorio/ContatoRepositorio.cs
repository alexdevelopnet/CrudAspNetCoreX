using CrudAspNetCoreX.Data;
using CrudAspNetCoreX.Models;
using Microsoft.EntityFrameworkCore;
using System;
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
            return _context.Contatos.FirstOrDefault(c => c.Id == id);
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _context.Contatos.Add(contato);
            _context.SaveChanges();
            return contato;
        }
        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatobd = BuscarPorID(contato.Id);
            if (contatobd == null) throw new Exception("Houve um erro na atualização do contato!");
             
            contatobd.Nome = contato.Nome;
            contatobd.Email = contato.Email;
            contatobd.Celular = contato.Celular;

            var existingEntity = _context.Contatos.Find(contatobd.Id);
            if (existingEntity != null)
            {
                _context.Entry(existingEntity).State = EntityState.Detached;
            }
            _context.Contatos.Update(contatobd);
            _context.SaveChanges();
             
            return contatobd;
        }
        public bool Apagar(int id)
        {
            ContatoModel contato = BuscarPorID(id);
            if (contato == null)
            {
                throw new Exception("Houve um Erro na deleção do contato!");
            }
            _context.Contatos.Remove(contato);
            _context.SaveChanges();
            return true;
        }


    }
}
