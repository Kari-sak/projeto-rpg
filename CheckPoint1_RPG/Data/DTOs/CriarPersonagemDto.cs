using CheckPoint1_RPG.Models;
using System.ComponentModel.DataAnnotations;

namespace CheckPoint1_RPG.Data.DTOs
{
    public class CriarPersonagemDto
    {

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Idade { get; set; }

        [Required]
        public string Classe { get; set; }

        [Required]
        public int Vida { get; set; }

        [Required]
        public int Dano_fisico { get; set; }

        [Required]
        public int Dano_magico { get; set; }

        [Required]
        public int Res_magica { get; set; }

        [Required]
        public int Res_fisica { get; set; }

    }
}
