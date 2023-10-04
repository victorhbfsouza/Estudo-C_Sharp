using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ControleFacil.Api.Domain.Models;

namespace ControleFacil.Api.Models
{
    public class Areceber : Titulo
    {
        [Required(ErrorMessage = "O campo valor recebido é obrigatório")]
        public double ValorRecebido { get; set; }
        public DateTime? DataRecebimento { get; set; }
    }
}