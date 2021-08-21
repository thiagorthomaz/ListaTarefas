using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarefas.Models;
using Tarefas.Repository;

namespace Tarefas.Services
{
    public class TarefaService : ITarefaService
    {

        private readonly ITarefaRepository _tarefaRepository;


        public TarefaService(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public Task<Tarefa> BuscarPorId(int Id)
        {
            return _tarefaRepository.GetAll().FirstOrDefaultAsync(x => x.Id == Id);
        }

        public Task<List<Tarefa>> BuscarTodos() {
            return _tarefaRepository.GetAll().ToListAsync();
        }

        public Task<Tarefa> Inserir(Tarefa tarefa) {
            return _tarefaRepository.AddAsync(tarefa);
        }

        public void Remover(Tarefa tarefa)
        {
            _tarefaRepository.Remove(tarefa);
        }
    }
}
