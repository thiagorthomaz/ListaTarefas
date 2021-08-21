using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarefas.Data;
using Tarefas.Models;

namespace Tarefas.Repository
{
    public class TarefaRepository : Repository<Tarefa>, ITarefaRepository
    {
        public TarefaRepository(ApplicationDbContext context) : base(context)
        {

        }

        public Task<Tarefa> BuscarPorId(int Id)
        {
            return GetAll().FirstOrDefaultAsync( x => x.Id == Id);
            
        }
    }
}
