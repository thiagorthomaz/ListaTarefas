using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarefas.Models;

namespace Tarefas.ViewModel
{
    public class IndexTerafaViewModel
    {
        public List<Tarefa> Tarefas { get; set; }
        public Tarefa Tarefa { get; set; }


        public IndexTerafaViewModel() {
            Tarefas = new List<Tarefa>();
            Tarefa = new Tarefa();
        }

    }
}
