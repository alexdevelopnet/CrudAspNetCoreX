using CrudAspNetCoreX.Models;
using CrudAspNetCoreX.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CrudAspNetCoreX.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;

        public ContatoController(IContatoRepositorio contatoRepositorio
            )
        {
            _contatoRepositorio = contatoRepositorio;
        }

        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();
            return View(contatos);
        }
    }
}
