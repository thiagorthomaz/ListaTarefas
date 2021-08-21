using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Tarefas.Data;
using Tarefas.Models;
using Tarefas.Services;
using Tarefas.ViewModel;

namespace Tarefas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITarefaService _tarefaService;

        public HomeController(ILogger<HomeController> logger, ITarefaService tarefaService)
        {
            _logger = logger;
            _tarefaService = tarefaService;
        }

        public async Task<IActionResult> Index()
        {
            IndexTerafaViewModel viewModel = new IndexTerafaViewModel();
            viewModel.Tarefas = await _tarefaService.BuscarTodos();
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Criar(Tarefa tarefa)
        {
            if (ModelState.IsValid) {
                await _tarefaService.Inserir(tarefa);
            }
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Deletar(int id)
        {
            Tarefa tarefa = await _tarefaService.BuscarPorId(id);
            _tarefaService.Remover(tarefa);
            return RedirectToAction("Index");
        }

    }
}
