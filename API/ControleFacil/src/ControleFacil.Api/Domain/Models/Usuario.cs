using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFacil.Api.Models
{
    public class Usuario
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "O campo de email é obrigatório")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo da senha é obrigatório")]
        public string Senha { get; set; } = string.Empty;

        [Required]
        public DateTime DataCadastro { get; set; }
        public DateTime? DataInativacao { get; set; }


    }
}