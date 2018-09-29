using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Fiap01.Models
{
    public class Pergunta
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="favor preencher a descriição")]
        public string Descricao { get; set; }

        public string Autor { get; set; }
    }
}
