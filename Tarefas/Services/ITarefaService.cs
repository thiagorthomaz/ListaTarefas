using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarefas.Models;

namespace Tarefas.Services
{
    public interface ITarefaService
    {

        public Task<List<Tarefa>> BuscarTodos();

        Task<Tarefa> BuscarPorId(int Id);

        Task<Tarefa> Inserir(Tarefa tarefa);

        void Remover(Tarefa tarefa);


    }
}
