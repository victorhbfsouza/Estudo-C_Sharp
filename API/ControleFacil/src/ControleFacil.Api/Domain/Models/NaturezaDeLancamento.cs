using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFacil.Api.Models
{
    public class NaturezaDeLancamento
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public long IdUsuario { get; set; }

        public Usuario Usuario { get; set; }

        [Required(ErrorMessage = "O campo de descrição é obrigatório")]
        public string Descricao { get; set; } = string.Empty;
        public string? Observacao { get; set; } = string.Empty;

        [Required]
        public DateTime DataCadastro { get; set; }
        public DateTime? DataInativacao { get; set; }


    }
}