using CrudAspNetCoreX.Models;
using CrudAspNetCoreX.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CrudAspNetCoreX.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;

        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }

        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contato = _contatoRepositorio.Adicionar(contato);
                    TempData["MessagemSucesso"] = "Contato cadastrodo com sucesso!";
                    return RedirectToAction("Index");
                }
                return View(contato);
            }
            catch (Exception erro)
            {
                TempData["MesagemErro"] = $"Ops, não conseguimos cadastrar seu contato, tente novamente , detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int id) 
        {
            ContatoModel contato = _contatoRepositorio.BuscarPorID(id);
            return View(contato);
        }

        [HttpPost]
        public IActionResult Editar(ContatoModel contato)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    contato = _contatoRepositorio.Atualizar(contato);
                    TempData["MensagemSucesso"] = "Contato alterado com sucesso!";
                    return RedirectToAction("Index");
                }
                return View(contato);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos atualizar seu contato, tente novamante, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _contatoRepositorio.Apagar(id);
                if (apagado) TempData["MensagemSucesso"] = "Contato apagado com sucesso!"; else TempData["MensagemErro"] = "Ops, não conseguimos cadastrar seu contato, tente novamante!";
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu contato, tente novamante, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            ContatoModel contato = _contatoRepositorio.BuscarPorID(id);
            return View(contato);
        }
    }
}
