using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarefas.Models
{
    public class Tarefa
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="O campo descrição é obrigatório")]
        [StringLength(1000, ErrorMessage = "A descrição deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo prazo é obrigatório")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Prazo { get; set; }


    }
}
